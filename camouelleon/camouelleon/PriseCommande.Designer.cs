namespace camouelleon
{
    partial class PriseCommande
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbEntree = new ComboBox();
            cbPlat = new ComboBox();
            cbDessert = new ComboBox();
            cbBoisson = new ComboBox();
            button1 = new Button();
            bsEntree = new BindingSource(components);
            bsPlat = new BindingSource(components);
            bsDessert = new BindingSource(components);
            bsBoisson = new BindingSource(components);
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            bsCommande = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsEntree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPlat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDessert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsBoisson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommande).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(290, 58);
            label1.Name = "label1";
            label1.Size = new Size(220, 28);
            label1.TabIndex = 0;
            label1.Text = "Prendre une commande";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 102);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Entrée :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 154);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Plat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 205);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Dessert :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 253);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Boisson :";
            // 
            // cbEntree
            // 
            cbEntree.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEntree.FormattingEnabled = true;
            cbEntree.Location = new Point(279, 99);
            cbEntree.Name = "cbEntree";
            cbEntree.Size = new Size(248, 23);
            cbEntree.TabIndex = 5;
            // 
            // cbPlat
            // 
            cbPlat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPlat.FormattingEnabled = true;
            cbPlat.Location = new Point(279, 151);
            cbPlat.Name = "cbPlat";
            cbPlat.Size = new Size(248, 23);
            cbPlat.TabIndex = 6;
            // 
            // cbDessert
            // 
            cbDessert.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDessert.FormattingEnabled = true;
            cbDessert.Location = new Point(279, 202);
            cbDessert.Name = "cbDessert";
            cbDessert.Size = new Size(248, 23);
            cbDessert.TabIndex = 7;
            // 
            // cbBoisson
            // 
            cbBoisson.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBoisson.FormattingEnabled = true;
            cbBoisson.Location = new Point(279, 250);
            cbBoisson.Name = "cbBoisson";
            cbBoisson.Size = new Size(248, 23);
            cbBoisson.TabIndex = 8;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(706, 46);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 9;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(174, 333);
            button2.Name = "button2";
            button2.Size = new Size(142, 57);
            button2.TabIndex = 10;
            button2.Text = "Ajouter une nouvelle commande";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(466, 333);
            button3.Name = "button3";
            button3.Size = new Size(152, 57);
            button3.TabIndex = 11;
            button3.Text = "Terminer la commande";
            button3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(336, 297);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Menu du jour";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // PriseCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 426);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cbBoisson);
            Controls.Add(cbDessert);
            Controls.Add(cbPlat);
            Controls.Add(cbEntree);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PriseCommande";
            Text = "PriseCommande";
            Load += PriseCommande_Load;
            ((System.ComponentModel.ISupportInitialize)bsEntree).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPlat).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDessert).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsBoisson).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommande).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbEntree;
        private ComboBox cbPlat;
        private ComboBox cbDessert;
        private ComboBox cbBoisson;
        private Button button1;
        private BindingSource bsEntree;
        private BindingSource bsPlat;
        private BindingSource bsDessert;
        private BindingSource bsBoisson;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
        private BindingSource bsCommande;
    }
}