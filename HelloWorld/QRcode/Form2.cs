using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace QRcode
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
