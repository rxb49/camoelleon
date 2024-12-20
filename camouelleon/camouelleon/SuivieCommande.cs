using camouelleon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace camouelleon
{
    public partial class SuivieCommande : Form
    {
        public SuivieCommande()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuivieCommande_Load(object sender, EventArgs e)
        {
            cbEtat.ValueMember = "IDETAT";
            cbEtat.DisplayMember = "LBLETAT";
            bsEtat.DataSource = Modele.Etat();
            cbEtat.DataSource = bsEtat;

            bsSuivie.DataSource = Modele.CommandeWithEtat().Select(x => new
            {
                x.Idcommande,
                x.Nbclient,
                Etat = x.Liers.Select(l => l.IdetatNavigation.Lbletat).FirstOrDefault(),
                Facture = x.Factures.Select(f => f.Montant).FirstOrDefault(),
                Table = x.Idtables.Select(f => f.Idtable).FirstOrDefault(),


            }).ToList();
            dgvSuivie.DataSource = bsSuivie;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bsSuivie.DataSource = Modele.CommandeWithEtat().Select(x => new
            {
                x.Idcommande,
                x.Nbclient,
                Etat = x.Liers.Select(l => l.IdetatNavigation.Lbletat).FirstOrDefault(),
                Facture = x.Factures.Select(f => f.Montant).FirstOrDefault(),
                Table = x.Idtables.Select(f => f.Idtable).FirstOrDefault(),


            }).ToList();
            dgvSuivie.DataSource = bsSuivie;
        }

        private void bsEtat_CurrentChanged(object sender, EventArgs e)
        {
            int IDC = Convert.ToInt32(cbEtat.SelectedValue);
            int IdClient = Convert.ToInt32(cbEtat.SelectedValue);
            bsSuivie.DataSource = Modele.CommandeByEtat(IdClient);
            dgvSuivie.DataSource = bsSuivie;
        }
    }
}
