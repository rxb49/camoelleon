namespace camouelleon
{
    partial class CreateFacture
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
            txtCommande = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtClient = new TextBox();
            label3 = new Label();
            txtMontant = new TextBox();
            pnl_SF = new Panel();
            BtnGenererFacture = new Button();
            pnl_SF.SuspendLayout();
            SuspendLayout();
            // 
            // txtCommande
            // 
            txtCommande.Location = new Point(324, 144);
            txtCommande.Name = "txtCommande";
            txtCommande.Size = new Size(203, 23);
            txtCommande.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 147);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "Id Commande :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 207);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "nb Client";
            // 
            // txtClient
            // 
            txtClient.Location = new Point(324, 204);
            txtClient.Name = "txtClient";
            txtClient.Size = new Size(203, 23);
            txtClient.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 272);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Montant";
            // 
            // txtMontant
            // 
            txtMontant.Location = new Point(324, 264);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(203, 23);
            txtMontant.TabIndex = 4;
            // 
            // pnl_SF
            // 
            pnl_SF.Controls.Add(BtnGenererFacture);
            pnl_SF.Controls.Add(label3);
            pnl_SF.Controls.Add(txtMontant);
            pnl_SF.Controls.Add(label2);
            pnl_SF.Controls.Add(txtClient);
            pnl_SF.Controls.Add(label1);
            pnl_SF.Controls.Add(txtCommande);
            pnl_SF.Location = new Point(0, 1);
            pnl_SF.Name = "pnl_SF";
            pnl_SF.Size = new Size(900, 500);
            pnl_SF.TabIndex = 6;
            // 
            // BtnGenererFacture
            // 
            BtnGenererFacture.Location = new Point(399, 350);
            BtnGenererFacture.Name = "BtnGenererFacture";
            BtnGenererFacture.Size = new Size(111, 36);
            BtnGenererFacture.TabIndex = 6;
            BtnGenererFacture.Text = "Generer";
            BtnGenererFacture.UseVisualStyleBackColor = true;
            BtnGenererFacture.Click += BtnGenererFacture_Click;
            // 
            // CreateFacture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(pnl_SF);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateFacture";
            Text = "CreateFacture";
            pnl_SF.ResumeLayout(false);
            pnl_SF.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCommande;
        private Label label1;
        private Label label2;
        private TextBox txtClient;
        private Label label3;
        private TextBox txtMontant;
        private Panel pnl_SF;
        private Button BtnGenererFacture;
    }
}