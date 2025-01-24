namespace camouelleon
{
    partial class AjoutProduit
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
            button1 = new Button();
            pnl_SF = new Panel();
            cbStock = new ComboBox();
            label6 = new Label();
            cbType = new ComboBox();
            label5 = new Label();
            btnAjout = new Button();
            cmbUnite = new ComboBox();
            nmPrix = new NumericUpDown();
            txtProduit = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            bsProduit = new BindingSource(components);
            bsUnite = new BindingSource(components);
            bsType = new BindingSource(components);
            bsStock = new BindingSource(components);
            pnl_SF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmPrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsProduit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUnite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(302, 36);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 0;
            label1.Text = "Ajouter un produit";
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(675, 36);
            button1.Name = "button1";
            button1.Size = new Size(26, 23);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnl_SF
            // 
            pnl_SF.Controls.Add(cbStock);
            pnl_SF.Controls.Add(label6);
            pnl_SF.Controls.Add(cbType);
            pnl_SF.Controls.Add(label5);
            pnl_SF.Controls.Add(btnAjout);
            pnl_SF.Controls.Add(cmbUnite);
            pnl_SF.Controls.Add(nmPrix);
            pnl_SF.Controls.Add(txtProduit);
            pnl_SF.Controls.Add(label4);
            pnl_SF.Controls.Add(label3);
            pnl_SF.Controls.Add(label2);
            pnl_SF.Controls.Add(button1);
            pnl_SF.Controls.Add(label1);
            pnl_SF.Location = new Point(1, 0);
            pnl_SF.Name = "pnl_SF";
            pnl_SF.Size = new Size(783, 386);
            pnl_SF.TabIndex = 2;
            // 
            // cbStock
            // 
            cbStock.FormattingEnabled = true;
            cbStock.Location = new Point(289, 262);
            cbStock.Name = "cbStock";
            cbStock.Size = new Size(121, 23);
            cbStock.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 265);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 12;
            label6.Text = "Stock :";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(289, 222);
            cbType.Name = "cbType";
            cbType.Size = new Size(121, 23);
            cbType.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 225);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 10;
            label5.Text = "Type de produit :";
            // 
            // btnAjout
            // 
            btnAjout.Location = new Point(194, 308);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(113, 31);
            btnAjout.TabIndex = 9;
            btnAjout.Text = "Ajouter le produit";
            btnAjout.UseVisualStyleBackColor = true;
            btnAjout.Click += btnAjout_Click;
            // 
            // cmbUnite
            // 
            cmbUnite.FormattingEnabled = true;
            cmbUnite.Location = new Point(290, 130);
            cmbUnite.Name = "cmbUnite";
            cmbUnite.Size = new Size(121, 23);
            cmbUnite.TabIndex = 8;
            // 
            // nmPrix
            // 
            nmPrix.Location = new Point(289, 178);
            nmPrix.Name = "nmPrix";
            nmPrix.Size = new Size(122, 23);
            nmPrix.TabIndex = 7;
            // 
            // txtProduit
            // 
            txtProduit.Location = new Point(289, 83);
            txtProduit.Name = "txtProduit";
            txtProduit.Size = new Size(122, 23);
            txtProduit.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 186);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 4;
            label4.Text = "Prix :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 139);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "Unité :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 85);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Nom du produit :";
            // 
            // AjoutProduit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 386);
            Controls.Add(pnl_SF);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AjoutProduit";
            Text = "AjoutProduit";
            Load += AjoutProduit_Load;
            pnl_SF.ResumeLayout(false);
            pnl_SF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmPrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsProduit).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUnite).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsType).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel pnl_SF;
        private Button btnAjout;
        private ComboBox cmbUnite;
        private NumericUpDown nmPrix;
        private TextBox txtProduit;
        private Label label4;
        private Label label3;
        private Label label2;
        private BindingSource bsProduit;
        private ComboBox cbType;
        private Label label5;
        private BindingSource bsUnite;
        private BindingSource bsType;
        private BindingSource bsStock;
        private Label label6;
        private ComboBox cbStock;
    }
}