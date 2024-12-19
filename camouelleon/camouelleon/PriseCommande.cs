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
            cbCommande.ValueMember = "IDCOMMANDE";
            cbCommande.DisplayMember = "NBCLIENT";
            bsListCommande.DataSource = Modele.Commande();
            cbCommande.DataSource = bsListCommande;

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

        private void button2_Click(object sender, EventArgs e)
        {
            int quantite = 1;
            try
            {
                bsCommande.DataSource = Modele.InsertCommande(quantite, Convert.ToInt32(cbEntree.SelectedValue), Convert.ToInt32(cbCommande.SelectedValue));
                bsCommande.DataSource = Modele.InsertCommande(quantite, Convert.ToInt32(cbPlat.SelectedValue), Convert.ToInt32(cbCommande.SelectedValue));
                bsCommande.DataSource = Modele.InsertCommande(quantite, Convert.ToInt32(cbDessert.SelectedValue), Convert.ToInt32(cbCommande.SelectedValue));
                bsCommande.DataSource = Modele.InsertCommande(quantite, Convert.ToInt32(cbBoisson.SelectedValue), Convert.ToInt32(cbCommande.SelectedValue));
                MessageBox.Show("Ajout réussi");
            }
            catch
            {
                MessageBox.Show("Erreur lors de l\'ajout");

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
