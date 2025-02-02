namespace camouelleon
{
    partial class GestionFacture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dgvFacture = new DataGridView();
            bsCommande = new BindingSource(components);
            pnl_SF = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFacture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommande).BeginInit();
            pnl_SF.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(305, 33);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 1;
            label1.Text = "Liste des factures";
            // 
            // dgvFacture
            // 
            dgvFacture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacture.Location = new Point(114, 118);
            dgvFacture.Name = "dgvFacture";
            dgvFacture.Size = new Size(375, 200);
            dgvFacture.TabIndex = 2;
            dgvFacture.CellContentDoubleClick += dgvFacture_CellContentDoubleClick;
            dgvFacture.CellDoubleClick += dgvFacture_CellContentDoubleClick;
            // 
            // pnl_SF
            // 
            pnl_SF.Controls.Add(label2);
            pnl_SF.Controls.Add(dgvFacture);
            pnl_SF.Controls.Add(label1);
            pnl_SF.Location = new Point(1, 0);
            pnl_SF.Name = "pnl_SF";
            pnl_SF.Size = new Size(784, 387);
            pnl_SF.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(114, 339);
            label2.Name = "label2";
            label2.Size = new Size(375, 20);
            label2.TabIndex = 13;
            label2.Text = "* Double clique sur un produit pour le réapprovisionner";
            // 
            // GestionFacture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 387);
            Controls.Add(pnl_SF);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionFacture";
            Text = "GestionFacture";
            Load += GestionFacture_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFacture).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommande).EndInit();
            pnl_SF.ResumeLayout(false);
            pnl_SF.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvFacture;
        private BindingSource bsCommande;
        private Panel pnl_SF;
        private Label label2;
    }
}