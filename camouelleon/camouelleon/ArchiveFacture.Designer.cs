namespace camouelleon
{
    partial class ArchiveFacture
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
            Table = new Label();
            Montant = new Label();
            button2 = new Button();
            cbTable = new ComboBox();
            nmMontant = new NumericUpDown();
            dgvArchive = new DataGridView();
            button1 = new Button();
            label4 = new Label();
            bsArchive = new BindingSource(components);
            bsTable = new BindingSource(components);
            pnl_SF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArchive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsArchive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTable).BeginInit();
            SuspendLayout();
            // 
            // pnl_SF
            // 
            pnl_SF.Controls.Add(Table);
            pnl_SF.Controls.Add(Montant);
            pnl_SF.Controls.Add(button2);
            pnl_SF.Controls.Add(cbTable);
            pnl_SF.Controls.Add(nmMontant);
            pnl_SF.Controls.Add(dgvArchive);
            pnl_SF.Controls.Add(button1);
            pnl_SF.Controls.Add(label4);
            pnl_SF.Location = new Point(0, 0);
            pnl_SF.Name = "pnl_SF";
            pnl_SF.Size = new Size(900, 386);
            pnl_SF.TabIndex = 0;
            // 
            // Table
            // 
            Table.AutoSize = true;
            Table.Location = new Point(656, 191);
            Table.Name = "Table";
            Table.Size = new Size(35, 15);
            Table.TabIndex = 29;
            Table.Text = "Table";
            // 
            // Montant
            // 
            Montant.AutoSize = true;
            Montant.Location = new Point(660, 129);
            Montant.Name = "Montant";
            Montant.Size = new Size(53, 15);
            Montant.TabIndex = 28;
            Montant.Text = "Montant";
            // 
            // button2
            // 
            button2.Location = new Point(656, 91);
            button2.Name = "button2";
            button2.Size = new Size(187, 23);
            button2.TabIndex = 27;
            button2.Text = "Tout afficher";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cbTable
            // 
            cbTable.FormattingEnabled = true;
            cbTable.Location = new Point(657, 209);
            cbTable.Name = "cbTable";
            cbTable.Size = new Size(187, 23);
            cbTable.TabIndex = 25;
            cbTable.SelectedIndexChanged += cbFacture_SelectedIndexChanged;
            // 
            // nmMontant
            // 
            nmMontant.Location = new Point(656, 153);
            nmMontant.Name = "nmMontant";
            nmMontant.Size = new Size(186, 23);
            nmMontant.TabIndex = 24;
            nmMontant.ValueChanged += nmMontant_ValueChanged;
            // 
            // dgvArchive
            // 
            dgvArchive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArchive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchive.Location = new Point(86, 100);
            dgvArchive.Name = "dgvArchive";
            dgvArchive.Size = new Size(551, 229);
            dgvArchive.TabIndex = 23;
            dgvArchive.MouseDoubleClick += dgvArchive_CellContentDoubleClick;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(683, 43);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 22;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(282, 36);
            label4.Name = "label4";
            label4.Size = new Size(185, 28);
            label4.TabIndex = 21;
            label4.Text = "Archive des factures";
            // 
            // ArchiveFacture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 386);
            Controls.Add(pnl_SF);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ArchiveFacture";
            Text = "ArchiveFacture";
            Load += ArchiveFacture_Load;
            pnl_SF.ResumeLayout(false);
            pnl_SF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArchive).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsArchive).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_SF;
        private Label label4;
        private Button button1;
        private BindingSource bsArchive;
        private DataGridView dgvArchive;
        private NumericUpDown nmMontant;
        private ComboBox cbTable;
        private BindingSource bsTable;
        private Button button2;
        private Label Table;
        private Label Montant;
    }
}