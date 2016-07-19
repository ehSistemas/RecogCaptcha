using AForge.Imaging;
using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Tesseract;
using System.Data;
using System.Linq;
using XnaFan.ImageComparison;

namespace RecogCaptcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public HelperRecogCaptcha HelperRecogCaptcha
        {
            get { if (_helperRecogCaptcha == null) _helperRecogCaptcha = new HelperRecogCaptcha(); return _helperRecogCaptcha; }
            set { _helperRecogCaptcha = value; }
        }
        private HelperRecogCaptcha _helperRecogCaptcha;

        private void openImageButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Bitmap image = new Bitmap(openFileDialog.FileName);
            //pbImagemOriginal.Image = image;
            if (image != null)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(openFileDialog.FileName);
                resultLabel.Text = reconhecerCaptchaTeste(image);
            }
            image.Dispose();
        }

        private string reconhecerCaptcha(System.Drawing.Image img)
        {
            Bitmap imagem = new Bitmap(img);
            imagem = imagem.Clone(new Rectangle(0, 0, img.Width, img.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Erosion erosion = new Erosion();
            Dilatation dilatation = new Dilatation();
            Invert inverter = new Invert();
            ColorFiltering cor = new ColorFiltering();
            cor.Blue = new AForge.IntRange(200, 255);
            cor.Red = new AForge.IntRange(200, 255);
            cor.Green = new AForge.IntRange(200, 255);
            Opening open = new Opening();
            BlobsFiltering bc = new BlobsFiltering();
            Closing close = new Closing();
            GaussianSharpen gs = new GaussianSharpen();
            ContrastCorrection cc = new ContrastCorrection();
            bc.MinHeight = 10;
            FiltersSequence seq = new FiltersSequence(gs, inverter, open, inverter, bc, inverter, open, cc, cor, bc, inverter);
            pictureBox.Image = seq.Apply(imagem);
            string reconhecido = HelperRecogCaptcha.OCR((Bitmap)pictureBox.Image);
            return reconhecido;
        }

        private string reconhecerCaptchaTeste(System.Drawing.Image img)
        {
            Bitmap imagem = new Bitmap(img);
            imagem = imagem.Clone(new Rectangle(0, 0, img.Width, img.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            pbImagemOriginal.Image = imagem;

            // Aplicação de Filtros
            imagem = HelperRecogCaptcha.AplicarFiltros(imagem);

            // Separação de letras 
            SepararLetras(imagem);

            // Aplicar OCR nas letras
            OCRLetras();

            // Encontrar imagem mais semelhates
            EncontrarSemelhanca();

            pictureBox.Image = imagem;

            string reconhecido = HelperRecogCaptcha.OCR((Bitmap)pictureBox.Image);
            return reconhecido;
        }

        private void EncontrarSemelhanca()
        {
            Dictionary<string, float> dic = new Dictionary<string, float>();

            // 1->2
            if (pbCaracter1.Image != null && pbCaracter2.Image != null)
                dic.Add("1;2", pbCaracter1.Image.PercentageDifference(pbCaracter2.Image));
            // 1->3
            if (pbCaracter1.Image != null && pbCaracter3.Image != null)
                dic.Add("1;3", pbCaracter1.Image.PercentageDifference(pbCaracter3.Image));
            // 1->4
            if (pbCaracter1.Image != null && pbCaracter4.Image != null)
                dic.Add("1;4", pbCaracter1.Image.PercentageDifference(pbCaracter4.Image));
            // 1->5
            if (pbCaracter1.Image != null && pbCaracter5.Image != null)
                dic.Add("1;5", pbCaracter1.Image.PercentageDifference(pbCaracter5.Image));
            // 1->6
            if (pbCaracter1.Image != null && pbCaracter6.Image != null)
                dic.Add("1;6", pbCaracter1.Image.PercentageDifference(pbCaracter6.Image));
            // 2->3
            if (pbCaracter2.Image != null && pbCaracter3.Image != null)
                dic.Add("2;3", pbCaracter2.Image.PercentageDifference(pbCaracter3.Image));
            // 2->4
            if (pbCaracter2.Image != null && pbCaracter4.Image != null)
                dic.Add("2;4", pbCaracter2.Image.PercentageDifference(pbCaracter4.Image));
            // 2->5
            if (pbCaracter2.Image != null && pbCaracter5.Image != null)
                dic.Add("2;5", pbCaracter2.Image.PercentageDifference(pbCaracter5.Image));
            // 2->6
            if (pbCaracter2.Image != null && pbCaracter6.Image != null)
                dic.Add("2;6", pbCaracter2.Image.PercentageDifference(pbCaracter6.Image));
            // 3->4
            if (pbCaracter3.Image != null && pbCaracter4.Image != null)
                dic.Add("3;4", pbCaracter3.Image.PercentageDifference(pbCaracter4.Image));
            // 3->5
            if (pbCaracter3.Image != null && pbCaracter5.Image != null)
                dic.Add("3;5", pbCaracter3.Image.PercentageDifference(pbCaracter5.Image));
            // 3->6
            if (pbCaracter3.Image != null && pbCaracter6.Image != null)
                dic.Add("3;6", pbCaracter3.Image.PercentageDifference(pbCaracter6.Image));
            // 4->5
            if (pbCaracter4.Image != null && pbCaracter5.Image != null)
                dic.Add("4;5", pbCaracter4.Image.PercentageDifference(pbCaracter5.Image));
            // 4->6
            if (pbCaracter4.Image != null && pbCaracter6.Image != null)
                dic.Add("4;6", pbCaracter4.Image.PercentageDifference(pbCaracter6.Image));
            // 5->6
            if (pbCaracter5.Image != null && pbCaracter6.Image != null)
                dic.Add("5;6", pbCaracter5.Image.PercentageDifference(pbCaracter6.Image));

            var dicTop = dic.OrderBy(o => o.Value).Take(1).FirstOrDefault();

            var idxImg = dicTop.Key.Split(';');
            pbImg1.Image = GetImage(idxImg[0]);
            pbImg2.Image = GetImage(idxImg[1]);

            lbPercent.Text = String.Format("{0} %", dicTop.Value * 100);
        }

        private System.Drawing.Image GetImage(string v)
        {
            switch (v)
            {
                case "1":
                    return pbCaracter1.Image;
                case "2":
                    return pbCaracter2.Image;
                case "3":
                    return pbCaracter3.Image;
                case "4":
                    return pbCaracter4.Image;
                case "5":
                    return pbCaracter5.Image;
                case "6":
                    return pbCaracter6.Image;
            }

            return pbCaracter1.Image;
        }

        private void SepararLetras(Bitmap imagem)
        {
            var blobs = HelperRecogCaptcha.GetBlobs(imagem);

            pbCaracter1.Image = HelperRecogCaptcha.GetBlob(imagem, blobs, 0);
            pbCaracter2.Image = HelperRecogCaptcha.GetBlob(imagem, blobs, 1);
            pbCaracter3.Image = HelperRecogCaptcha.GetBlob(imagem, blobs, 2);
            pbCaracter4.Image = HelperRecogCaptcha.GetBlob(imagem, blobs, 3);
            pbCaracter5.Image = HelperRecogCaptcha.GetBlob(imagem, blobs, 4);
            pbCaracter6.Image = HelperRecogCaptcha.GetBlob(imagem, blobs, 5);
        }

        private void OCRLetras()
        {
            tbCaracter1.Text = HelperRecogCaptcha.OCR((Bitmap)pbCaracter1.Image);
            tbCaracter2.Text = HelperRecogCaptcha.OCR((Bitmap)pbCaracter2.Image);
            tbCaracter3.Text = HelperRecogCaptcha.OCR((Bitmap)pbCaracter3.Image);
            tbCaracter4.Text = HelperRecogCaptcha.OCR((Bitmap)pbCaracter4.Image);
            tbCaracter5.Text = HelperRecogCaptcha.OCR((Bitmap)pbCaracter5.Image);
            tbCaracter6.Text = HelperRecogCaptcha.OCR((Bitmap)pbCaracter6.Image);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pbLetra.Image = new Bitmap(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, float> dic = new Dictionary<string, float>();

            // Letra->1
            if (pbLetra.Image != null && pbCaracter1.Image != null)
                dic.Add("1;1", pbLetra.Image.PercentageDifference(pbCaracter1.Image));
            // Letra->2
            if (pbLetra.Image != null && pbCaracter2.Image != null)
                dic.Add("1;2", pbLetra.Image.PercentageDifference(pbCaracter2.Image));
            // Letra->3
            if (pbLetra.Image != null && pbCaracter3.Image != null)
                dic.Add("1;3", pbLetra.Image.PercentageDifference(pbCaracter3.Image));
            // Letra->4
            if (pbLetra.Image != null && pbCaracter4.Image != null)
                dic.Add("1;4", pbLetra.Image.PercentageDifference(pbCaracter4.Image));
            // Letra->5
            if (pbLetra.Image != null && pbCaracter5.Image != null)
                dic.Add("1;5", pbLetra.Image.PercentageDifference(pbCaracter5.Image));
            // Letra->6
            if (pbLetra.Image != null && pbCaracter6.Image != null)
                dic.Add("1;6", pbLetra.Image.PercentageDifference(pbCaracter6.Image));

            var dicTop = dic.OrderBy(o => o.Value).Take(1).FirstOrDefault();

            var idxImg = dicTop.Key.Split(';');
            pbLetraSemelhante.Image = GetImage(idxImg[1]);

            lbPercentLetra.Text = String.Format("{0} %", dicTop.Value * 100);
        }
    }
}
