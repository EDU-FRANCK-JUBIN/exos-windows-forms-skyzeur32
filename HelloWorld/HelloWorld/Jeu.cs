using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Jeu : Form
    {
        int inNullSliceIndex;
        List<Bitmap> listImage = new List<Bitmap>();
        public Jeu()
        {
            InitializeComponent();
            listImage.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._null });
        }
        public void hasard()
        {
            pictureBoxOriginal.Image = Properties.Resources.original;
            List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Random r = new Random();
            int j;
            for (int i = 0; i < 9; i++)
            {
                Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                ((PictureBox)groupBox1.Controls[i]).Image = listImage[j];

            }
        }
        private void Jeu_Load(object sender, EventArgs e)
        {
            hasard();
            
        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Shuffle 
            hasard();
        }
    }
}
