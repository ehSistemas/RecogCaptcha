using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XnaFan.ImageComparison;

namespace RecogCaptcha
{
    public partial class FindLetterForm : Form
    {
        public Image imgCaptcha
        {
            get
            {
                return pbCaptcha.Image;
            }
            set
            {
                pbCaptcha.Image = value;
            }
        }

        public Image imgLetter
        {
            get
            {
                return pbLetter.Image;
            }
            set
            {
                pbLetter.Image = value;
            }
        }

        public HelperRecogCaptcha HelperRecogCaptcha
        {
            get { if (_helperRecogCaptcha == null) _helperRecogCaptcha = new HelperRecogCaptcha(); return _helperRecogCaptcha; }
            set { _helperRecogCaptcha = value; }
        }
        private HelperRecogCaptcha _helperRecogCaptcha;

        public FindLetterForm()
        {
            InitializeComponent();
        }

        private void btLoadCaptcha_Click(object sender, EventArgs e)
        {
            var result = ofdCaptcha.ShowDialog();
            if (result == DialogResult.OK)
            {
                imgCaptcha = new Bitmap(ofdCaptcha.FileName);
            }
        }

        private void btLetter_Click(object sender, EventArgs e)
        {
            var result = ofdLetter.ShowDialog();
            if (result == DialogResult.OK)
            {
                imgLetter = new Bitmap(ofdLetter.FileName);
            }
        }

        private void btAplicarFiltros_Click(object sender, EventArgs e)
        {
            if (imgCaptcha == null)
                return;

            imgCaptcha = HelperRecogCaptcha.AplicarFiltros(imgCaptcha);
        }

        private void btFindMatch_Click(object sender, EventArgs e)
        {
            pbMatch.Image = FindMacth();
        }

        private Bitmap FindMacth()
        {
            Bitmap imgBitMapCaptcha = new Bitmap(imgCaptcha);
            dataGridView1.Rows.Clear();

            //var ret = new Rectangle(0, 0, 16, 21);
            //imgMatch = imgBitMapCaptcha.Clone(ret, imgBitMapCaptcha.PixelFormat);

            //if (pbLetter.Image != null)
            //    lbPercent.Text = string.Format("{0}%", (pbLetter.Image.PercentageDifference(imgMatch) * 100));

            float menorPercentualDeDiferencaFind = 1;
            Bitmap imgMatchFind = null;
            for (int y = 0; y < (imgBitMapCaptcha.Height - 20); y++)
            {
                for (int x = 0; x < (imgBitMapCaptcha.Width - 15); x++)
                {
                    var ret = new Rectangle(x, y, 16, 21);
                    var imgMatch = imgBitMapCaptcha.Clone(ret, imgBitMapCaptcha.PixelFormat);
                    var menorPercentualDeDiferenca = pbLetter.Image.PercentageDifference(imgMatch);

                    dataGridView1.Rows.Add(string.Format("{0}%", (menorPercentualDeDiferenca * 100)), imgMatch);
                    if (menorPercentualDeDiferenca < menorPercentualDeDiferencaFind)
                    {
                        menorPercentualDeDiferencaFind = menorPercentualDeDiferenca;
                        imgMatchFind = imgMatch;
                    }
                }
            }

            lbPercent.Text = string.Format("{0}%", (menorPercentualDeDiferencaFind * 100));

            return imgMatchFind;
        }

        private void btSalve_Click(object sender, EventArgs e)
        {
            pbCaptcha.Image.Save(@"C:\teste\teste.bmp");
        }
    }
}
