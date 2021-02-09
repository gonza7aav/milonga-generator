using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace serendipia_playlist_generator
{
    public partial class frmMain : Form
    {
        List<Genre> genres;
        int genreSongQuantity;
        bool makeIntervals;
        bool useSameInterval;
        string intervalsFolder;

        public frmMain()
        {
            InitializeComponent();
            genres = new List<Genre>();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Load config
            try
            {
                genreSongQuantity = Properties.Settings.Default.genreSongQuantity;
                txtGenreSongQuatity.Text = genreSongQuantity.ToString();
            }
            catch
            {
                Console.WriteLine("genreSongQuantity configuration not found.");
            }

            try
            {
                makeIntervals = Properties.Settings.Default.makeIntervals;
                chkMakeInterval.Checked = makeIntervals;
            }
            catch
            {
                Console.WriteLine("makeIntervals configuration not found.");
            }

            try
            {
                useSameInterval = Properties.Settings.Default.useSameInterval;
                chkUseSameInterval.Checked = useSameInterval;
            }
            catch
            {
                Console.WriteLine("useSameInterval configuration not found.");
            }

            try
            {
                intervalsFolder = Properties.Settings.Default.intervalsFolder;
                txtIntervalsFolder.Text = intervalsFolder;
            }
            catch
            {
                Console.WriteLine("intervalsFolder configuration not found.");
            }

            // Load genres
            try
            {
                if (Properties.Settings.Default.genres != null)
                {
                    foreach (string genrePath in Properties.Settings.Default.genres)
                    {
                        genres.Add(new Genre(genrePath));
                    }
                    updateGenresComboBox();
                }
            }
            catch
            {
                Console.WriteLine("genres configuration not found.");
            }
        }

        private void btnSaveConfiguration_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show(
                   "¿Desea guardar la configuración?",
                   "Confirmación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2);

            if (confirmation == DialogResult.Yes)
            {
                Properties.Settings.Default.genreSongQuantity = genreSongQuantity;
                Properties.Settings.Default.makeIntervals = makeIntervals;
                Properties.Settings.Default.useSameInterval = useSameInterval;
                Properties.Settings.Default.intervalsFolder = intervalsFolder;

                ArrayList aux = new ArrayList();
                foreach (Genre g in genres)
                {
                    aux.Add(g.path);
                }
                Properties.Settings.Default.genres = aux;

                Properties.Settings.Default.Save();
                Console.WriteLine("genres configuration saved.");
            }
        }

        private void txtGenreSongQuatity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGenreSongQuatity.Text))
            {
                genreSongQuantity = int.Parse(txtGenreSongQuatity.Text);
            }
        }

        private void chkMakeInterval_CheckedChanged(object sender, EventArgs e)
        {
            makeIntervals = chkMakeInterval.Checked;
            btnIntervalsFolder.Enabled = chkMakeInterval.Checked;
            chkUseSameInterval.Enabled = chkMakeInterval.Checked;
        }

        private void chkUseSameInterval_CheckedChanged(object sender, EventArgs e)
        {
            useSameInterval = chkUseSameInterval.Checked;
        }

        private void txtIntervalsFolder_TextChanged(object sender, EventArgs e)
        {
            intervalsFolder = txtIntervalsFolder.Text;
        }

        private void cmbGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add new one
            if (cmbGenres.SelectedItem.ToString() == "Agregar nuevo...")
            {
                btnGenreRemove.Visible = false;

                DialogResult result = dlgFolder.ShowDialog();
                if (result == DialogResult.OK)
                {
                    genres.Add(new Genre(dlgFolder.SelectedPath));
                    updateGenresComboBox();
                }
            }
            else
            {
                btnGenreRemove.Visible = true;
            }
        }

        private void btnGenreRemove_Click(object sender, EventArgs e)
        {
            int index = genres.FindIndex(x => x.name == cmbGenres.SelectedItem.ToString());
            genres.RemoveAt(index);
            updateGenresComboBox();
        }

        private void btnIntervalsFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                intervalsFolder = dlgFolder.SelectedPath;
                txtIntervalsFolder.Text = intervalsFolder;
            }
        }

        private void txtGenreSongQuatity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                return;
            }

            DialogResult result = dlgFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = dlgFolder.SelectedPath;
                string content = "";

                if (Directory.GetFiles(intervalsFolder).Length < genres.Count - 1)
                {
                    DialogResult confirmation = MessageBox.Show(
                        "La carpeta seleccionada de intervalos no posee la cantidad de canciones necesarias.\n¿Desea que se repitan?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2);
                    if (confirmation != DialogResult.Yes)
                    {
                        return;
                    }
                }

                List<string> intervalsSorted = getFilesSorted(intervalsFolder);
                List<Genre> genresSorted = getGenreSorted();
                string aux;

                foreach (Genre g in genresSorted)
                {
                    List<string> filesSorted = getFilesSorted(g.path);

                    content += (!string.IsNullOrWhiteSpace(content) ? "\n\n" : "") + "# Genre " + g.name;
                    Console.WriteLine("# Genre " + g.name);

                    for (int i = 0; i < genreSongQuantity; i++)
                    {
                        if (filesSorted.Count == 0)
                        {
                            filesSorted = getFilesSorted(g.path);
                        }

                        aux = filesSorted.ElementAt(0);
                        content += "\n" + aux;
                        Console.WriteLine(aux);
                        filesSorted.RemoveAt(0);
                    }

                    if (makeIntervals && g != genresSorted.Last())
                    {
                        if (intervalsSorted.Count == 0)
                        {
                            intervalsSorted = getFilesSorted(intervalsFolder);
                        }

                        aux = intervalsSorted.ElementAt(0);
                        content += "\n\n# Interval\n" + aux;
                        Console.WriteLine(aux);
                        if (!useSameInterval)
                        {
                            intervalsSorted.RemoveAt(0);
                        }
                    }
                }

                saveFile(path, content);
            }

        }

        private void updateGenresComboBox()
        {
            cmbGenres.Items.Clear();
            cmbGenres.Items.Add("Agregar nuevo...");
            foreach (Genre g in genres)
            {
                cmbGenres.Items.Add(g.name);
            }
            cmbGenres.Text = "";

            Console.WriteLine("Genres update: " + genres.Count());
        }

        private bool validate()
        {
            bool canGenerate = true;

            canGenerate &= genres.Count >= 2;
            canGenerate &= genreSongQuantity >= 1;
            canGenerate &= !makeIntervals || !string.IsNullOrEmpty(txtIntervalsFolder.Text);

            Console.WriteLine("validate: " + canGenerate.ToString());
            return canGenerate;
        }

        private void saveFile(string _where, string _content)
        {
            string playlistName = "Playlist_" + DateTime.Now.Year.ToString() + "_"
                + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + "_"
                + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_"
                + DateTime.Now.Second.ToString() + ".m3u";
            string path = _where + "/" + playlistName;

            File.WriteAllText(path, _content);
        }

        private List<string> getFilesSorted(string _path)
        {
            string[] files = Directory.GetFiles(_path);
            List<string> list = new List<string>(files);
            var random = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string aux = list[k];
                list[k] = list[n];
                list[n] = aux;
            }
            return list;
        }

        private List<Genre> getGenreSorted()
        {
            List<Genre> list = new List<Genre>(genres);
            var random = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Genre aux = list[k];
                list[k] = list[n];
                list[n] = aux;
            }
            return list;
        }
    }
}