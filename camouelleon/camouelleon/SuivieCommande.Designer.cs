namespace camouelleon
{
    partial class SuivieCommande
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
            dgvSuivie = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            bsSuivie = new BindingSource(components);
            button5 = new Button();
            cbEtat = new ComboBox();
            bsEtat = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            nmMontant = new NumericUpDown();
            bsMontant = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvSuivie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsSuivie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEtat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMontant).BeginInit();
            SuspendLayout();
            // 
            // dgvSuivie
            // 
            dgvSuivie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuivie.Location = new Point(135, 111);
            dgvSuivie.Name = "dgvSuivie";
            dgvSuivie.Size = new Size(505, 221);
            dgvSuivie.TabIndex = 14;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(657, 46);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 13;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(263, 46);
            label1.Name = "label1";
            label1.Size = new Size(210, 28);
            label1.TabIndex = 12;
            label1.Text = "Suivie des commandes";
            // 
            // button5
            // 
            button5.Location = new Point(31, 53);
            button5.Name = "button5";
            button5.Size = new Size(94, 23);
            button5.TabIndex = 18;
            button5.Text = "afficher tout";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // cbEtat
            // 
            cbEtat.FormattingEnabled = true;
            cbEtat.Location = new Point(8, 123);
            cbEtat.Name = "cbEtat";
            cbEtat.Size = new Size(121, 23);
            cbEtat.TabIndex = 19;
            // 
            // bsEtat
            // 
            bsEtat.CurrentChanged += bsEtat_CurrentChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 20;
            label2.Text = "Etat :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 163);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 22;
            label3.Text = "Montant minimum :";
            // 
            // nmMontant
            // 
            nmMontant.Location = new Point(8, 194);
            nmMontant.Name = "nmMontant";
            nmMontant.Size = new Size(120, 23);
            nmMontant.TabIndex = 23;
            nmMontant.ValueChanged += nmMontant_ValueChanged;
            // 
            // SuivieCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 387);
            Controls.Add(nmMontant);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbEtat);
            Controls.Add(button5);
            Controls.Add(dgvSuivie);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuivieCommande";
            Text = "SuivieCommande";
            Load += SuivieCommande_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuivie).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsSuivie).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEtat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMontant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSuivie;
        private Button button1;
        private Label label1;
        private BindingSource bsSuivie;
        private Button button5;
        private ComboBox cbEtat;
        private BindingSource bsEtat;
        private Label label2;
        private Label label3;
        private NumericUpDown nmMontant;
        private BindingSource bsMontant;
    }
}