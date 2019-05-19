namespace VoiceTalking
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.SpeechButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.VolumeUpDown = new System.Windows.Forms.NumericUpDown();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.RateLabel = new System.Windows.Forms.Label();
            this.RateUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpeechDialog = new System.Windows.Forms.RichTextBox();
            this.GenderVoice = new System.Windows.Forms.DomainUpDown();
            this.LanguageVoice = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SpeechButton
            // 
            this.SpeechButton.Location = new System.Drawing.Point(12, 166);
            this.SpeechButton.Name = "SpeechButton";
            this.SpeechButton.Size = new System.Drawing.Size(162, 23);
            this.SpeechButton.TabIndex = 3;
            this.SpeechButton.Text = "Speech";
            this.SpeechButton.UseVisualStyleBackColor = true;
            this.SpeechButton.Click += new System.EventHandler(this.SpeechButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(183, 166);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(162, 23);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "Export...";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // VolumeUpDown
            // 
            this.VolumeUpDown.Location = new System.Drawing.Point(62, 140);
            this.VolumeUpDown.Name = "VolumeUpDown";
            this.VolumeUpDown.Size = new System.Drawing.Size(112, 20);
            this.VolumeUpDown.TabIndex = 5;
            this.VolumeUpDown.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(12, 142);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(45, 13);
            this.VolumeLabel.TabIndex = 6;
            this.VolumeLabel.Text = "Volume:";
            this.VolumeLabel.Click += new System.EventHandler(this.VolumeLabel_Click);
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(187, 142);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(41, 13);
            this.RateLabel.TabIndex = 8;
            this.RateLabel.Text = "Speed:";
            this.RateLabel.Click += new System.EventHandler(this.RateLabel_Click);
            // 
            // RateUpDown
            // 
            this.RateUpDown.Location = new System.Drawing.Point(234, 140);
            this.RateUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RateUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.RateUpDown.Name = "RateUpDown";
            this.RateUpDown.Size = new System.Drawing.Size(112, 20);
            this.RateUpDown.TabIndex = 7;
            this.RateUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SpeechDialog
            // 
            this.SpeechDialog.Location = new System.Drawing.Point(13, 12);
            this.SpeechDialog.Name = "SpeechDialog";
            this.SpeechDialog.Size = new System.Drawing.Size(332, 96);
            this.SpeechDialog.TabIndex = 11;
            this.SpeechDialog.Text = "";
            // 
            // GenderVoice
            // 
            this.GenderVoice.Items.Add("Male");
            this.GenderVoice.Items.Add("Female");
            this.GenderVoice.Location = new System.Drawing.Point(12, 114);
            this.GenderVoice.Name = "GenderVoice";
            this.GenderVoice.Size = new System.Drawing.Size(160, 20);
            this.GenderVoice.TabIndex = 12;
            this.GenderVoice.Text = "Gender";
            // 
            // LanguageVoice
            // 
            this.LanguageVoice.Items.Add("French");
            this.LanguageVoice.Items.Add("English");
            this.LanguageVoice.Items.Add("Japanese");
            this.LanguageVoice.Location = new System.Drawing.Point(184, 114);
            this.LanguageVoice.Name = "LanguageVoice";
            this.LanguageVoice.Size = new System.Drawing.Size(160, 20);
            this.LanguageVoice.TabIndex = 13;
            this.LanguageVoice.Text = "Language";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 199);
            this.Controls.Add(this.LanguageVoice);
            this.Controls.Add(this.GenderVoice);
            this.Controls.Add(this.SpeechDialog);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.RateUpDown);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.VolumeUpDown);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.SpeechButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Text to Speech";
            ((System.ComponentModel.ISupportInitialize)(this.VolumeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SpeechButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.NumericUpDown VolumeUpDown;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.NumericUpDown RateUpDown;
        private System.Windows.Forms.RichTextBox SpeechDialog;
        private System.Windows.Forms.DomainUpDown GenderVoice;
        private System.Windows.Forms.DomainUpDown LanguageVoice;
    }
}

