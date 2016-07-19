using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecogCaptcha
{
    public partial class FindLetterForm : Form
    {
        public Bitmap imgCaptcha
        {
            get
            {
                if (ofdCaptcha.FileName != null)
                    _imgCaptcha = new Bitmap(ofdCaptcha.FileName);

                return _imgCaptcha;
            }
        }
        private Bitmap _imgCaptcha;
        
        public Bitmap imgLetter
        {
            get
            {
                if (ofdLetter.FileName != null)
                    _imgLetter = new Bitmap(ofdLetter.FileName);

                return _imgLetter;
            }
        }
        private Bitmap _imgLetter;

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
                pbCaptcha.Image = imgCaptcha;
            }
        }

        private void btLetter_Click(object sender, EventArgs e)
        {
            var result = ofdLetter.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbLetter.Image = imgLetter;
            }
        }

        private void btFindMatch_Click(object sender, EventArgs e)
        {
            pbMatch.Image = FindMacth();
        }

        private Bitmap FindMacth()
        {
            Bitmap imgMatch = null;

            return imgMatch;
        }
    }
}
