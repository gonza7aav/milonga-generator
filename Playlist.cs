using System;
using System.Collections.Generic;
using System.IO;

namespace milonga_generator
{
    public class Playlist
    {
        // all the acts added to the program
        public List<Act> acts { get; set; }

        // the number of acts that the playlist will have
        public int actsQuantity { get; set; }

        // the number of songs that each act will have
        public int actsLength { get; set; }

        // if the playlist will have interludes between acts
        public bool interludesUsage { get; set; }

        // the path of the folder that contains the interludes
        public string interludesPath { get; set; }

        // if the playlist will use the same interlude
        public bool interludeUsageSame { get; set; }

        public Playlist()
        {
            // defaults values
            acts = new List<Act>();
            actsQuantity = -1;
            actsLength = -1;
            interludesUsage = true;
            interludesPath = "";
            interludeUsageSame = false;
        }

        public List<string> getErrorMessages()
        {
            List<string> messages = new List<string>();

            // playlistActs
            if (acts.Count == 0)
            {
                messages.Add("Debe agregar al menos una tanda");
            }

            // actsQuantity
            if (actsQuantity < 1)
            {
                messages.Add("El número de tandas es inválido");
            }
            else if (actsQuantity > acts.Count)
            {
                messages.Add("No pueden haber más tandas que las agregadas");
            }

            // actsLength
            if (actsLength < 1)
            {
                messages.Add("El número de piezas es inválido");
            }

            // interludesPath;
            if (interludesUsage && interludesPath == "")
            {
                string aux = interludeUsageSame ? "la cortina" : "las cortinas";
                messages.Add($"Debe ingresar la ubicación de {aux}");
            }

            return messages;
        }

        public bool validate()
        {
            return getErrorMessages().Count == 0;
        }

        public void writeSettingsFile(string filePath)
        {
            // open a stream of the file and create the writer
            FileStream stream = File.OpenWrite(filePath);
            BinaryWriter writer = new BinaryWriter(stream);

            // write the settings
            writer.Write(Act.parseToString(acts));
            writer.Write(actsQuantity);
            writer.Write(actsLength);
            writer.Write(interludesUsage);
            writer.Write(interludesPath);
            writer.Write(interludeUsageSame);

            writer.Close();
            stream.Close();
        }

        public void readSettingsFile(string filePath)
        {
            // open a stream of the file and create the reader
            FileStream stream = File.OpenRead(filePath);
            BinaryReader reader = new BinaryReader(stream);

            // read the settings
            acts = Act.parseToList(reader.ReadString());
            actsQuantity = reader.ReadInt32();
            actsLength = reader.ReadInt32();
            interludesUsage = reader.ReadBoolean();
            interludesPath = reader.ReadString();
            interludeUsageSame = reader.ReadBoolean();

            reader.Close();
            stream.Close();
        }

        public void generate(string path)
        {
            string playlistGenerated = generate();
            writePlaylistFile(path, playlistGenerated);
        }

        private string generate()
        {
            string fileString = "";

            List<string> interludesFiles = MusicFolder.getMusicFiles(interludesPath);

            // interlude exceptions
            if (interludesUsage && (
                (!interludeUsageSame && interludesFiles.Count < actsQuantity - 1)
                || (interludeUsageSame && interludesFiles.Count == 0 && actsQuantity != 1)))
            {
                int interludesNeeded = interludeUsageSame ? 1 : actsQuantity - 1;
                string aux = interludesNeeded == 1 ? "pieza" : "piezas";

                throw new Exception($"La carpeta de cortinas {interludesPath} necesita tener al menos {interludesNeeded} {aux}");
            }

            // act exceptions
            foreach (Act act in acts)
            {
                // check if all the acts have enough songs
                if (MusicFolder.getMusicFiles(act.path).Count < actsLength)
                {
                    string aux = actsLength == 1 ? "pieza" : "piezas";
                    throw new Exception($"La carpeta {act.path} necesita tener al menos {actsLength} {aux}");
                }
            }

            // sort the acts and interludes
            List<Act> actsSorted = sortRandom(acts);
            List<string> interludesSorted = interludesUsage ? sortRandom(interludesFiles) : new List<string>();

            for (int i = 0; i < actsQuantity; i++)
            {
                Act current = actsSorted[i];
                List<string> filesSorted = sortRandom(MusicFolder.getMusicFiles(current.path));

                // header
                fileString += $"{(i == 0 ? "" : "\n\n")}# Tanda: {current.name}";
                
                // songs
                for (int j = 0; j < actsLength; j++)
                {
                    fileString += $"\n{filesSorted[j]}";
                }

                if (interludesUsage && i != actsQuantity - 1)
                {
                    fileString += $"\n\n# Cortina {i + 1}";
                    
                    int interludeIndex = interludeUsageSame ? 0 : i;
                    fileString += $"\n{interludesSorted[interludeIndex]}";
                }
            }

            return fileString;
        }

        private void writePlaylistFile(string path, string content)
        {
            File.WriteAllText(path, content, System.Text.Encoding.UTF8);
        }

        private List<Act> sortRandom(List<Act> unsorted)
        {
            List<Act> copy = new List<Act>(unsorted);
            Random random = new Random();
            int n = copy.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Act aux = copy[k];
                copy[k] = copy[n];
                copy[n] = aux;
            }
            return copy;
        }

        private List<string> sortRandom(List<string> unsorted)
        {
            List<string> copy = new List<string>(unsorted);
            Random random = new Random();
            int n = copy.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string aux = copy[k];
                copy[k] = copy[n];
                copy[n] = aux;
            }
            return copy;
        }
    }
}
