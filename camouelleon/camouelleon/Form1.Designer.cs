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
            stockToolStripMenuItem = new ToolStripMenuItem();
            gestionDesClientsToolStripMenuItem = new ToolStripMenuItem();
            gsetionDseAdministrateursToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { commandeToolStripMenuItem, stockToolStripMenuItem, gestionDesClientsToolStripMenuItem, gsetionDseAdministrateursToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // commandeToolStripMenuItem
            // 
            commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            commandeToolStripMenuItem.Size = new Size(82, 20);
            commandeToolStripMenuItem.Text = "Commande";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(48, 20);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // gestionDesClientsToolStripMenuItem
            // 
            gestionDesClientsToolStripMenuItem.Name = "gestionDesClientsToolStripMenuItem";
            gestionDesClientsToolStripMenuItem.Size = new Size(116, 20);
            gestionDesClientsToolStripMenuItem.Text = "gestion des clients";
            // 
            // gsetionDseAdministrateursToolStripMenuItem
            // 
            gsetionDseAdministrateursToolStripMenuItem.Name = "gsetionDseAdministrateursToolStripMenuItem";
            gsetionDseAdministrateursToolStripMenuItem.Size = new Size(164, 20);
            gsetionDseAdministrateursToolStripMenuItem.Text = "gsetion dse administrateurs";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem commandeToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private ToolStripMenuItem gsetionDseAdministrateursToolStripMenuItem;
    }
}
