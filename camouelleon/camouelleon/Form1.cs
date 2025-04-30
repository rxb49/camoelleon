namespace camouelleon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;  // Maximiser la fenêtre

            // Adapter le formulaire à la taille de l'écran principal
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;

            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.None;

            pnl_SF.Controls.Add(formEnfant);
            pnl_SF.Tag = formEnfant;

            int xPos = (pnl_SF.ClientSize.Width - formEnfant.Width) / 2;
            int yPos = (pnl_SF.ClientSize.Height - formEnfant.Height) / 2;

            formEnfant.Location = new Point(xPos, yPos);

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

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aFaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionFacture());
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ArchiveFacture());
        }

        private void déchetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Dechet());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnl_SF.Location = new Point(0, menuStrip1.Height); // Déplacer le panneau juste sous la navbar
            pnl_SF.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - menuStrip1.Height); // Ajuster la taille du panneau
        }

        private void pb_pp_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
