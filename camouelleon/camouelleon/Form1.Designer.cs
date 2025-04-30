namespace camouelleon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            commandeToolStripMenuItem = new ToolStripMenuItem();
            priseDeCommandeToolStripMenuItem = new ToolStripMenuItem();
            suivieDesCommandesToolStripMenuItem = new ToolStripMenuItem();
            gestionDesCommandesToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem1 = new ToolStripMenuItem();
            gestionDesClientsToolStripMenuItem = new ToolStripMenuItem();
            gestionDesAdminMenuStrip = new ToolStripMenuItem();
            facturesToolStripMenuItem = new ToolStripMenuItem();
            aFaireToolStripMenuItem = new ToolStripMenuItem();
            archiveToolStripMenuItem = new ToolStripMenuItem();
            déchetsToolStripMenuItem = new ToolStripMenuItem();
            pnl_SF = new Panel();
            pb_pp = new PictureBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            pnl_SF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_pp).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { commandeToolStripMenuItem, stockToolStripMenuItem, gestionDesClientsToolStripMenuItem, gestionDesAdminMenuStrip, facturesToolStripMenuItem, déchetsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // commandeToolStripMenuItem
            // 
            commandeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { priseDeCommandeToolStripMenuItem, suivieDesCommandesToolStripMenuItem, gestionDesCommandesToolStripMenuItem });
            commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            commandeToolStripMenuItem.Size = new Size(82, 20);
            commandeToolStripMenuItem.Text = "Commande";
            // 
            // priseDeCommandeToolStripMenuItem
            // 
            priseDeCommandeToolStripMenuItem.Name = "priseDeCommandeToolStripMenuItem";
            priseDeCommandeToolStripMenuItem.Size = new Size(204, 22);
            priseDeCommandeToolStripMenuItem.Text = "Prise de commande";
            priseDeCommandeToolStripMenuItem.Click += priseDeCommandeToolStripMenuItem_Click;
            // 
            // suivieDesCommandesToolStripMenuItem
            // 
            suivieDesCommandesToolStripMenuItem.Name = "suivieDesCommandesToolStripMenuItem";
            suivieDesCommandesToolStripMenuItem.Size = new Size(204, 22);
            suivieDesCommandesToolStripMenuItem.Text = "Suivie des commandes";
            suivieDesCommandesToolStripMenuItem.Click += suivieDesCommandesToolStripMenuItem_Click;
            // 
            // gestionDesCommandesToolStripMenuItem
            // 
            gestionDesCommandesToolStripMenuItem.Name = "gestionDesCommandesToolStripMenuItem";
            gestionDesCommandesToolStripMenuItem.Size = new Size(204, 22);
            gestionDesCommandesToolStripMenuItem.Text = "Gestion des commandes";
            gestionDesCommandesToolStripMenuItem.Click += gestionDesCommandesToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stockToolStripMenuItem1 });
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(48, 20);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // stockToolStripMenuItem1
            // 
            stockToolStripMenuItem1.Name = "stockToolStripMenuItem1";
            stockToolStripMenuItem1.Size = new Size(103, 22);
            stockToolStripMenuItem1.Text = "Stock";
            stockToolStripMenuItem1.Click += stockToolStripMenuItem1_Click;
            // 
            // gestionDesClientsToolStripMenuItem
            // 
            gestionDesClientsToolStripMenuItem.Name = "gestionDesClientsToolStripMenuItem";
            gestionDesClientsToolStripMenuItem.Size = new Size(116, 20);
            gestionDesClientsToolStripMenuItem.Text = "gestion des clients";
            // 
            // gestionDesAdminMenuStrip
            // 
            gestionDesAdminMenuStrip.Name = "gestionDesAdminMenuStrip";
            gestionDesAdminMenuStrip.Size = new Size(164, 20);
            gestionDesAdminMenuStrip.Text = "gestion des administrateurs";
            // 
            // facturesToolStripMenuItem
            // 
            facturesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aFaireToolStripMenuItem, archiveToolStripMenuItem });
            facturesToolStripMenuItem.Name = "facturesToolStripMenuItem";
            facturesToolStripMenuItem.Size = new Size(63, 20);
            facturesToolStripMenuItem.Text = "Factures";
            // 
            // aFaireToolStripMenuItem
            // 
            aFaireToolStripMenuItem.Name = "aFaireToolStripMenuItem";
            aFaireToolStripMenuItem.Size = new Size(114, 22);
            aFaireToolStripMenuItem.Text = "A faire";
            aFaireToolStripMenuItem.Click += aFaireToolStripMenuItem_Click;
            // 
            // archiveToolStripMenuItem
            // 
            archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            archiveToolStripMenuItem.Size = new Size(114, 22);
            archiveToolStripMenuItem.Text = "Archive";
            archiveToolStripMenuItem.Click += archiveToolStripMenuItem_Click;
            // 
            // déchetsToolStripMenuItem
            // 
            déchetsToolStripMenuItem.Name = "déchetsToolStripMenuItem";
            déchetsToolStripMenuItem.Size = new Size(61, 20);
            déchetsToolStripMenuItem.Text = "Déchets";
            déchetsToolStripMenuItem.Click += déchetsToolStripMenuItem_Click;
            // 
            // pnl_SF
            // 
            pnl_SF.Controls.Add(label1);
            pnl_SF.Controls.Add(pb_pp);
            pnl_SF.Location = new Point(0, 27);
            pnl_SF.Name = "pnl_SF";
            pnl_SF.Size = new Size(800, 426);
            pnl_SF.TabIndex = 1;
            pnl_SF.Paint += pnl_SF_Paint;
            // 
            // pb_pp
            // 
            pb_pp.ImageLocation = "B:\\BTSSIO_2nd_Annee\\AP4\\camoelleon_csharp\\camouelleon\\camouelleon\\Images\\logo_fond_blanc_text.png";
            pb_pp.Location = new Point(101, 19);
            pb_pp.Margin = new Padding(3, 2, 3, 2);
            pb_pp.Name = "pb_pp";
            pb_pp.Size = new Size(559, 388);
            pb_pp.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_pp.TabIndex = 9;
            pb_pp.TabStop = false;
            pb_pp.Click += pb_pp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 206);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 10;
            label1.Text = "Test integration continu";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_SF);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnl_SF.ResumeLayout(false);
            pnl_SF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_pp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem commandeToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private ToolStripMenuItem gestionDesAdminMenuStrip;
        private ToolStripMenuItem priseDeCommandeToolStripMenuItem;
        private ToolStripMenuItem suivieDesCommandesToolStripMenuItem;
        private ToolStripMenuItem gestionDesCommandesToolStripMenuItem;
        private Panel pnl_SF;
        private ToolStripMenuItem stockToolStripMenuItem1;
        private PictureBox pb_pp;
        private ToolStripMenuItem facturesToolStripMenuItem;
        private ToolStripMenuItem aFaireToolStripMenuItem;
        private ToolStripMenuItem archiveToolStripMenuItem;
        private ToolStripMenuItem déchetsToolStripMenuItem;
        private Label label1;
    }
}
