using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeOluşturma
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textEdit1.Text;
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(metin, QRCodeGenerator.ECCLevel.Q);
            QRCode qRcode = new QRCode(qRCodeData);
            Bitmap bitmap = qRcode.GetGraphic(20);
            pictureBox1.Image = bitmap;
        }
    }
}
