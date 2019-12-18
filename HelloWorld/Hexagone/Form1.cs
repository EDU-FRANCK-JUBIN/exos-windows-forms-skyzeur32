using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hexagone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int haut = panel1.Height;
            int larg = panel1.Width;

            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);

            Brush br = new SolidBrush(Color.Green);
            Pen p = new Pen(br,3);
            Point p1 = new Point(10, 20);
            Point p2 = new Point(10, 56);
            g.DrawLine(p,p1,p2);
        }
    }
}
