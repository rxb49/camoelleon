using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace camouelleon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private bool IsValidInput(string input, string pattern)
        {

            return Regex.IsMatch(input, pattern);
        }




        private void btn_login_Click(object sender, EventArgs e)
        {
            if (IsValidInput(tb_identifient.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,5}$") && tb_mdp.Text != "" && tb_mdp.Text != null)
            {
                lbl_error_id.Text = "";
                lbl_error_login.Text = "";
                MessageBox.Show("Connexion réussie !");//À vérifier si c'est utilisé
            }
            else
            {
                if (!IsValidInput(tb_identifient.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,5}$"))
                {
                    lbl_error_mdp.Text = "";
                    lbl_error_id.Text = "L'identifiant doit être une adresse e-mail,\n Exemple : \"utilisateur@exemple.com\".";
                }
                if (tb_mdp.Text == "" || tb_mdp.Text == null)
                {
                    lbl_error_mdp.Text = "Saisissez un mot de passe";
                }
                
            }   
        }



        private void tb_identifient_TextChanged(object sender, EventArgs e)
        {

            if (IsValidInput(tb_identifient.Text, @"^[a-zA-Z0-9_\-\.@ ]*$"))
            {
                lbl_error_id.Text = "";
            }
            else
            {
                lbl_error_id.Text = "Saisie invalide !";
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbl_error_id.Text = Entities.Modele.PremiereAllergie().Lblallergie;
        }
    }
}
