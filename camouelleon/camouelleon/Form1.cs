namespace camouelleon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        private void priseDeCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new PriseCommande());
        }

        private void suivieDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new SuivieCommande());
        }

        private void gestionDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionCommande());

        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new Stock());
        }

        private void pnl_SF_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
