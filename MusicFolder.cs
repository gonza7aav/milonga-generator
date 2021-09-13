using System.Collections.Generic;
using System.IO;

namespace milonga_generator
{
    public static class MusicFolder
    {
        // fix extensioin
        // the supported extension to filter the files
        public static List<string> fileExtensions = new List<string>()
            { ".mp3" };

        public static string getLastFolderName(string _path)
        {
            return new DirectoryInfo(_path).Name;
        }

        public static List<string> getMusicFiles(string _path)
        {
            string[] filesUnfiltered = Directory.GetFiles(_path);
            List<string> filesFiltered = new List<string>();

            foreach (string file in filesUnfiltered)
            {
                string extension = file.Substring(file.LastIndexOf('.'));

                if (fileExtensions.Contains(extension))
                {
                    filesFiltered.Add(file);
                }
            }

            return filesFiltered;
        }
    }
}
