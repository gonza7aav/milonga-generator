
namespace serendipia_playlist_generator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtGenreSongQuatity = new System.Windows.Forms.TextBox();
            this.chkMakeInterval = new System.Windows.Forms.CheckBox();
            this.btnSaveConfiguration = new System.Windows.Forms.Button();
            this.chkUseSameInterval = new System.Windows.Forms.CheckBox();
            this.cmbGenres = new System.Windows.Forms.ComboBox();
            this.btnGenreRemove = new System.Windows.Forms.Button();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.lblGenreSongQuatity = new System.Windows.Forms.Label();
            this.lblGenres = new System.Windows.Forms.Label();
            this.btnIntervalsFolder = new System.Windows.Forms.Button();
            this.txtIntervalsFolder = new System.Windows.Forms.TextBox();
            this.lblIntervals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(247, 219);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtGenreSongQuatity
            // 
            this.txtGenreSongQuatity.Location = new System.Drawing.Point(121, 71);
            this.txtGenreSongQuatity.Name = "txtGenreSongQuatity";
            this.txtGenreSongQuatity.Size = new System.Drawing.Size(50, 20);
            this.txtGenreSongQuatity.TabIndex = 4;
            this.txtGenreSongQuatity.Text = "3";
            this.txtGenreSongQuatity.TextChanged += new System.EventHandler(this.txtGenreSongQuatity_TextChanged);
            this.txtGenreSongQuatity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGenreSongQuatity_KeyPress);
            // 
            // chkMakeInterval
            // 
            this.chkMakeInterval.AutoSize = true;
            this.chkMakeInterval.Checked = true;
            this.chkMakeInterval.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMakeInterval.Location = new System.Drawing.Point(12, 171);
            this.chkMakeInterval.Name = "chkMakeInterval";
            this.chkMakeInterval.Size = new System.Drawing.Size(111, 17);
            this.chkMakeInterval.TabIndex = 5;
            this.chkMakeInterval.Text = "Agregar intervalos";
            this.chkMakeInterval.UseVisualStyleBackColor = true;
            this.chkMakeInterval.CheckedChanged += new System.EventHandler(this.chkMakeInterval_CheckedChanged);
            // 
            // btnSaveConfiguration
            // 
            this.btnSaveConfiguration.Location = new System.Drawing.Point(12, 219);
            this.btnSaveConfiguration.Name = "btnSaveConfiguration";
            this.btnSaveConfiguration.Size = new System.Drawing.Size(159, 23);
            this.btnSaveConfiguration.TabIndex = 6;
            this.btnSaveConfiguration.Text = "Guardar Configuración";
            this.btnSaveConfiguration.UseVisualStyleBackColor = true;
            this.btnSaveConfiguration.Click += new System.EventHandler(this.btnSaveConfiguration_Click);
            // 
            // chkUseSameInterval
            // 
            this.chkUseSameInterval.AutoSize = true;
            this.chkUseSameInterval.Location = new System.Drawing.Point(188, 171);
            this.chkUseSameInterval.Name = "chkUseSameInterval";
            this.chkUseSameInterval.Size = new System.Drawing.Size(134, 17);
            this.chkUseSameInterval.TabIndex = 7;
            this.chkUseSameInterval.Text = "Usar el mismo intervalo";
            this.chkUseSameInterval.UseVisualStyleBackColor = true;
            this.chkUseSameInterval.CheckedChanged += new System.EventHandler(this.chkUseSameInterval_CheckedChanged);
            // 
            // cmbGenres
            // 
            this.cmbGenres.FormattingEnabled = true;
            this.cmbGenres.Items.AddRange(new object[] {
            "Agregar nuevo..."});
            this.cmbGenres.Location = new System.Drawing.Point(12, 25);
            this.cmbGenres.Name = "cmbGenres";
            this.cmbGenres.Size = new System.Drawing.Size(229, 21);
            this.cmbGenres.TabIndex = 8;
            this.cmbGenres.SelectedIndexChanged += new System.EventHandler(this.cmbGenres_SelectedIndexChanged);
            // 
            // btnGenreRemove
            // 
            this.btnGenreRemove.Location = new System.Drawing.Point(247, 25);
            this.btnGenreRemove.Name = "btnGenreRemove";
            this.btnGenreRemove.Size = new System.Drawing.Size(75, 23);
            this.btnGenreRemove.TabIndex = 9;
            this.btnGenreRemove.Text = "Borrar";
            this.btnGenreRemove.UseVisualStyleBackColor = true;
            this.btnGenreRemove.Visible = false;
            this.btnGenreRemove.Click += new System.EventHandler(this.btnGenreRemove_Click);
            // 
            // dlgFolder
            // 
            this.dlgFolder.Description = "Agregar nuevo";
            // 
            // lblGenreSongQuatity
            // 
            this.lblGenreSongQuatity.AutoSize = true;
            this.lblGenreSongQuatity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreSongQuatity.Location = new System.Drawing.Point(9, 74);
            this.lblGenreSongQuatity.Name = "lblGenreSongQuatity";
            this.lblGenreSongQuatity.Size = new System.Drawing.Size(106, 13);
            this.lblGenreSongQuatity.TabIndex = 10;
            this.lblGenreSongQuatity.Text = "Cantidad por carpeta";
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenres.Location = new System.Drawing.Point(9, 9);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(49, 13);
            this.lblGenres.TabIndex = 12;
            this.lblGenres.Text = "Carpetas";
            // 
            // btnIntervalsFolder
            // 
            this.btnIntervalsFolder.Location = new System.Drawing.Point(247, 145);
            this.btnIntervalsFolder.Name = "btnIntervalsFolder";
            this.btnIntervalsFolder.Size = new System.Drawing.Size(75, 23);
            this.btnIntervalsFolder.TabIndex = 13;
            this.btnIntervalsFolder.Text = "Buscar";
            this.btnIntervalsFolder.UseVisualStyleBackColor = true;
            this.btnIntervalsFolder.Click += new System.EventHandler(this.btnIntervalsFolder_Click);
            // 
            // txtIntervalsFolder
            // 
            this.txtIntervalsFolder.Enabled = false;
            this.txtIntervalsFolder.Location = new System.Drawing.Point(12, 145);
            this.txtIntervalsFolder.Name = "txtIntervalsFolder";
            this.txtIntervalsFolder.Size = new System.Drawing.Size(229, 20);
            this.txtIntervalsFolder.TabIndex = 14;
            this.txtIntervalsFolder.TextChanged += new System.EventHandler(this.txtIntervalsFolder_TextChanged);
            // 
            // lblIntervals
            // 
            this.lblIntervals.AutoSize = true;
            this.lblIntervals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervals.Location = new System.Drawing.Point(9, 129);
            this.lblIntervals.Name = "lblIntervals";
            this.lblIntervals.Size = new System.Drawing.Size(134, 13);
            this.lblIntervals.TabIndex = 15;
            this.lblIntervals.Text = "Ubicación de los intervalos";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.lblIntervals);
            this.Controls.Add(this.txtIntervalsFolder);
            this.Controls.Add(this.btnIntervalsFolder);
            this.Controls.Add(this.lblGenres);
            this.Controls.Add(this.lblGenreSongQuatity);
            this.Controls.Add(this.btnGenreRemove);
            this.Controls.Add(this.cmbGenres);
            this.Controls.Add(this.chkUseSameInterval);
            this.Controls.Add(this.btnSaveConfiguration);
            this.Controls.Add(this.chkMakeInterval);
            this.Controls.Add(this.txtGenreSongQuatity);
            this.Controls.Add(this.btnGenerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Serendipia Playlist Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtGenreSongQuatity;
        private System.Windows.Forms.CheckBox chkMakeInterval;
        private System.Windows.Forms.Button btnSaveConfiguration;
        private System.Windows.Forms.CheckBox chkUseSameInterval;
        private System.Windows.Forms.ComboBox cmbGenres;
        private System.Windows.Forms.Button btnGenreRemove;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private System.Windows.Forms.Label lblGenreSongQuatity;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.Button btnIntervalsFolder;
        private System.Windows.Forms.TextBox txtIntervalsFolder;
        private System.Windows.Forms.Label lblIntervals;
    }
}

