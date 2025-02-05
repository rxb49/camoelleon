namespace camouelleon
{
    partial class GestionFacture
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
            dgvFacture = new DataGridView();
            bsCommande = new BindingSource(components);
            pnl_SF = new Panel();
            Table = new Label();
            Montant = new Label();
            button2 = new Button();
            cbTable = new ComboBox();
            nmMontant = new NumericUpDown();
            button1 = new Button();
            label2 = new Label();
            bsMontant = new BindingSource(components);
            bsTable = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvFacture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommande).BeginInit();
            pnl_SF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(305, 33);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 1;
            label1.Text = "Liste des factures";
            // 
            // dgvFacture
            // 
            dgvFacture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacture.Location = new Point(41, 116);
            dgvFacture.Name = "dgvFacture";
            dgvFacture.Size = new Size(555, 200);
            dgvFacture.TabIndex = 2;
            dgvFacture.CellContentDoubleClick += dgvFacture_CellContentDoubleClick;
            dgvFacture.CellDoubleClick += dgvFacture_CellContentDoubleClick;
            // 
            // pnl_SF
            // 
            pnl_SF.Controls.Add(Table);
            pnl_SF.Controls.Add(Montant);
            pnl_SF.Controls.Add(button2);
            pnl_SF.Controls.Add(cbTable);
            pnl_SF.Controls.Add(nmMontant);
            pnl_SF.Controls.Add(button1);
            pnl_SF.Controls.Add(label2);
            pnl_SF.Controls.Add(dgvFacture);
            pnl_SF.Controls.Add(label1);
            pnl_SF.Location = new Point(1, 0);
            pnl_SF.Name = "pnl_SF";
            pnl_SF.Size = new Size(900, 387);
            pnl_SF.TabIndex = 3;
            // 
            // Table
            // 
            Table.AutoSize = true;
            Table.Location = new Point(627, 191);
            Table.Name = "Table";
            Table.Size = new Size(35, 15);
            Table.TabIndex = 31;
            Table.Text = "Table";
            // 
            // Montant
            // 
            Montant.AutoSize = true;
            Montant.Location = new Point(627, 135);
            Montant.Name = "Montant";
            Montant.Size = new Size(53, 15);
            Montant.TabIndex = 30;
            Montant.Text = "Montant";
            // 
            // button2
            // 
            button2.Location = new Point(627, 82);
            button2.Name = "button2";
            button2.Size = new Size(202, 23);
            button2.TabIndex = 26;
            button2.Text = "Tout afficher";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cbTable
            // 
            cbTable.FormattingEnabled = true;
            cbTable.Location = new Point(628, 209);
            cbTable.Name = "cbTable";
            cbTable.Size = new Size(202, 23);
            cbTable.TabIndex = 25;
            cbTable.SelectedIndexChanged += cbTable_SelectedIndexChanged;
            // 
            // nmMontant
            // 
            nmMontant.Location = new Point(627, 153);
            nmMontant.Name = "nmMontant";
            nmMontant.Size = new Size(201, 23);
            nmMontant.TabIndex = 24;
            nmMontant.ValueChanged += nmMontant_ValueChanged;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(689, 40);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 23;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(114, 339);
            label2.Name = "label2";
            label2.Size = new Size(357, 20);
            label2.TabIndex = 13;
            label2.Text = "* Double clique une commande pour créer la facture";
            // 
            // GestionFacture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 387);
            Controls.Add(pnl_SF);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionFacture";
            Text = "GestionFacture";
            Load += GestionFacture_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFacture).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommande).EndInit();
            pnl_SF.ResumeLayout(false);
            pnl_SF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvFacture;
        private BindingSource bsCommande;
        private Panel pnl_SF;
        private Label label2;
        private Button button1;
        private NumericUpDown nmMontant;
        private BindingSource bsMontant;
        private ComboBox cbTable;
        private BindingSource bsTable;
        private Button button2;
        private Label Table;
        private Label Montant;
    }
}