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
            pnl_SF = new Panel();
            pb_pp = new PictureBox();
            menuStrip1.SuspendLayout();
            pnl_SF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_pp).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { commandeToolStripMenuItem, stockToolStripMenuItem, gestionDesClientsToolStripMenuItem, gestionDesAdminMenuStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // commandeToolStripMenuItem
            // 
            commandeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { priseDeCommandeToolStripMenuItem, suivieDesCommandesToolStripMenuItem, gestionDesCommandesToolStripMenuItem });
            commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            commandeToolStripMenuItem.Size = new Size(100, 24);
            commandeToolStripMenuItem.Text = "Commande";
            // 
            // priseDeCommandeToolStripMenuItem
            // 
            priseDeCommandeToolStripMenuItem.Name = "priseDeCommandeToolStripMenuItem";
            priseDeCommandeToolStripMenuItem.Size = new Size(254, 26);
            priseDeCommandeToolStripMenuItem.Text = "Prise de commande";
            priseDeCommandeToolStripMenuItem.Click += priseDeCommandeToolStripMenuItem_Click;
            // 
            // suivieDesCommandesToolStripMenuItem
            // 
            suivieDesCommandesToolStripMenuItem.Name = "suivieDesCommandesToolStripMenuItem";
            suivieDesCommandesToolStripMenuItem.Size = new Size(254, 26);
            suivieDesCommandesToolStripMenuItem.Text = "Suivie des commandes";
            suivieDesCommandesToolStripMenuItem.Click += suivieDesCommandesToolStripMenuItem_Click;
            // 
            // gestionDesCommandesToolStripMenuItem
            // 
            gestionDesCommandesToolStripMenuItem.Name = "gestionDesCommandesToolStripMenuItem";
            gestionDesCommandesToolStripMenuItem.Size = new Size(254, 26);
            gestionDesCommandesToolStripMenuItem.Text = "Gestion des commandes";
            gestionDesCommandesToolStripMenuItem.Click += gestionDesCommandesToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stockToolStripMenuItem1 });
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(59, 24);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // stockToolStripMenuItem1
            // 
            stockToolStripMenuItem1.Name = "stockToolStripMenuItem1";
            stockToolStripMenuItem1.Size = new Size(128, 26);
            stockToolStripMenuItem1.Text = "Stock";
            stockToolStripMenuItem1.Click += stockToolStripMenuItem1_Click;
            // 
            // gestionDesClientsToolStripMenuItem
            // 
            gestionDesClientsToolStripMenuItem.Name = "gestionDesClientsToolStripMenuItem";
            gestionDesClientsToolStripMenuItem.Size = new Size(145, 24);
            gestionDesClientsToolStripMenuItem.Text = "gestion des clients";
            // 
            // gestionDesAdminMenuStrip
            // 
            gestionDesAdminMenuStrip.Name = "gestionDesAdminMenuStrip";
            gestionDesAdminMenuStrip.Size = new Size(205, 24);
            gestionDesAdminMenuStrip.Text = "gestion des administrateurs";
            gestionDesAdminMenuStrip.Click += gsetionDseAdministrateursToolStripMenuItem_Click;
            // 
            // pnl_SF
            // 
            pnl_SF.Controls.Add(pb_pp);
            pnl_SF.Location = new Point(0, 36);
            pnl_SF.Margin = new Padding(3, 4, 3, 4);
            pnl_SF.Name = "pnl_SF";
            pnl_SF.Size = new Size(914, 568);
            pnl_SF.TabIndex = 1;
            pnl_SF.Paint += pnl_SF_Paint;
            // 
            // pb_pp
            // 
            pb_pp.ImageLocation = "B:\\BTSSIO_2nd_Annee\\AP4\\camoelleon_csharp\\camouelleon\\camouelleon\\Images\\logo_fond_blanc_text.png";
            pb_pp.Location = new Point(115, 25);
            pb_pp.Name = "pb_pp";
            pb_pp.Size = new Size(639, 518);
            pb_pp.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_pp.TabIndex = 9;
            pb_pp.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pnl_SF);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnl_SF.ResumeLayout(false);
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
    }
}
