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
            ((System.ComponentModel.ISupportInitialize)dgvFacture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommande).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(306, 34);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 1;
            label1.Text = "Liste des factures";
            // 
            // dgvFacture
            // 
            dgvFacture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacture.Location = new Point(115, 119);
            dgvFacture.Name = "dgvFacture";
            dgvFacture.Size = new Size(375, 200);
            dgvFacture.TabIndex = 2;
            // 
            // GestionFacture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 567);
            Controls.Add(dgvFacture);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionFacture";
            Text = "GestionFacture";
            Load += GestionFacture_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFacture).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommande).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvFacture;
        private BindingSource bsCommande;
    }
}