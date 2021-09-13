using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace milonga_generator
{
    public partial class frmMain : Form
    {
        Playlist playlist;

        bool isTipInterludePathShowing;

        public frmMain()
        {
            InitializeComponent();

            playlist = new Playlist();

            isTipInterludePathShowing = false;

            // add the mouse move event for the group where is txtInterludesPath (disable)
            grpInterludes.MouseMove += new MouseEventHandler(this.grpInterludes_MouseMove);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMain_Update();
        }

        private void frmMain_Update()
        {
            // put the values of playlist in the form's component
            grpActs_Update();

            txtActsQuantity.Text = playlist.actsQuantity != -1 ? playlist.actsQuantity.ToString() : "";

            txtActsLength.Text = playlist.actsLength != -1 ? playlist.actsLength.ToString() : "";

            chkInterludesUsage.Checked = playlist.interludesUsage;

            txtInterludesPath.Text = playlist.interludesPath != "" ? playlist.interludesPath : "Ubicación de las cortinas...";

            chkInterludesUsageSame.Checked = playlist.interludeUsageSame;

            btnGeneratePlaylist_Update();
        }
        
        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.helpURL);
        }

        // grpActs

        private void btnActsAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgActs.ShowDialog();
            if (result == DialogResult.OK)
            {
                playlist.acts.Add(new Act(dlgActs.SelectedPath));
                grpActs_Update();
            }
        }

        private void btnActsDelete_Click(object sender, EventArgs e)
        {
            int indexToDelete = cmbActsAdded.SelectedIndex;

            // if there is something selected
            if (indexToDelete != -1)
            {
                playlist.acts.RemoveAt(indexToDelete);
                grpActs_Update();
            }
        }

        private void grpActs_Update()
        {
            bool cmbActsAddedIsEmpty = playlist.acts.Count == 0;

            cmbActsAdded.Enabled = !cmbActsAddedIsEmpty;
            btnActsDelete.Enabled = !cmbActsAddedIsEmpty;

            cmbActsAdded.Items.Clear();
            if (!cmbActsAddedIsEmpty)
            {
                foreach (Act x in playlist.acts)
                {
                    cmbActsAdded.Items.Add(x.name);
                }
            }

            cmbActsAdded.SelectedIndex = cmbActsAddedIsEmpty ? -1 : 0;
            lblActsAddedTotal.Text = $"Total: {playlist.acts.Count}";

            btnGeneratePlaylist_Update();
        }

        private void txtActsQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                playlist.actsQuantity = Int32.Parse(txtActsQuantity.Text);
                txtActsQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
            }
            catch (Exception err)
            {
                txtActsQuantity.ForeColor = System.Drawing.Color.Red;
                playlist.actsQuantity = -1;
            }

            btnGeneratePlaylist_Update();
        }

        private void txtActsLength_TextChanged(object sender, EventArgs e)
        {
            try
            {
                playlist.actsLength = Int32.Parse(txtActsLength.Text);
                txtActsLength.ForeColor = System.Drawing.SystemColors.WindowText;
            }
            catch (Exception err)
            {
                txtActsLength.ForeColor = System.Drawing.Color.Red;
                playlist.actsLength = -1;
            }

            btnGeneratePlaylist_Update();
        }

        // grpInterludes

        private void chkInterludesUsage_CheckedChanged(object sender, EventArgs e)
        {
            playlist.interludesUsage = chkInterludesUsage.Checked;
            
            btnInterludesPathSearch.Enabled = playlist.interludesUsage;
            chkInterludesUsageSame.Enabled = playlist.interludesUsage;

            btnGeneratePlaylist_Update();
        }

        private void chkInterludesUsageSame_CheckedChanged(object sender, EventArgs e)
        {
            playlist.interludeUsageSame = chkInterludesUsageSame.Checked;
        }

        private void btnInterludesPathSearch_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgInterludes.ShowDialog();
            if (result == DialogResult.OK)
            {
                playlist.interludesPath = dlgInterludes.SelectedPath;
                txtInterludesPath.Text = playlist.interludesPath;
            }

            btnGeneratePlaylist_Update();
        }

        private void grpInterludes_MouseMove(object sender, MouseEventArgs e)
        {
            if (playlist.interludesPath != "" && grpInterludes.GetChildAtPoint(e.Location) == txtInterludesPath)
            {
                if (!isTipInterludePathShowing)
                {
                    tipInterludePath.Show(txtInterludesPath.Text, grpInterludes, e.Location);
                    isTipInterludePathShowing = true;
                }
            }
            else
            {
                tipInterludePath.Hide(grpInterludes);
                isTipInterludePathShowing = false;
            }
        }

        // grpSettings

        private void btnWriteSettings_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgWriteSettings.ShowDialog();
            if (result == DialogResult.OK)
            {
                playlist.writeSettingsFile(dlgWriteSettings.FileName);
            }
        }

        private void btnReadSettings_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgReadSettings.ShowDialog();
            if (result == DialogResult.OK)
            {
                playlist.readSettingsFile(dlgReadSettings.FileName);

                // update the form
                frmMain_Update();
            }
        }

        private void btnGeneratePlaylist_Update()
        {
            btnGeneratePlaylist.Enabled = playlist.validate();
        }

        private void btnGeneratePlaylist_Click(object sender, EventArgs e)
        {
            List<string> errors = playlist.getErrorMessages();

            // if there is no element in errors, then everything is OK
            if (errors.Count == 0)
            {
                dlgPlaylist.FileName = createDefaultFileName("playlist");

                DialogResult result = dlgPlaylist.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try
                    {
                        playlist.generate(dlgPlaylist.FileName);

                        MessageBox.Show(
                            "Se ha creado la playlist de manera exitosa",
                            "Milonga Generator",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(
                            err.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                showErrorMessages(errors);
            }
        }

        private void showErrorMessages(List<string> errors)
        {
            string messageBody = errors.Count == 1 ?
                    "Se ha encontrado el siguiente error al previzualizar la playlist:" :
                    "Se han encontrado los siguientes errores al previzualizar la playlist:";

            foreach (string msg in errors)
            {
                messageBody += $"\n- {msg}";
            }

            MessageBox.Show(
                messageBody,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private string createDefaultFileName(string header)
        {
            // make the file's name contain when it was created
            
            DateTime now = DateTime.Now;
            
            string filename = $"{header}_{now.Year}_{now.Month}_{now.Day}";
            filename += $"_{now.Hour}_{now.Minute}_{now.Second}";

            return filename;
        }
    }
}
