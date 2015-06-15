using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var t = new ZXing.QrCode.QRCodeWriter();
            var options = new Dictionary<ZXing.EncodeHintType, object> { 
                { ZXing.EncodeHintType.CHARACTER_SET, "utf8" },
                { ZXing.EncodeHintType.ERROR_CORRECTION, "" },
                { ZXing.EncodeHintType.DISABLE_ECI, false }
            };
            var matrix = t.encode(textBox1.Text, 100, 100, options);

            this.pictureBox1.Image = t.ToBitmap(matrix);

            this.textBox2.Text = matrix.ToString();
        }
    }
}
