using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qr_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator OG = new QRCoder.QRCodeGenerator();
            var Mydata = OG.CreateQrCode(textBox1.Text, QRCoder.QRCodeGenerator.ECCLevel.Q);
            var code = new QRCoder.QRCode(Mydata);
            pictureBox1.Image = code.GetGraphic(20);

        }
    }
}
