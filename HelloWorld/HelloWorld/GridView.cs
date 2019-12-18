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
    public partial class GridView : Form
    {



        public GridView()
        {
            InitializeComponent();
            List<Personne> mesPersonnes = new List<Personne>();
            Personne Sami = new Personne();
            mesPersonnes.Add(Sami);

            mesPersonnes.Add(new Personne("LeBienNommé"));

            //mesPersonnes.Add(new Personne("Sors", "Jean", "01/01/1901".ToDate()));

            personneBindingSource.DataSource = mesPersonnes;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridView_Load(object sender, EventArgs e)
        {

        }
    }
}
