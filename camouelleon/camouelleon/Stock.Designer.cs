namespace camouelleon
{
    partial class Stock
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
            dgvStock = new DataGridView();
            button1 = new Button();
            bsStock = new BindingSource(components);
            pnl_SF = new Panel();
            txtSearchProduit = new TextBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStock).BeginInit();
            pnl_SF.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(348, 45);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 0;
            label1.Text = "STOCK";
            // 
            // dgvStock
            // 
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(116, 148);
            dgvStock.Name = "dgvStock";
            dgvStock.Size = new Size(530, 232);
            dgvStock.TabIndex = 1;
            dgvStock.CellContentClick += dgvStock_CellContentClick;
            dgvStock.CellDoubleClick += dgvStock_CellDoubleClick;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(775, 45);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 11;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnl_SF
            // 
            pnl_SF.Controls.Add(label3);
            pnl_SF.Controls.Add(txtSearchProduit);
            pnl_SF.Controls.Add(button2);
            pnl_SF.Controls.Add(label2);
            pnl_SF.Controls.Add(button1);
            pnl_SF.Controls.Add(dgvStock);
            pnl_SF.Controls.Add(label1);
            pnl_SF.Location = new Point(1, 0);
            pnl_SF.Name = "pnl_SF";
            pnl_SF.Size = new Size(900, 500);
            pnl_SF.TabIndex = 12;
            pnl_SF.Paint += pnl_SF_Paint;
            // 
            // txtSearchProduit
            // 
            txtSearchProduit.Location = new Point(247, 108);
            txtSearchProduit.Name = "txtSearchProduit";
            txtSearchProduit.Size = new Size(285, 23);
            txtSearchProduit.TabIndex = 14;
            txtSearchProduit.TextChanged += txtSearchProduit_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(703, 163);
            button2.Name = "button2";
            button2.Size = new Size(97, 43);
            button2.TabIndex = 13;
            button2.Text = "Ajouter un produit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(116, 406);
            label2.Name = "label2";
            label2.Size = new Size(375, 20);
            label2.TabIndex = 12;
            label2.Text = "* Double clique sur un produit pour le réapprovisionner";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 111);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 15;
            label3.Text = "Rechercher un produit";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(pnl_SF);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Stock";
            Text = "Stock";
            Load += Stock_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStock).EndInit();
            pnl_SF.ResumeLayout(false);
            pnl_SF.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvStock;
        private Button button1;
        private BindingSource bsStock;
        private Panel pnl_SF;
        private Label label2;
        private Button button2;
        private TextBox txtSearchProduit;
        private Label label3;
    }
}