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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Stock());
            this.Close();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            bsProduit.DataSource = Modele.AddProduit(Convert.ToInt32(cmbUnite.SelectedValue), txtProduit.Text, Convert.ToString(cbType.SelectedValue), Convert.ToInt32(nmPrix.Value));
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

    }
}
