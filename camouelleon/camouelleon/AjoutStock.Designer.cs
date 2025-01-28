namespace camouelleon
{
    partial class AjoutStock
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
            txtProduit = new TextBox();
            button1 = new Button();
            nmQuantite = new NumericUpDown();
            btnModifier = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bsUpdate = new BindingSource(components);
            pnl_SF = new Panel();
            cbStock = new ComboBox();
            label4 = new Label();
            bsStock = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)nmQuantite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUpdate).BeginInit();
            pnl_SF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsStock).BeginInit();
            SuspendLayout();
            // 
            // txtProduit
            // 
            txtProduit.Enabled = false;
            txtProduit.Location = new Point(157, 78);
            txtProduit.Name = "txtProduit";
            txtProduit.Size = new Size(120, 23);
            txtProduit.TabIndex = 0;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(640, 53);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 14;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nmQuantite
            // 
            nmQuantite.Location = new Point(157, 186);
            nmQuantite.Name = "nmQuantite";
            nmQuantite.Size = new Size(120, 23);
            nmQuantite.TabIndex = 15;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(317, 281);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(118, 50);
            btnModifier.TabIndex = 16;
            btnModifier.Text = "Modifier le stock";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 81);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 17;
            label1.Text = "Produit :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 138);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 18;
            label2.Text = "Stock :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 188);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 19;
            label3.Text = "Quantité :";
            // 
            // pnl_SF
            // 
            pnl_SF.Controls.Add(cbStock);
            pnl_SF.Controls.Add(label4);
            pnl_SF.Controls.Add(label3);
            pnl_SF.Controls.Add(label2);
            pnl_SF.Controls.Add(label1);
            pnl_SF.Controls.Add(btnModifier);
            pnl_SF.Controls.Add(nmQuantite);
            pnl_SF.Controls.Add(button1);
            pnl_SF.Controls.Add(txtProduit);
            pnl_SF.Location = new Point(1, 1);
            pnl_SF.Name = "pnl_SF";
            pnl_SF.Size = new Size(783, 386);
            pnl_SF.TabIndex = 20;
            // 
            // cbStock
            // 
            cbStock.FormattingEnabled = true;
            cbStock.Location = new Point(156, 135);
            cbStock.Name = "cbStock";
            cbStock.Size = new Size(121, 23);
            cbStock.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(317, 24);
            label4.Name = "label4";
            label4.Size = new Size(158, 28);
            label4.TabIndex = 20;
            label4.Text = "Modifier le stock";
            // 
            // AjoutStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 387);
            Controls.Add(pnl_SF);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AjoutStock";
            Text = "AjoutStock";
            Load += AjoutStock_Load;
            ((System.ComponentModel.ISupportInitialize)nmQuantite).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUpdate).EndInit();
            pnl_SF.ResumeLayout(false);
            pnl_SF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtProduit;
        private Button button1;
        private NumericUpDown nmQuantite;
        private Button btnModifier;
        private Label label1;
        private Label label2;
        private Label label3;
        private BindingSource bsUpdate;
        private Panel pnl_SF;
        private Label label4;
        private ComboBox cbStock;
        private BindingSource bsStock;
    }
}