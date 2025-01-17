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
            label1 = new Label();
            button1 = new Button();
            pnl_SF = new Panel();
            pnl_SF.SuspendLayout();
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
            pnl_SF.Controls.Add(button1);
            pnl_SF.Controls.Add(label1);
            pnl_SF.Location = new Point(1, 0);
            pnl_SF.Name = "pnl_SF";
            pnl_SF.Size = new Size(783, 386);
            pnl_SF.TabIndex = 2;
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
            pnl_SF.ResumeLayout(false);
            pnl_SF.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel pnl_SF;
    }
}