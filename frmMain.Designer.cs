
namespace milonga_generator
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
            this.components = new System.ComponentModel.Container();
            this.dlgActs = new System.Windows.Forms.FolderBrowserDialog();
            this.cmbActsAdded = new System.Windows.Forms.ComboBox();
            this.lblActsQuantity = new System.Windows.Forms.Label();
            this.txtActsQuantity = new System.Windows.Forms.TextBox();
            this.lblActsLength = new System.Windows.Forms.Label();
            this.txtActsLength = new System.Windows.Forms.TextBox();
            this.btnActsAdd = new System.Windows.Forms.Button();
            this.btnActsDelete = new System.Windows.Forms.Button();
            this.chkInterludesUsage = new System.Windows.Forms.CheckBox();
            this.txtInterludesPath = new System.Windows.Forms.TextBox();
            this.btnInterludesPathSearch = new System.Windows.Forms.Button();
            this.grpActs = new System.Windows.Forms.GroupBox();
            this.lblActsAddedTotal = new System.Windows.Forms.Label();
            this.grpInterludes = new System.Windows.Forms.GroupBox();
            this.chkInterludesUsageSame = new System.Windows.Forms.CheckBox();
            this.dlgInterludes = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGeneratePlaylist = new System.Windows.Forms.Button();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.btnReadSettings = new System.Windows.Forms.Button();
            this.btnWriteSettings = new System.Windows.Forms.Button();
            this.dlgWriteSettings = new System.Windows.Forms.SaveFileDialog();
            this.dlgReadSettings = new System.Windows.Forms.OpenFileDialog();
            this.btnHelp = new System.Windows.Forms.Button();
            this.dlgPlaylist = new System.Windows.Forms.SaveFileDialog();
            this.tipInterludePath = new System.Windows.Forms.ToolTip(this.components);
            this.grpActs.SuspendLayout();
            this.grpInterludes.SuspendLayout();
            this.grpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgActs
            // 
            this.dlgActs.Description = "Agregar la carpeta de una tanda";
            this.dlgActs.ShowNewFolderButton = false;
            // 
            // cmbActsAdded
            // 
            this.cmbActsAdded.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActsAdded.Enabled = false;
            this.cmbActsAdded.Location = new System.Drawing.Point(10, 29);
            this.cmbActsAdded.Margin = new System.Windows.Forms.Padding(5);
            this.cmbActsAdded.Name = "cmbActsAdded";
            this.cmbActsAdded.Size = new System.Drawing.Size(292, 26);
            this.cmbActsAdded.TabIndex = 3;
            // 
            // lblActsQuantity
            // 
            this.lblActsQuantity.AutoSize = true;
            this.lblActsQuantity.Location = new System.Drawing.Point(10, 103);
            this.lblActsQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.lblActsQuantity.Name = "lblActsQuantity";
            this.lblActsQuantity.Size = new System.Drawing.Size(214, 18);
            this.lblActsQuantity.TabIndex = 1;
            this.lblActsQuantity.Text = "Número de tandas por playlist";
            // 
            // txtActsQuantity
            // 
            this.txtActsQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActsQuantity.Location = new System.Drawing.Point(242, 101);
            this.txtActsQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.txtActsQuantity.Name = "txtActsQuantity";
            this.txtActsQuantity.Size = new System.Drawing.Size(60, 26);
            this.txtActsQuantity.TabIndex = 4;
            this.txtActsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtActsQuantity.TextChanged += new System.EventHandler(this.txtActsQuantity_TextChanged);
            // 
            // lblActsLength
            // 
            this.lblActsLength.AutoSize = true;
            this.lblActsLength.Location = new System.Drawing.Point(10, 140);
            this.lblActsLength.Margin = new System.Windows.Forms.Padding(5);
            this.lblActsLength.Name = "lblActsLength";
            this.lblActsLength.Size = new System.Drawing.Size(214, 18);
            this.lblActsLength.TabIndex = 1;
            this.lblActsLength.Text = "Cantidad de piezas por tanda";
            // 
            // txtActsLength
            // 
            this.txtActsLength.Location = new System.Drawing.Point(242, 137);
            this.txtActsLength.Margin = new System.Windows.Forms.Padding(5);
            this.txtActsLength.Name = "txtActsLength";
            this.txtActsLength.Size = new System.Drawing.Size(60, 26);
            this.txtActsLength.TabIndex = 5;
            this.txtActsLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtActsLength.TextChanged += new System.EventHandler(this.txtActsLength_TextChanged);
            // 
            // btnActsAdd
            // 
            this.btnActsAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActsAdd.Location = new System.Drawing.Point(242, 65);
            this.btnActsAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnActsAdd.Name = "btnActsAdd";
            this.btnActsAdd.Size = new System.Drawing.Size(60, 26);
            this.btnActsAdd.TabIndex = 1;
            this.btnActsAdd.Text = "Añadir";
            this.btnActsAdd.UseVisualStyleBackColor = true;
            this.btnActsAdd.Click += new System.EventHandler(this.btnActsAdd_Click);
            // 
            // btnActsDelete
            // 
            this.btnActsDelete.Enabled = false;
            this.btnActsDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActsDelete.Location = new System.Drawing.Point(172, 65);
            this.btnActsDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnActsDelete.Name = "btnActsDelete";
            this.btnActsDelete.Size = new System.Drawing.Size(60, 26);
            this.btnActsDelete.TabIndex = 2;
            this.btnActsDelete.Text = "Quitar";
            this.btnActsDelete.UseVisualStyleBackColor = true;
            this.btnActsDelete.Click += new System.EventHandler(this.btnActsDelete_Click);
            // 
            // chkInterludesUsage
            // 
            this.chkInterludesUsage.AutoSize = true;
            this.chkInterludesUsage.Checked = true;
            this.chkInterludesUsage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInterludesUsage.Location = new System.Drawing.Point(10, 29);
            this.chkInterludesUsage.Margin = new System.Windows.Forms.Padding(5);
            this.chkInterludesUsage.Name = "chkInterludesUsage";
            this.chkInterludesUsage.Size = new System.Drawing.Size(133, 22);
            this.chkInterludesUsage.TabIndex = 6;
            this.chkInterludesUsage.Text = "Utilizar cortinas";
            this.chkInterludesUsage.UseVisualStyleBackColor = true;
            this.chkInterludesUsage.CheckedChanged += new System.EventHandler(this.chkInterludesUsage_CheckedChanged);
            // 
            // txtInterludesPath
            // 
            this.txtInterludesPath.Enabled = false;
            this.txtInterludesPath.Location = new System.Drawing.Point(11, 88);
            this.txtInterludesPath.Margin = new System.Windows.Forms.Padding(5);
            this.txtInterludesPath.Name = "txtInterludesPath";
            this.txtInterludesPath.Size = new System.Drawing.Size(222, 26);
            this.txtInterludesPath.TabIndex = 1;
            this.txtInterludesPath.TabStop = false;
            this.txtInterludesPath.Text = "Ubicación de las cortinas...";
            // 
            // btnInterludesPathSearch
            // 
            this.btnInterludesPathSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterludesPathSearch.Location = new System.Drawing.Point(243, 88);
            this.btnInterludesPathSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnInterludesPathSearch.Name = "btnInterludesPathSearch";
            this.btnInterludesPathSearch.Size = new System.Drawing.Size(60, 26);
            this.btnInterludesPathSearch.TabIndex = 8;
            this.btnInterludesPathSearch.Text = "Buscar";
            this.btnInterludesPathSearch.UseVisualStyleBackColor = true;
            this.btnInterludesPathSearch.Click += new System.EventHandler(this.btnInterludesPathSearch_Click);
            // 
            // grpActs
            // 
            this.grpActs.Controls.Add(this.lblActsAddedTotal);
            this.grpActs.Controls.Add(this.cmbActsAdded);
            this.grpActs.Controls.Add(this.btnActsDelete);
            this.grpActs.Controls.Add(this.btnActsAdd);
            this.grpActs.Controls.Add(this.txtActsLength);
            this.grpActs.Controls.Add(this.lblActsQuantity);
            this.grpActs.Controls.Add(this.lblActsLength);
            this.grpActs.Controls.Add(this.txtActsQuantity);
            this.grpActs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActs.Location = new System.Drawing.Point(10, 10);
            this.grpActs.Margin = new System.Windows.Forms.Padding(5);
            this.grpActs.Name = "grpActs";
            this.grpActs.Padding = new System.Windows.Forms.Padding(5);
            this.grpActs.Size = new System.Drawing.Size(312, 173);
            this.grpActs.TabIndex = 0;
            this.grpActs.TabStop = false;
            this.grpActs.Text = "Tandas";
            // 
            // lblActsAddedTotal
            // 
            this.lblActsAddedTotal.AutoSize = true;
            this.lblActsAddedTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActsAddedTotal.Location = new System.Drawing.Point(10, 70);
            this.lblActsAddedTotal.Margin = new System.Windows.Forms.Padding(5);
            this.lblActsAddedTotal.Name = "lblActsAddedTotal";
            this.lblActsAddedTotal.Size = new System.Drawing.Size(50, 16);
            this.lblActsAddedTotal.TabIndex = 1;
            this.lblActsAddedTotal.Text = "Total: 0";
            // 
            // grpInterludes
            // 
            this.grpInterludes.Controls.Add(this.txtInterludesPath);
            this.grpInterludes.Controls.Add(this.chkInterludesUsageSame);
            this.grpInterludes.Controls.Add(this.chkInterludesUsage);
            this.grpInterludes.Controls.Add(this.btnInterludesPathSearch);
            this.grpInterludes.Location = new System.Drawing.Point(10, 193);
            this.grpInterludes.Margin = new System.Windows.Forms.Padding(5);
            this.grpInterludes.Name = "grpInterludes";
            this.grpInterludes.Padding = new System.Windows.Forms.Padding(5);
            this.grpInterludes.Size = new System.Drawing.Size(314, 133);
            this.grpInterludes.TabIndex = 1;
            this.grpInterludes.TabStop = false;
            this.grpInterludes.Text = "Cortinas";
            // 
            // chkInterludesUsageSame
            // 
            this.chkInterludesUsageSame.AutoSize = true;
            this.chkInterludesUsageSame.Checked = true;
            this.chkInterludesUsageSame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInterludesUsageSame.Location = new System.Drawing.Point(10, 56);
            this.chkInterludesUsageSame.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.chkInterludesUsageSame.Name = "chkInterludesUsageSame";
            this.chkInterludesUsageSame.Size = new System.Drawing.Size(239, 22);
            this.chkInterludesUsageSame.TabIndex = 7;
            this.chkInterludesUsageSame.Text = "Usar siempre la misma cortina";
            this.chkInterludesUsageSame.UseVisualStyleBackColor = true;
            this.chkInterludesUsageSame.CheckedChanged += new System.EventHandler(this.chkInterludesUsageSame_CheckedChanged);
            // 
            // dlgInterludes
            // 
            this.dlgInterludes.Description = "Agregar la carpeta de cortinas";
            this.dlgInterludes.ShowNewFolderButton = false;
            // 
            // btnGeneratePlaylist
            // 
            this.btnGeneratePlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeneratePlaylist.Enabled = false;
            this.btnGeneratePlaylist.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePlaylist.Location = new System.Drawing.Point(154, 416);
            this.btnGeneratePlaylist.Margin = new System.Windows.Forms.Padding(0, 5, 25, 0);
            this.btnGeneratePlaylist.Name = "btnGeneratePlaylist";
            this.btnGeneratePlaylist.Size = new System.Drawing.Size(150, 25);
            this.btnGeneratePlaylist.TabIndex = 13;
            this.btnGeneratePlaylist.Text = "Generar Playlist";
            this.btnGeneratePlaylist.UseVisualStyleBackColor = true;
            this.btnGeneratePlaylist.Click += new System.EventHandler(this.btnGeneratePlaylist_Click);
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.btnReadSettings);
            this.grpSettings.Controls.Add(this.btnWriteSettings);
            this.grpSettings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSettings.Location = new System.Drawing.Point(10, 336);
            this.grpSettings.Margin = new System.Windows.Forms.Padding(5);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Padding = new System.Windows.Forms.Padding(5);
            this.grpSettings.Size = new System.Drawing.Size(314, 70);
            this.grpSettings.TabIndex = 2;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Configuración";
            // 
            // btnReadSettings
            // 
            this.btnReadSettings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadSettings.Location = new System.Drawing.Point(184, 29);
            this.btnReadSettings.Margin = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.btnReadSettings.Name = "btnReadSettings";
            this.btnReadSettings.Size = new System.Drawing.Size(100, 26);
            this.btnReadSettings.TabIndex = 10;
            this.btnReadSettings.Text = "Cargar";
            this.btnReadSettings.UseVisualStyleBackColor = true;
            this.btnReadSettings.Click += new System.EventHandler(this.btnReadSettings_Click);
            // 
            // btnWriteSettings
            // 
            this.btnWriteSettings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteSettings.Location = new System.Drawing.Point(30, 29);
            this.btnWriteSettings.Margin = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.btnWriteSettings.Name = "btnWriteSettings";
            this.btnWriteSettings.Size = new System.Drawing.Size(100, 26);
            this.btnWriteSettings.TabIndex = 9;
            this.btnWriteSettings.Text = "Guardar";
            this.btnWriteSettings.UseVisualStyleBackColor = true;
            this.btnWriteSettings.Click += new System.EventHandler(this.btnWriteSettings_Click);
            // 
            // dlgWriteSettings
            // 
            this.dlgWriteSettings.DefaultExt = "config";
            this.dlgWriteSettings.FileName = "milonga-generator";
            this.dlgWriteSettings.Title = "Guardar archivo de configuración";
            // 
            // dlgReadSettings
            // 
            this.dlgReadSettings.DefaultExt = "config";
            this.dlgReadSettings.Title = "Cargar archivo de configuración";
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(30, 416);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(25, 5, 0, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 25);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "Ayuda";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // dlgPlaylist
            // 
            this.dlgPlaylist.DefaultExt = "m3u";
            this.dlgPlaylist.FileName = "playlist";
            this.dlgPlaylist.Title = "Guardar playlist generada";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 451);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnGeneratePlaylist);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.grpInterludes);
            this.Controls.Add(this.grpActs);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Milonga Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpActs.ResumeLayout(false);
            this.grpActs.PerformLayout();
            this.grpInterludes.ResumeLayout(false);
            this.grpInterludes.PerformLayout();
            this.grpSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog dlgActs;
        private System.Windows.Forms.ComboBox cmbActsAdded;
        private System.Windows.Forms.Button btnActsDelete;
        private System.Windows.Forms.Button btnActsAdd;
        private System.Windows.Forms.Label lblActsQuantity;
        private System.Windows.Forms.TextBox txtActsQuantity;
        private System.Windows.Forms.Label lblActsLength;
        private System.Windows.Forms.TextBox txtActsLength;
        private System.Windows.Forms.Button btnInterludesPathSearch;
        private System.Windows.Forms.TextBox txtInterludesPath;
        private System.Windows.Forms.CheckBox chkInterludesUsage;
        private System.Windows.Forms.GroupBox grpActs;
        private System.Windows.Forms.GroupBox grpInterludes;
        private System.Windows.Forms.FolderBrowserDialog dlgInterludes;
        private System.Windows.Forms.CheckBox chkInterludesUsageSame;
        private System.Windows.Forms.Button btnGeneratePlaylist;
        private System.Windows.Forms.Label lblActsAddedTotal;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Button btnWriteSettings;
        private System.Windows.Forms.Button btnReadSettings;
        private System.Windows.Forms.SaveFileDialog dlgWriteSettings;
        private System.Windows.Forms.OpenFileDialog dlgReadSettings;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.SaveFileDialog dlgPlaylist;
        private System.Windows.Forms.ToolTip tipInterludePath;
    }
}

