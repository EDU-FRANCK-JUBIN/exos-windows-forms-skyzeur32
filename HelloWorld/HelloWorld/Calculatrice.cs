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
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void Calculatrice_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            // bouton du =
            

            foreach (char s in calcul.Text)
            {
                if (s == '+')
                {
                    string[] chaine = calcul.Text.Split('+');

                    resultat.Text += double.Parse(chaine[0]) + double.Parse(chaine[1]);
                }
                if (s == '-')
                {
                    string[] chaine = calcul.Text.Split('-');

                    resultat.Text += double.Parse(chaine[0]) - double.Parse(chaine[1]);
                }
                if (s == '*')
                {
                    string[] chaine = calcul.Text.Split('*');

                    resultat.Text += double.Parse(chaine[0]) * double.Parse(chaine[1]);
   
                }
                if (s == '/')
                {
                    string[] chaine = calcul.Text.Split('/');

                    resultat.Text += double.Parse(chaine[0]) / double.Parse(chaine[1]);
                }


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calcul.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            calcul.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            calcul.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            calcul.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            calcul.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            calcul.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            calcul.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            calcul.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            calcul.Text += "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calcul.Text = "";
            resultat.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
           // calcul.Text = "";
            resultat.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            calcul.Text += "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            calcul.Text += "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calcul.Text += "*";
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            calcul.Text += "/";
           
        }
    }
}
