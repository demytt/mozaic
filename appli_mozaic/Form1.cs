using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace appli_mozaic
{
    public partial class buttonN : Form
    {
        float brightnessValue = 360;
        float hueValue = 1;
        float saturationValue = 360;
        int c = 0;
        Bitmap img;
        Bitmap mozaicImg;
        Bitmap resultat;

        int N = 25; 

        string fileImage = "";
        string dossierImages = "";
        string dossierImagesHauteQualite = "";
        string fileToSave = "";

        List<string> listImages = new List<string>();
        List<Color> listColor = new List<Color>();

        public buttonN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dial = new OpenFileDialog();
            dial.ShowDialog();
            fileImage = dial.FileName;

            pictureBox1.Image = new Bitmap(fileImage);
            pictureBox1.Update();

            label3.Show();
            buttonGetMozaic.Show();
        }

        private void buttonChoixDossier_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            dossierImages = folderDialog.SelectedPath;

            labelSelectedPath.Text = "path : " + dossierImages;

            label2.Show();
            buttonSelectImage.Show();
        }

        private void buttonDossierHauteQualité_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            dossierImagesHauteQualite = folderDialog.SelectedPath;
            labelHauteQualite.Text = "path : " + dossierImagesHauteQualite;
            label9.Show();
            buttonDossierImagesReduites.Show();
            labelImagesReduites.Show();

        }

        private void buttonDossierImagesReduites_Click(object sender, EventArgs e)
        {
            if (dossierImagesHauteQualite == "")
                MessageBox.Show("Please select the directory with high quality images");
            else
            {
                folderDialog.ShowDialog();
                dossierImages = folderDialog.SelectedPath;
                labelImagesReduites.Text = "path : " + dossierImages;

                listImages = functions.getListImages(dossierImagesHauteQualite);
                functions.reduceImage(dossierImages, listImages, 250);

                listImages = functions.getListImages(dossierImages);

                label2.Show();
                buttonSelectImage.Show();
            }
        }

        private void buttonOui_Click(object sender, EventArgs e)
        {
            label1.Show(); 
            buttonChoixDossier.Show(); 
            labelSelectedPath.Show();
        }

        private void buttonNon_Click(object sender, EventArgs e)
        {
            label8.Show();
            buttonDossierHauteQualité.Show();
            labelHauteQualite.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelTrackbar.Text = trackBar1.Value.ToString();
        }

        private void trackBarN_Scroll(object sender, EventArgs e)
        {
            labelN.Text = trackBarN.Value.ToString();
            labelN.Update();
        }

        private void buttonGetMozaic_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                listImages = functions.getListImages(dossierImages);
                listColor = ColorRGB.getColorOfEveryImages(listImages);
                c++;
            }

            if (dossierImages == "")
            {
                MessageBox.Show("Please, select the path with images.");
            }
            else if (fileImage == "")
            {
                MessageBox.Show("Please, select an image.");
            }
            else
            {
                Bitmap imgRef = new Bitmap(fileImage);

                // REDIMENSIONNEMENT DE L'IMAGE
                img = functions.resizeImage(imgRef, 500);                
                mozaicImg = functions.buildImage(img, N, listColor, listImages, brightnessValue, hueValue, saturationValue, pictureBoxResult);
                resultat = mozaicImg;
            }

            trackBar1.Show();
            buttonAdjustOpacity.Show();
            labelTrackbar.Show();
            label5.Show();
            trackBarN.Show();
            buttonAdjustN.Show();
            labelN.Show();
            labelStep4N.Show();
            buttonSavePicture.Show();
        }

        private void buttonSavePicture_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            fileToSave = saveFileDialog1.FileName + ".png";
            resultat.Save(fileToSave);
        }

        private void buttonAdjustN_Click(object sender, EventArgs e)
        {
            N = trackBarN.Value;
            Bitmap imgRef = new Bitmap(fileImage);

            // Resize picture
            img = functions.resizeImage(imgRef, 500);
            mozaicImg = functions.buildImage(img, N, listColor, listImages, brightnessValue, hueValue, saturationValue, pictureBoxResult);
            float opacity = trackBar1.Value / 100F;
            Bitmap mozaicImgMerged = functions.mergeImage(img, mozaicImg, pictureBoxResult, opacity);
            resultat = mozaicImgMerged;   
        }

        private void buttonAdjustOpacity_Click(object sender, EventArgs e)
        {
            float opacity = trackBar1.Value / 100F;

            Bitmap mozaicImgMerged = functions.mergeImage(img, mozaicImg, pictureBoxResult, opacity);
            resultat = mozaicImgMerged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            img = new Bitmap(fileImage);
            mozaicImg = functions.buildImage(img, N, listColor, listImages, brightnessValue, hueValue, saturationValue, pictureBoxResult);

            float opacity = trackBar1.Value / 100F;
            Bitmap mozaicImgMerged = functions.mergeImage(img, mozaicImg, pictureBoxResult, opacity);
            resultat = mozaicImgMerged; 

            saveFileDialog1.ShowDialog();
            fileToSave = saveFileDialog1.FileName + ".png";
            resultat.Save(fileToSave);
        }
    }
}
