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
            button1 = new Button();
            label1 = new Label();
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
            pnl_SF.Dock = DockStyle.Fill;
            pnl_SF.Location = new Point(0, 0);
            pnl_SF.Name = "pnl_SF";
            pnl_SF.Size = new Size(800, 370);
            pnl_SF.TabIndex = 2;
            // 
            // cbStock
            // 
            cbStock.Anchor = AnchorStyles.None;
            cbStock.FormattingEnabled = true;
            cbStock.Location = new Point(284, 260);
            cbStock.Name = "cbStock";
            cbStock.Size = new Size(121, 23);
            cbStock.TabIndex = 26;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(105, 263);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 25;
            label6.Text = "Stock :";
            // 
            // cbType
            // 
            cbType.Anchor = AnchorStyles.None;
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(284, 220);
            cbType.Name = "cbType";
            cbType.Size = new Size(121, 23);
            cbType.TabIndex = 24;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(105, 223);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 23;
            label5.Text = "Type de produit :";
            // 
            // btnAjout
            // 
            btnAjout.Anchor = AnchorStyles.None;
            btnAjout.Location = new Point(189, 306);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(113, 31);
            btnAjout.TabIndex = 22;
            btnAjout.Text = "Ajouter le produit";
            btnAjout.UseVisualStyleBackColor = true;
            btnAjout.Click += btnAjout_Click_1;
            // 
            // cmbUnite
            // 
            cmbUnite.Anchor = AnchorStyles.None;
            cmbUnite.FormattingEnabled = true;
            cmbUnite.Location = new Point(285, 128);
            cmbUnite.Name = "cmbUnite";
            cmbUnite.Size = new Size(121, 23);
            cmbUnite.TabIndex = 21;
            // 
            // nmPrix
            // 
            nmPrix.Anchor = AnchorStyles.None;
            nmPrix.Location = new Point(284, 176);
            nmPrix.Name = "nmPrix";
            nmPrix.Size = new Size(122, 23);
            nmPrix.TabIndex = 20;
            // 
            // txtProduit
            // 
            txtProduit.Anchor = AnchorStyles.None;
            txtProduit.Location = new Point(284, 81);
            txtProduit.Name = "txtProduit";
            txtProduit.Size = new Size(122, 23);
            txtProduit.TabIndex = 19;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(105, 184);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 18;
            label4.Text = "Prix :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(105, 137);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 17;
            label3.Text = "Unité :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(105, 83);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 16;
            label2.Text = "Nom du produit :";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(670, 34);
            button1.Name = "button1";
            button1.Size = new Size(26, 23);
            button1.TabIndex = 15;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(297, 34);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 14;
            label1.Text = "Ajouter un produit";
            // 
            // AjoutProduit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 370);
            Controls.Add(pnl_SF);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AjoutProduit";
            Text = "AjoutProduit";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
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
        private Panel pnl_SF;
        private BindingSource bsProduit;
        private BindingSource bsUnite;
        private BindingSource bsType;
        private BindingSource bsStock;
        private ComboBox cbStock;
        private Label label6;
        private ComboBox cbType;
        private Label label5;
        private Button btnAjout;
        private ComboBox cmbUnite;
        private NumericUpDown nmPrix;
        private TextBox txtProduit;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label1;
    }
}