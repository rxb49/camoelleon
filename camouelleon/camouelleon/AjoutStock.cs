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
        public AjoutStock(string produit, string stock, int quantite)
        {
            InitializeComponent();


            txtProduit.Text = produit;
            txtStock.Text = stock;
            nmQuantite.Text = quantite.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void AjoutStock_Load(object sender, EventArgs e)
        {

        }
    }
}
