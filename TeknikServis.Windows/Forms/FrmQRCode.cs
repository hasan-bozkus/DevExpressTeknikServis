using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace TeknikServis.Windows.Forms
{
    public partial class FrmQRCode : Form
    {
        public FrmQRCode()
        {
            InitializeComponent();
        }

        private void SmpBtnCreateQR_Click(object sender, EventArgs e)
        {
            //..\TeknikServis\DevExpressTeknikServis\TeknikServis.Windows\bin\Debug\QR
            QRCodeEncoder enc = new QRCodeEncoder();
            PictureEditQRCodeImage.Image = enc.Encode(TxtSerialNo.Text);
        }
    }
}
