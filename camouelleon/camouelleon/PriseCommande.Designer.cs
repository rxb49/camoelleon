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
            button1 = new Button();
            bsEntree = new BindingSource(components);
            bsPlat = new BindingSource(components);
            bsDessert = new BindingSource(components);
            bsBoisson = new BindingSource(components);
            button3 = new Button();
            checkBox1 = new CheckBox();
            bsCommande = new BindingSource(components);
            label6 = new Label();
            cbCommande = new ComboBox();
            bsListCommande = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbEntree = new ComboBox();
            cbPlat = new ComboBox();
            cbDessert = new ComboBox();
            cbBoisson = new ComboBox();
            checkEntree = new CheckBox();
            checkPlat = new CheckBox();
            checkDessert = new CheckBox();
            checkBoisson = new CheckBox();
            dgvSuivie = new DataGridView();
            gb_lngCom = new GroupBox();
            nm_qty = new NumericUpDown();
            lbl_qty = new Label();
            lbl_Produit = new Label();
            lbl_Type = new Label();
            btn_LgnAdd = new Button();
            cb_Produit = new ComboBox();
            cb_Type = new ComboBox();
            bsType = new BindingSource(components);
            bsProduit = new BindingSource(components);
            bsComAct = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsEntree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPlat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDessert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsBoisson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsListCommande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuivie).BeginInit();
            gb_lngCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_qty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsProduit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsComAct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(334, 12);
            label1.Name = "label1";
            label1.Size = new Size(283, 35);
            label1.TabIndex = 0;
            label1.Text = "Prendre une commande";
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(833, 19);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(29, 31);
            button1.TabIndex = 9;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(178, 437);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(174, 46);
            button3.TabIndex = 11;
            button3.Text = "Terminer la commande";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(100, 57);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 24);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Menu du jour";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(137, 76);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 13;
            label6.Text = "Table :";
            // 
            // cbCommande
            // 
            cbCommande.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCommande.FormattingEnabled = true;
            cbCommande.Location = new Point(226, 73);
            cbCommande.Margin = new Padding(3, 4, 3, 4);
            cbCommande.Name = "cbCommande";
            cbCommande.Size = new Size(282, 28);
            cbCommande.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(833, 536);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Entrée :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(842, 581);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Plat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(843, 624);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Dessert :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(843, 688);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Boisson :";
            // 
            // cbEntree
            // 
            cbEntree.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEntree.FormattingEnabled = true;
            cbEntree.Location = new Point(983, 532);
            cbEntree.Margin = new Padding(3, 4, 3, 4);
            cbEntree.Name = "cbEntree";
            cbEntree.Size = new Size(283, 28);
            cbEntree.TabIndex = 5;
            // 
            // cbPlat
            // 
            cbPlat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPlat.FormattingEnabled = true;
            cbPlat.Location = new Point(992, 577);
            cbPlat.Margin = new Padding(3, 4, 3, 4);
            cbPlat.Name = "cbPlat";
            cbPlat.Size = new Size(283, 28);
            cbPlat.TabIndex = 6;
            // 
            // cbDessert
            // 
            cbDessert.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDessert.FormattingEnabled = true;
            cbDessert.Location = new Point(993, 620);
            cbDessert.Margin = new Padding(3, 4, 3, 4);
            cbDessert.Name = "cbDessert";
            cbDessert.Size = new Size(283, 28);
            cbDessert.TabIndex = 7;
            // 
            // cbBoisson
            // 
            cbBoisson.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBoisson.FormattingEnabled = true;
            cbBoisson.Location = new Point(993, 684);
            cbBoisson.Margin = new Padding(3, 4, 3, 4);
            cbBoisson.Name = "cbBoisson";
            cbBoisson.Size = new Size(283, 28);
            cbBoisson.TabIndex = 8;
            // 
            // checkEntree
            // 
            checkEntree.AutoSize = true;
            checkEntree.Location = new Point(798, 537);
            checkEntree.Margin = new Padding(3, 4, 3, 4);
            checkEntree.Name = "checkEntree";
            checkEntree.Size = new Size(18, 17);
            checkEntree.TabIndex = 15;
            checkEntree.UseVisualStyleBackColor = true;
            checkEntree.CheckedChanged += checkEntree_CheckedChanged;
            // 
            // checkPlat
            // 
            checkPlat.AutoSize = true;
            checkPlat.Location = new Point(807, 581);
            checkPlat.Margin = new Padding(3, 4, 3, 4);
            checkPlat.Name = "checkPlat";
            checkPlat.Size = new Size(18, 17);
            checkPlat.TabIndex = 16;
            checkPlat.UseVisualStyleBackColor = true;
            checkPlat.CheckedChanged += checkPlat_CheckedChanged;
            // 
            // checkDessert
            // 
            checkDessert.AutoSize = true;
            checkDessert.Location = new Point(808, 626);
            checkDessert.Margin = new Padding(3, 4, 3, 4);
            checkDessert.Name = "checkDessert";
            checkDessert.Size = new Size(18, 17);
            checkDessert.TabIndex = 17;
            checkDessert.UseVisualStyleBackColor = true;
            checkDessert.CheckedChanged += checkDessert_CheckedChanged;
            // 
            // checkBoisson
            // 
            checkBoisson.AutoSize = true;
            checkBoisson.Location = new Point(808, 690);
            checkBoisson.Margin = new Padding(3, 4, 3, 4);
            checkBoisson.Name = "checkBoisson";
            checkBoisson.Size = new Size(18, 17);
            checkBoisson.TabIndex = 18;
            checkBoisson.UseVisualStyleBackColor = true;
            checkBoisson.CheckedChanged += checkBoisson_CheckedChanged;
            // 
            // dgvSuivie
            // 
            dgvSuivie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuivie.Location = new Point(25, 130);
            dgvSuivie.Margin = new Padding(3, 4, 3, 4);
            dgvSuivie.Name = "dgvSuivie";
            dgvSuivie.RowHeadersWidth = 51;
            dgvSuivie.Size = new Size(483, 283);
            dgvSuivie.TabIndex = 19;
            // 
            // gb_lngCom
            // 
            gb_lngCom.Controls.Add(nm_qty);
            gb_lngCom.Controls.Add(lbl_qty);
            gb_lngCom.Controls.Add(lbl_Produit);
            gb_lngCom.Controls.Add(lbl_Type);
            gb_lngCom.Controls.Add(btn_LgnAdd);
            gb_lngCom.Controls.Add(cb_Produit);
            gb_lngCom.Controls.Add(cb_Type);
            gb_lngCom.Controls.Add(checkBox1);
            gb_lngCom.Location = new Point(546, 73);
            gb_lngCom.Name = "gb_lngCom";
            gb_lngCom.Size = new Size(317, 373);
            gb_lngCom.TabIndex = 20;
            gb_lngCom.TabStop = false;
            gb_lngCom.Text = "Ajouter à la commande";
            // 
            // nm_qty
            // 
            nm_qty.Location = new Point(25, 277);
            nm_qty.Margin = new Padding(3, 4, 3, 4);
            nm_qty.Name = "nm_qty";
            nm_qty.Size = new Size(264, 27);
            nm_qty.TabIndex = 16;
            // 
            // lbl_qty
            // 
            lbl_qty.AutoSize = true;
            lbl_qty.Location = new Point(121, 242);
            lbl_qty.Name = "lbl_qty";
            lbl_qty.Size = new Size(66, 20);
            lbl_qty.TabIndex = 6;
            lbl_qty.Text = "Quantité";
            // 
            // lbl_Produit
            // 
            lbl_Produit.AutoSize = true;
            lbl_Produit.Location = new Point(129, 184);
            lbl_Produit.Name = "lbl_Produit";
            lbl_Produit.Size = new Size(57, 20);
            lbl_Produit.TabIndex = 5;
            lbl_Produit.Text = "Produit";
            lbl_Produit.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_Type
            // 
            lbl_Type.AutoSize = true;
            lbl_Type.Location = new Point(100, 109);
            lbl_Type.Name = "lbl_Type";
            lbl_Type.Size = new Size(114, 20);
            lbl_Type.TabIndex = 4;
            lbl_Type.Text = "Type de produit";
            lbl_Type.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_LgnAdd
            // 
            btn_LgnAdd.Location = new Point(68, 330);
            btn_LgnAdd.Name = "btn_LgnAdd";
            btn_LgnAdd.Size = new Size(174, 29);
            btn_LgnAdd.TabIndex = 3;
            btn_LgnAdd.Text = "Ajouter";
            btn_LgnAdd.UseVisualStyleBackColor = true;
            // 
            // cb_Produit
            // 
            cb_Produit.FormattingEnabled = true;
            cb_Produit.Location = new Point(24, 207);
            cb_Produit.Name = "cb_Produit";
            cb_Produit.Size = new Size(264, 28);
            cb_Produit.TabIndex = 1;
            // 
            // cb_Type
            // 
            cb_Type.FormattingEnabled = true;
            cb_Type.Location = new Point(25, 132);
            cb_Type.Name = "cb_Type";
            cb_Type.Size = new Size(264, 28);
            cb_Type.TabIndex = 0;
            cb_Type.SelectedIndexChanged += cb_Type_SelectedIndexChanged;
            // 
            // PriseCommande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 808);
            Controls.Add(gb_lngCom);
            Controls.Add(dgvSuivie);
            Controls.Add(checkBoisson);
            Controls.Add(checkDessert);
            Controls.Add(checkPlat);
            Controls.Add(checkEntree);
            Controls.Add(cbCommande);
            Controls.Add(label6);
            Controls.Add(button3);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "PriseCommande";
            Text = "PriseCommande";
            Load += PriseCommande_Load;
            ((System.ComponentModel.ISupportInitialize)bsEntree).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPlat).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDessert).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsBoisson).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommande).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsListCommande).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuivie).EndInit();
            gb_lngCom.ResumeLayout(false);
            gb_lngCom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nm_qty).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsType).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsProduit).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsComAct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private BindingSource bsEntree;
        private BindingSource bsPlat;
        private BindingSource bsDessert;
        private BindingSource bsBoisson;
        private Button button3;
        private CheckBox checkBox1;
        private BindingSource bsCommande;
        private Label label6;
        private ComboBox cbCommande;
        private BindingSource bsListCommande;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbEntree;
        private ComboBox cbPlat;
        private ComboBox cbDessert;
        private ComboBox cbBoisson;
        private CheckBox checkEntree;
        private CheckBox checkPlat;
        private CheckBox checkDessert;
        private CheckBox checkBoisson;
        private DataGridView dgvSuivie;
        private GroupBox gb_lngCom;
        private ComboBox cb_Produit;
        private ComboBox cb_Type;
        private Button btn_LgnAdd;
        private Label lbl_qty;
        private Label lbl_Produit;
        private Label lbl_Type;
        private NumericUpDown nm_qty;
        private BindingSource bsType;
        private BindingSource bsProduit;
        private BindingSource bsComAct;
    }
}