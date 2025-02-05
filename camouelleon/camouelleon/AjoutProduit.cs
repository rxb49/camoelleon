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
    public partial class AjoutProduit : Form
    {
        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            pnl_SF.Controls.Add(formEnfant);
            pnl_SF.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }
        public AjoutProduit()
        {
            InitializeComponent();
            this.Bounds = Screen.PrimaryScreen.Bounds;


        }

        private Stock parentForm;

        public AjoutProduit(Stock parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Stock());
            this.Close();
        }


        private void AjoutProduit_Load(object sender, EventArgs e)
        {
            cmbUnite.ValueMember = "Idunite";
            cmbUnite.DisplayMember = "Lblunite";
            bsUnite.DataSource = Modele.listeUnite();
            cmbUnite.DataSource = bsUnite;

            cbType.ValueMember = "Id";
            cbType.DisplayMember = "Libelle";
            bsType.DataSource = Modele.TypeProduit();
            cbType.DataSource = bsType;

            cbStock.ValueMember = "Idstock";
            cbStock.DisplayMember = "Lblstock";
            bsStock.DataSource = Modele.ListStock();
            cbStock.DataSource = bsStock;



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjout_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProduit.Text))
                {
                    MessageBox.Show("Veuillez entrer un nom de produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbType.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner un type de produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbUnite.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner une unité.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int prix = Convert.ToInt32(nmPrix.Value);
                if (prix <= 0)
                {
                    MessageBox.Show("Le prix doit être supérieur à 0.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbStock.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner un stock.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool success = Modele.AddProduit(
                    Convert.ToInt32(cmbUnite.SelectedValue),
                    txtProduit.Text.Trim(),
                    Convert.ToString(cbType.SelectedValue),
                    prix,
                    Convert.ToInt32(cbStock.SelectedValue)
                );

                if (success)
                {
                    MessageBox.Show("Produit ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    parentForm.RefreshStockDataGridView();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue lors de l'ajout du produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}\n{ex.InnerException?.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
