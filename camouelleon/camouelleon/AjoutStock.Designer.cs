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
            txtProduit = new TextBox();
            txtStock = new TextBox();
            button1 = new Button();
            nmQuantite = new NumericUpDown();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmQuantite).BeginInit();
            SuspendLayout();
            // 
            // txtProduit
            // 
            txtProduit.Enabled = false;
            txtProduit.Location = new Point(160, 79);
            txtProduit.Name = "txtProduit";
            txtProduit.Size = new Size(100, 23);
            txtProduit.TabIndex = 0;
            // 
            // txtStock
            // 
            txtStock.Enabled = false;
            txtStock.Location = new Point(160, 136);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 1;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(643, 54);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 14;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nmQuantite
            // 
            nmQuantite.Location = new Point(160, 187);
            nmQuantite.Name = "nmQuantite";
            nmQuantite.Size = new Size(120, 23);
            nmQuantite.TabIndex = 15;
            // 
            // button2
            // 
            button2.Location = new Point(320, 282);
            button2.Name = "button2";
            button2.Size = new Size(118, 50);
            button2.TabIndex = 16;
            button2.Text = "Modifier le stock";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 82);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 17;
            label1.Text = "Produit :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 139);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 18;
            label2.Text = "Stock :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 189);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 19;
            label3.Text = "Quantité :";
            // 
            // AjoutStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 387);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(nmQuantite);
            Controls.Add(button1);
            Controls.Add(txtStock);
            Controls.Add(txtProduit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AjoutStock";
            Text = "AjoutStock";
            Load += AjoutStock_Load;
            ((System.ComponentModel.ISupportInitialize)nmQuantite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProduit;
        private TextBox txtStock;
        private Button button1;
        private NumericUpDown nmQuantite;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}