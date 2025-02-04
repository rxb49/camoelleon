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
            dgvArchive = new DataGridView();
            button1 = new Button();
            label4 = new Label();
            bsArchive = new BindingSource(components);
            pnl_SF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArchive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsArchive).BeginInit();
            SuspendLayout();
            // 
            // pnl_SF
            // 
            pnl_SF.Controls.Add(dgvArchive);
            pnl_SF.Controls.Add(button1);
            pnl_SF.Controls.Add(label4);
            pnl_SF.Location = new Point(0, 0);
            pnl_SF.Name = "pnl_SF";
            pnl_SF.Size = new Size(783, 386);
            pnl_SF.TabIndex = 0;
            // 
            // dgvArchive
            // 
            dgvArchive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchive.Location = new Point(169, 104);
            dgvArchive.Name = "dgvArchive";
            dgvArchive.Size = new Size(416, 229);
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
            ClientSize = new Size(783, 386);
            Controls.Add(pnl_SF);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ArchiveFacture";
            Text = "ArchiveFacture";
            Load += ArchiveFacture_Load;
            pnl_SF.ResumeLayout(false);
            pnl_SF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArchive).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsArchive).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_SF;
        private Label label4;
        private Button button1;
        private BindingSource bsArchive;
        private DataGridView dgvArchive;
    }
}