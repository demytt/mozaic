namespace appli_mozaic
{
    partial class buttonN
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
            this.buttonSelectImage = new System.Windows.Forms.Button();
            this.PictureDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonChoixDossier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGetMozaic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSelectedPath = new System.Windows.Forms.Label();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDossierHauteQualité = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonDossierImagesReduites = new System.Windows.Forms.Button();
            this.labelHauteQualite = new System.Windows.Forms.Label();
            this.labelImagesReduites = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOui = new System.Windows.Forms.Button();
            this.buttonNon = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonAdjustOpacity = new System.Windows.Forms.Button();
            this.labelTrackbar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarN = new System.Windows.Forms.TrackBar();
            this.labelN = new System.Windows.Forms.Label();
            this.buttonAdjustN = new System.Windows.Forms.Button();
            this.labelStep4N = new System.Windows.Forms.Label();
            this.buttonSavePicture = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelectImage
            // 
            this.buttonSelectImage.Location = new System.Drawing.Point(116, 301);
            this.buttonSelectImage.Name = "buttonSelectImage";
            this.buttonSelectImage.Size = new System.Drawing.Size(95, 23);
            this.buttonSelectImage.TabIndex = 0;
            this.buttonSelectImage.Text = "Select";
            this.buttonSelectImage.UseVisualStyleBackColor = true;
            this.buttonSelectImage.Visible = false;
            this.buttonSelectImage.Click += new System.EventHandler(this.buttonSelectImage_Click);
            // 
            // buttonChoixDossier
            // 
            this.buttonChoixDossier.Location = new System.Drawing.Point(200, 193);
            this.buttonChoixDossier.Name = "buttonChoixDossier";
            this.buttonChoixDossier.Size = new System.Drawing.Size(95, 23);
            this.buttonChoixDossier.TabIndex = 6;
            this.buttonChoixDossier.Text = "Select";
            this.buttonChoixDossier.UseVisualStyleBackColor = true;
            this.buttonChoixDossier.Visible = false;
            this.buttonChoixDossier.Click += new System.EventHandler(this.buttonChoixDossier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Step 1 : Where are your photos ?";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Step 2 : Where is the photo you want to decompose ?";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Step 3 : Start algorithm";
            this.label3.Visible = false;
            // 
            // buttonGetMozaic
            // 
            this.buttonGetMozaic.Location = new System.Drawing.Point(206, 348);
            this.buttonGetMozaic.Name = "buttonGetMozaic";
            this.buttonGetMozaic.Size = new System.Drawing.Size(95, 19);
            this.buttonGetMozaic.TabIndex = 10;
            this.buttonGetMozaic.Text = "GO !";
            this.buttonGetMozaic.UseVisualStyleBackColor = true;
            this.buttonGetMozaic.Visible = false;
            this.buttonGetMozaic.Click += new System.EventHandler(this.buttonGetMozaic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(338, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labelSelectedPath
            // 
            this.labelSelectedPath.AutoSize = true;
            this.labelSelectedPath.Location = new System.Drawing.Point(308, 198);
            this.labelSelectedPath.Name = "labelSelectedPath";
            this.labelSelectedPath.Size = new System.Drawing.Size(37, 13);
            this.labelSelectedPath.TabIndex = 12;
            this.labelSelectedPath.Text = "path : ";
            this.labelSelectedPath.Visible = false;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(554, 224);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(224, 152);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResult.TabIndex = 20;
            this.pictureBoxResult.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Step 0 : First we should resize mozaic\'s images for a faster algorithm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Path with high quality photos ?";
            this.label8.Visible = false;
            // 
            // buttonDossierHauteQualité
            // 
            this.buttonDossierHauteQualité.Location = new System.Drawing.Point(279, 90);
            this.buttonDossierHauteQualité.Name = "buttonDossierHauteQualité";
            this.buttonDossierHauteQualité.Size = new System.Drawing.Size(95, 23);
            this.buttonDossierHauteQualité.TabIndex = 23;
            this.buttonDossierHauteQualité.Text = "Select";
            this.buttonDossierHauteQualité.UseVisualStyleBackColor = true;
            this.buttonDossierHauteQualité.Visible = false;
            this.buttonDossierHauteQualité.Click += new System.EventHandler(this.buttonDossierHauteQualité_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Path to save photo with small format ?";
            this.label9.Visible = false;
            // 
            // buttonDossierImagesReduites
            // 
            this.buttonDossierImagesReduites.Location = new System.Drawing.Point(279, 131);
            this.buttonDossierImagesReduites.Name = "buttonDossierImagesReduites";
            this.buttonDossierImagesReduites.Size = new System.Drawing.Size(95, 23);
            this.buttonDossierImagesReduites.TabIndex = 25;
            this.buttonDossierImagesReduites.Text = "Select";
            this.buttonDossierImagesReduites.UseVisualStyleBackColor = true;
            this.buttonDossierImagesReduites.Visible = false;
            this.buttonDossierImagesReduites.Click += new System.EventHandler(this.buttonDossierImagesReduites_Click);
            // 
            // labelHauteQualite
            // 
            this.labelHauteQualite.AutoSize = true;
            this.labelHauteQualite.Location = new System.Drawing.Point(380, 95);
            this.labelHauteQualite.Name = "labelHauteQualite";
            this.labelHauteQualite.Size = new System.Drawing.Size(37, 13);
            this.labelHauteQualite.TabIndex = 26;
            this.labelHauteQualite.Text = "path : ";
            this.labelHauteQualite.Visible = false;
            // 
            // labelImagesReduites
            // 
            this.labelImagesReduites.AutoSize = true;
            this.labelImagesReduites.Location = new System.Drawing.Point(380, 136);
            this.labelImagesReduites.Name = "labelImagesReduites";
            this.labelImagesReduites.Size = new System.Drawing.Size(37, 13);
            this.labelImagesReduites.TabIndex = 27;
            this.labelImagesReduites.Text = "path : ";
            this.labelImagesReduites.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Do you already have a folder with pictures with small size format ?";
            // 
            // buttonOui
            // 
            this.buttonOui.Location = new System.Drawing.Point(401, 50);
            this.buttonOui.Name = "buttonOui";
            this.buttonOui.Size = new System.Drawing.Size(65, 23);
            this.buttonOui.TabIndex = 29;
            this.buttonOui.Text = "yes";
            this.buttonOui.UseVisualStyleBackColor = true;
            this.buttonOui.Click += new System.EventHandler(this.buttonOui_Click);
            // 
            // buttonNon
            // 
            this.buttonNon.Location = new System.Drawing.Point(485, 50);
            this.buttonNon.Name = "buttonNon";
            this.buttonNon.Size = new System.Drawing.Size(65, 23);
            this.buttonNon.TabIndex = 30;
            this.buttonNon.Text = "no";
            this.buttonNon.UseVisualStyleBackColor = true;
            this.buttonNon.Click += new System.EventHandler(this.buttonNon_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(200, 395);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 31;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonAdjustOpacity
            // 
            this.buttonAdjustOpacity.Location = new System.Drawing.Point(339, 392);
            this.buttonAdjustOpacity.Name = "buttonAdjustOpacity";
            this.buttonAdjustOpacity.Size = new System.Drawing.Size(95, 19);
            this.buttonAdjustOpacity.TabIndex = 32;
            this.buttonAdjustOpacity.Text = "GO !";
            this.buttonAdjustOpacity.UseVisualStyleBackColor = true;
            this.buttonAdjustOpacity.Visible = false;
            this.buttonAdjustOpacity.Click += new System.EventHandler(this.buttonAdjustOpacity_Click);
            // 
            // labelTrackbar
            // 
            this.labelTrackbar.AutoSize = true;
            this.labelTrackbar.Location = new System.Drawing.Point(310, 398);
            this.labelTrackbar.Name = "labelTrackbar";
            this.labelTrackbar.Size = new System.Drawing.Size(13, 13);
            this.labelTrackbar.TabIndex = 33;
            this.labelTrackbar.Text = "0";
            this.labelTrackbar.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Step 4 : Adjust transparency";
            this.label5.Visible = false;
            // 
            // trackBarN
            // 
            this.trackBarN.Location = new System.Drawing.Point(203, 446);
            this.trackBarN.Maximum = 50;
            this.trackBarN.Minimum = 1;
            this.trackBarN.Name = "trackBarN";
            this.trackBarN.Size = new System.Drawing.Size(104, 45);
            this.trackBarN.TabIndex = 35;
            this.trackBarN.Value = 1;
            this.trackBarN.Visible = false;
            this.trackBarN.Scroll += new System.EventHandler(this.trackBarN_Scroll);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(310, 446);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(13, 13);
            this.labelN.TabIndex = 36;
            this.labelN.Text = "0";
            this.labelN.Visible = false;
            // 
            // buttonAdjustN
            // 
            this.buttonAdjustN.Location = new System.Drawing.Point(339, 443);
            this.buttonAdjustN.Name = "buttonAdjustN";
            this.buttonAdjustN.Size = new System.Drawing.Size(95, 19);
            this.buttonAdjustN.TabIndex = 37;
            this.buttonAdjustN.Text = "GO !";
            this.buttonAdjustN.UseVisualStyleBackColor = true;
            this.buttonAdjustN.Visible = false;
            this.buttonAdjustN.Click += new System.EventHandler(this.buttonAdjustN_Click);
            // 
            // labelStep4N
            // 
            this.labelStep4N.AutoSize = true;
            this.labelStep4N.Location = new System.Drawing.Point(60, 449);
            this.labelStep4N.Name = "labelStep4N";
            this.labelStep4N.Size = new System.Drawing.Size(81, 13);
            this.labelStep4N.TabIndex = 38;
            this.labelStep4N.Text = "Adjust precision";
            this.labelStep4N.Visible = false;
            // 
            // buttonSavePicture
            // 
            this.buttonSavePicture.Location = new System.Drawing.Point(623, 392);
            this.buttonSavePicture.Name = "buttonSavePicture";
            this.buttonSavePicture.Size = new System.Drawing.Size(94, 25);
            this.buttonSavePicture.TabIndex = 39;
            this.buttonSavePicture.Text = "Save picture";
            this.buttonSavePicture.UseVisualStyleBackColor = true;
            this.buttonSavePicture.Visible = false;
            this.buttonSavePicture.Click += new System.EventHandler(this.buttonSavePicture_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 25);
            this.button1.TabIndex = 40;
            this.button1.Text = "Save picture with high quality";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSavePicture);
            this.Controls.Add(this.labelStep4N);
            this.Controls.Add(this.buttonAdjustN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.trackBarN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTrackbar);
            this.Controls.Add(this.buttonAdjustOpacity);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonNon);
            this.Controls.Add(this.buttonOui);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelImagesReduites);
            this.Controls.Add(this.labelHauteQualite);
            this.Controls.Add(this.buttonDossierImagesReduites);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonDossierHauteQualité);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.labelSelectedPath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGetMozaic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChoixDossier);
            this.Controls.Add(this.buttonSelectImage);
            this.Name = "buttonN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectImage;
        private System.Windows.Forms.FolderBrowserDialog PictureDialog;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button buttonChoixDossier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGetMozaic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSelectedPath;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDossierHauteQualité;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonDossierImagesReduites;
        private System.Windows.Forms.Label labelHauteQualite;
        private System.Windows.Forms.Label labelImagesReduites;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOui;
        private System.Windows.Forms.Button buttonNon;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonAdjustOpacity;
        private System.Windows.Forms.Label labelTrackbar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarN;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Button buttonAdjustN;
        private System.Windows.Forms.Label labelStep4N;
        private System.Windows.Forms.Button buttonSavePicture;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

