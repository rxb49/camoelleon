namespace camouelleon
{
    partial class Login
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
            btn_login = new Button();
            lbl_mdp = new Label();
            lbl_identifient = new Label();
            tb_identifient = new TextBox();
            tb_mdp = new TextBox();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(202, 314);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 0;
            btn_login.Text = "Connexion";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // lbl_mdp
            // 
            lbl_mdp.AutoSize = true;
            lbl_mdp.Location = new Point(202, 198);
            lbl_mdp.Name = "lbl_mdp";
            lbl_mdp.Size = new Size(104, 20);
            lbl_mdp.TabIndex = 1;
            lbl_mdp.Text = "Mots de passe";
            lbl_mdp.Click += label1_Click;
            // 
            // lbl_identifient
            // 
            lbl_identifient.AutoSize = true;
            lbl_identifient.Location = new Point(218, 89);
            lbl_identifient.Name = "lbl_identifient";
            lbl_identifient.Size = new Size(77, 20);
            lbl_identifient.TabIndex = 2;
            lbl_identifient.Text = "Identifient";
            lbl_identifient.Click += label2_Click;
            // 
            // tb_identifient
            // 
            tb_identifient.Location = new Point(193, 112);
            tb_identifient.Name = "tb_identifient";
            tb_identifient.Size = new Size(125, 27);
            tb_identifient.TabIndex = 3;
            // 
            // tb_mdp
            // 
            tb_mdp.Location = new Point(192, 221);
            tb_mdp.Name = "tb_mdp";
            tb_mdp.Size = new Size(125, 27);
            tb_mdp.TabIndex = 4;
            tb_mdp.TextChanged += tb_mdp_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 450);
            Controls.Add(tb_mdp);
            Controls.Add(tb_identifient);
            Controls.Add(lbl_identifient);
            Controls.Add(lbl_mdp);
            Controls.Add(btn_login);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private Label lbl_mdp;
        private Label lbl_identifient;
        private TextBox tb_identifient;
        private TextBox tb_mdp;
    }
}