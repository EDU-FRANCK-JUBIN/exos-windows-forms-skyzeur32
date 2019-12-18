using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRcode
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 qrCode = new Form1();
            qrCode.Show();
        }

        private void btn_Itext_Click(object sender, EventArgs e)
        {
            Form2  IText = new Form2();
            IText.Show();
        }
    }
}
