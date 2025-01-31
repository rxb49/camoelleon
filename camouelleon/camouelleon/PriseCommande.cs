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
            /*cbEntree.Enabled = false;
            cbPlat.Enabled = false;
            cbDessert.Enabled = false;
            cbBoisson.Enabled = false;*/

            cbCommande.ValueMember = "IDCOMMANDE";
            cbCommande.DisplayMember = "NBCLIENT";
            bsListCommande.DataSource = Modele.Commande();
            cbCommande.DataSource = bsListCommande;

            /* cbEntree.ValueMember = "IDPRODUIT";
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
             cbBoisson.DataSource = bsBoisson;*/

            cb_Type.ValueMember = "ID";
            cb_Type.DisplayMember = "LIBELLE";
            bsType.DataSource = Modele.TypeProduit();
            cb_Type.DataSource = bsType;


            cb_Produit.ValueMember = "IDPRODUIT";
            cb_Produit.DisplayMember = "LBLPRODUIT";
            bsProduit.DataSource = Modele.Produits();
            cb_Produit.DataSource = bsProduit;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int quantite = 1;
            try
            {
                if (checkEntree.Checked)
                {
                    bsCommande.DataSource = Modele.InsertCommande(quantite, Convert.ToInt32(cbEntree.SelectedValue), Convert.ToInt32(cbCommande.SelectedValue));
                }
                if (checkPlat.Checked)
                {
                    bsCommande.DataSource = Modele.InsertCommande(quantite, Convert.ToInt32(cbPlat.SelectedValue), Convert.ToInt32(cbCommande.SelectedValue));
                }
                if (checkDessert.Checked)
                {
                    bsCommande.DataSource = Modele.InsertCommande(quantite, Convert.ToInt32(cbDessert.SelectedValue), Convert.ToInt32(cbCommande.SelectedValue));
                }
                if (checkBoisson.Checked)
                {
                    bsCommande.DataSource = Modele.InsertCommande(quantite, Convert.ToInt32(cbBoisson.SelectedValue), Convert.ToInt32(cbCommande.SelectedValue));
                }
                if (checkBoisson.Checked || checkPlat.Checked || checkDessert.Checked || checkBoisson.Checked)
                {
                    MessageBox.Show("Ajout réussi");
                }
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

        private void checkEntree_CheckedChanged(object sender, EventArgs e)
        {
            cbEntree.Enabled = true;
        }

        private void checkPlat_CheckedChanged(object sender, EventArgs e)
        {
            cbPlat.Enabled = true;
        }

        private void checkDessert_CheckedChanged(object sender, EventArgs e)
        {
            cbDessert.Enabled = true;
        }

        private void checkBoisson_CheckedChanged(object sender, EventArgs e)
        {
            cbBoisson.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cb_Type.Enabled = false;
                cb_Produit.Enabled = false;
            }
            else
            {
                cb_Type.Enabled = true;
                cb_Produit.Enabled = true;
            }

        }

        private void cb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsProduit.DataSource = Modele.GetProduitByType(Convert.ToInt32(cb_Type.SelectedValue));
        }
    }
}
