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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSuivie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsSuivie).BeginInit();
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
            // button2
            // 
            button2.Location = new Point(31, 122);
            button2.Name = "button2";
            button2.Size = new Size(87, 23);
            button2.TabIndex = 15;
            button2.Text = "commander";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(31, 165);
            button3.Name = "button3";
            button3.Size = new Size(87, 23);
            button3.TabIndex = 16;
            button3.Text = "en cours";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(31, 206);
            button4.Name = "button4";
            button4.Size = new Size(87, 23);
            button4.TabIndex = 17;
            button4.Text = "finit";
            button4.UseVisualStyleBackColor = true;
            // 
            // SuivieCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 387);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dgvSuivie);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuivieCommande";
            Text = "SuivieCommande";
            Load += SuivieCommande_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuivie).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsSuivie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSuivie;
        private Button button1;
        private Label label1;
        private BindingSource bsSuivie;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}