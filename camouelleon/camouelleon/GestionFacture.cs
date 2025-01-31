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
    public partial class GestionFacture : Form
    {
        public GestionFacture()
        {
            InitializeComponent();
        }

        private void GestionFacture_Load(object sender, EventArgs e)
        {
            bsCommande.DataSource = dgvFacture.DataSource = Modele.CommandesFiniesAvecMontant();
            dgvFacture.DataSource = bsCommande;
        }
    }
}
