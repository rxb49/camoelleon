using camouelleon.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class AjoutStock : Form
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
        public AjoutStock(string produit, string stock, int quantite)
        {
            InitializeComponent();


            txtProduit.Text = produit;
            txtStock.Text = stock;
            nmQuantite.Text = quantite.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Stock());
            this.Close();
        }
        private void AjoutStock_Load(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            bsUpdate.DataSource = Modele.UpdateStockById(txtProduit.Text, Convert.ToInt32(nmQuantite.Value), txtStock.Text);
            openChildForm(new Stock());
        }
    }
}
