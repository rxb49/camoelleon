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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            bsStock.DataSource = Modele.ListAllStock().Select(x => new
            {
                Produit = x.IdproduitNavigation.Lblproduit,
                Stock = x.IdstockNavigation.Lblstock,
                x.Quantite
            }).ToList();
            dgvStock.DataSource = bsStock;
        }
    }
}
