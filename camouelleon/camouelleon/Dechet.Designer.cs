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
            dgvDechets = new DataGridView();
            cbProduit = new ComboBox();
            nmQuantite = new NumericUpDown();
            dtpDate = new DateTimePicker();
            btnAjouter = new Button();
            bsProduit = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bsDechet = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDechets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmQuantite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsProduit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDechet).BeginInit();
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
            // dgvDechets
            // 
            dgvDechets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDechets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDechets.Enabled = false;
            dgvDechets.Location = new Point(12, 154);
            dgvDechets.Name = "dgvDechets";
            dgvDechets.Size = new Size(594, 272);
            dgvDechets.TabIndex = 1;
            // 
            // cbProduit
            // 
            cbProduit.FormattingEnabled = true;
            cbProduit.Location = new Point(713, 208);
            cbProduit.Name = "cbProduit";
            cbProduit.Size = new Size(200, 23);
            cbProduit.TabIndex = 2;
            // 
            // nmQuantite
            // 
            nmQuantite.Location = new Point(713, 267);
            nmQuantite.Name = "nmQuantite";
            nmQuantite.Size = new Size(200, 23);
            nmQuantite.TabIndex = 3;
            nmQuantite.ValueChanged += nmQuantite_ValueChanged;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(713, 319);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 4;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(750, 381);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(135, 26);
            btnAjouter.TabIndex = 5;
            btnAjouter.Text = "Ajouter le déchet";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(735, 140);
            label2.Name = "label2";
            label2.Size = new Size(168, 28);
            label2.TabIndex = 6;
            label2.Text = "Ajouter un déchet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(638, 208);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 7;
            label3.Text = "Produit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(638, 269);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 8;
            label4.Text = "Quantité";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(638, 325);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "Date";
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(899, 36);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 23;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Dechet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 500);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAjouter);
            Controls.Add(dtpDate);
            Controls.Add(nmQuantite);
            Controls.Add(cbProduit);
            Controls.Add(dgvDechets);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dechet";
            Text = "Dechet";
            ((System.ComponentModel.ISupportInitialize)dgvDechets).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmQuantite).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsProduit).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDechet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDechets;
        private ComboBox cbProduit;
        private NumericUpDown nmQuantite;
        private DateTimePicker dtpDate;
        private Button btnAjouter;
        private BindingSource bsProduit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private BindingSource bsDechet;
        private Button button1;
    }
}