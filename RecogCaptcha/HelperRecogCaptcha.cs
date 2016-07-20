using AForge.Imaging;
using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;
using XnaFan.ImageComparison;

namespace RecogCaptcha
{
    public class HelperRecogCaptcha
    {
        public Bitmap AplicarFiltros(System.Drawing.Image imagem)
        {
            return AplicarFiltros(new Bitmap(imagem));
        }

        public Bitmap AplicarFiltros(Bitmap imagem)
        {
            // Sobel edge detector
            imagem = AplicarFiltro(imagem, new SobelEdgeDetector(), true);
            // Threshold binarization
            imagem = AplicarFiltro(imagem, new Threshold(), true);
            return imagem;
        }

        public string OCR(Bitmap b)
        {
            string res = "";
            if (b == null)
                return res;

            using (var engine = new TesseractEngine(@"tessdata", "eng", EngineMode.Default))
            {
                engine.SetVariable("tessedit_char_whitelist", "1234567890abcdefghijklmnopqrstuvwxyz");
                engine.SetVariable("tessedit_unrej_any_wd", true);

                using (var page = engine.Process(b, PageSegMode.SingleLine))
                    res = page.GetText();
            }
            return res;
        }

        private Bitmap AplicarFiltro(Bitmap img, IFilter filter, bool grayscale = false)
        {
            if (img.PixelFormat != PixelFormat.Format24bppRgb)
            {
                Bitmap temp = AForge.Imaging.Image.Clone(img, PixelFormat.Format24bppRgb);
                img.Dispose();
                img = temp;
            }

            if (grayscale)
                img = Grayscale.CommonAlgorithms.RMY.Apply(img);

            var imagemComFiltro = filter.Apply(img);

            return imagemComFiltro;
        }

        public Blob[] GetBlobs(Bitmap imagem)
        {
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(imagem);
            var blobs = blobCounter.GetObjectsInformation();

            blobs = ReorganizarBlobs(blobs);

            return blobs;
        }

        private Blob[] ReorganizarBlobs(Blob[] blobs)
        {
            var blobsOrganized = blobs
                .Where(o => o.Area > 20)
                .OrderBy(o => o.Rectangle.X).ToList();

            return blobsOrganized.ToArray();
        }
        
        public System.Drawing.Image GetBlob(Bitmap img, Blob[] blobs, int index)
        {
            if (blobs != null && blobs.Length > index)
            {
                Bitmap bmpImage = new Bitmap(img);
                //int margem = 0;
                var ret = new Rectangle(blobs[index].Rectangle.X, blobs[index].Rectangle.Y, blobs[index].Rectangle.Width, blobs[index].Rectangle.Height);
                return bmpImage.Clone(ret, bmpImage.PixelFormat);
            }
            else
                return null;
        }
    }
}
