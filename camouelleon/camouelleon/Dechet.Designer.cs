namespace camouelleon
{
    partial class Dechet
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
            dataGridView1 = new DataGridView();
            cbProduit = new ComboBox();
            nmQuantite = new NumericUpDown();
            dtpDate = new DateTimePicker();
            btnAjouter = new Button();
            bsProduit = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmQuantite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsProduit).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(361, 60);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 0;
            label1.Text = "Déchets";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(493, 216);
            dataGridView1.TabIndex = 1;
            // 
            // cbProduit
            // 
            cbProduit.FormattingEnabled = true;
            cbProduit.Location = new Point(652, 137);
            cbProduit.Name = "cbProduit";
            cbProduit.Size = new Size(200, 23);
            cbProduit.TabIndex = 2;
            // 
            // nmQuantite
            // 
            nmQuantite.Location = new Point(652, 196);
            nmQuantite.Name = "nmQuantite";
            nmQuantite.Size = new Size(200, 23);
            nmQuantite.TabIndex = 3;
            nmQuantite.ValueChanged += nmQuantite_ValueChanged;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(652, 248);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 4;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(710, 317);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 5;
            btnAjouter.Text = "button1";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(674, 69);
            label2.Name = "label2";
            label2.Size = new Size(168, 28);
            label2.TabIndex = 6;
            label2.Text = "Ajouter un déchet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(558, 140);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 7;
            label3.Text = "Produit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(558, 198);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 8;
            label4.Text = "Quantité";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(558, 254);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "Date";
            // 
            // Dechet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 500);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAjouter);
            Controls.Add(dtpDate);
            Controls.Add(nmQuantite);
            Controls.Add(cbProduit);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dechet";
            Text = "Dechet";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmQuantite).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsProduit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox cbProduit;
        private NumericUpDown nmQuantite;
        private DateTimePicker dtpDate;
        private Button btnAjouter;
        private BindingSource bsProduit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}