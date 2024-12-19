using camouelleon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace camouelleon
{
    public partial class PriseCommande : Form
    {
        public PriseCommande()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PriseCommande_Load(object sender, EventArgs e)
        {
            cbEntree.ValueMember = "IDPRODUIT";
            cbEntree.DisplayMember = "LBLPRODUIT";
            bsEntree.DataSource = Modele.GetProduitByType(1);
            cbEntree.DataSource = bsEntree;

            cbPlat.ValueMember = "IDPRODUIT";
            cbPlat.DisplayMember = "LBLPRODUIT";
            bsPlat.DataSource = Modele.GetProduitByType(2);
            cbPlat.DataSource = bsPlat;

            cbDessert.ValueMember = "IDPRODUIT";
            cbDessert.DisplayMember = "LBLPRODUIT";
            bsDessert.DataSource = Modele.GetProduitByType(3);
            cbDessert.DataSource = bsDessert;

            cbBoisson.ValueMember = "IDPRODUIT";
            cbBoisson.DisplayMember = "LBLPRODUIT";
            bsBoisson.DataSource = Modele.GetProduitByType(4);
            cbBoisson.DataSource = bsBoisson;
        }
    }
}
