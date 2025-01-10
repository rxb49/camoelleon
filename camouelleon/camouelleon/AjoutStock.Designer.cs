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
            txtQuantite = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtProduit
            // 
            txtProduit.Location = new Point(160, 158);
            txtProduit.Name = "txtProduit";
            txtProduit.Size = new Size(100, 23);
            txtProduit.TabIndex = 0;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(160, 212);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 1;
            // 
            // txtQuantite
            // 
            txtQuantite.Location = new Point(160, 287);
            txtQuantite.Name = "txtQuantite";
            txtQuantite.Size = new Size(100, 23);
            txtQuantite.TabIndex = 2;
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
            // AjoutStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 387);
            Controls.Add(button1);
            Controls.Add(txtQuantite);
            Controls.Add(txtStock);
            Controls.Add(txtProduit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AjoutStock";
            Text = "AjoutStock";
            Load += AjoutStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProduit;
        private TextBox txtStock;
        private TextBox txtQuantite;
        private Button button1;
    }
}