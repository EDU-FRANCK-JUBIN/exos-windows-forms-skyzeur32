using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using iText;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace QRcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void QRCoderForm_Load(object sender, EventArgs e)
        {
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QRCodeGenerator monQrCodeGenerator = new QRCodeGenerator();
            QRCodeData monQrCodeData = monQrCodeGenerator.CreateQrCode("https://codeshare.io/OGOG", QRCodeGenerator.ECCLevel.Q);
            QRCode monQrCode = new QRCode(monQrCodeData);
            Bitmap monImage = monQrCode.GetGraphic(10, Color.Black, Color.White, true);
            PictureBox maPictureBox = new PictureBox();
            maPictureBox.Width = 500;
            maPictureBox.Height = 500;
            maPictureBox.Image = monImage;
            this.Controls.Add(maPictureBox);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string monTexte = textBox1.Text;
            var writter = new PdfWriter(@"C:\Users\skyze\Documents\2019-2020\IPI M1 IL\Test.pdf");
            var pdf = new PdfDocument(writter);
            var document = new Document(pdf);
            document.Add(new Paragraph(monTexte));
            document.Close();



        }
    }
}
