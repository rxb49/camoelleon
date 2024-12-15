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
            lbl_error_id = new Label();
            lbl_error_login = new Label();
            lbl_error_mdp = new Label();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(188, 373);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 0;
            btn_login.Text = "Connexion";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_mdp
            // 
            lbl_mdp.AutoSize = true;
            lbl_mdp.Location = new Point(188, 257);
            lbl_mdp.Name = "lbl_mdp";
            lbl_mdp.Size = new Size(104, 20);
            lbl_mdp.TabIndex = 1;
            lbl_mdp.Text = "Mots de passe";
            lbl_mdp.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_identifient
            // 
            lbl_identifient.AutoSize = true;
            lbl_identifient.Location = new Point(204, 148);
            lbl_identifient.Name = "lbl_identifient";
            lbl_identifient.Size = new Size(77, 20);
            lbl_identifient.TabIndex = 2;
            lbl_identifient.Text = "Identifient";
            lbl_identifient.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_identifient
            // 
            tb_identifient.Location = new Point(98, 171);
            tb_identifient.Name = "tb_identifient";
            tb_identifient.Size = new Size(299, 27);
            tb_identifient.TabIndex = 3;
            tb_identifient.TextChanged += tb_identifient_TextChanged;
            // 
            // tb_mdp
            // 
            tb_mdp.Location = new Point(98, 280);
            tb_mdp.Name = "tb_mdp";
            tb_mdp.Size = new Size(299, 27);
            tb_mdp.TabIndex = 4;
            tb_mdp.UseSystemPasswordChar = true;
            // 
            // lbl_error_id
            // 
            lbl_error_id.AutoSize = true;
            lbl_error_id.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_error_id.Location = new Point(98, 201);
            lbl_error_id.Name = "lbl_error_id";
            lbl_error_id.Size = new Size(0, 20);
            lbl_error_id.TabIndex = 5;
            // 
            // lbl_error_login
            // 
            lbl_error_login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_error_login.AutoSize = true;
            lbl_error_login.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_error_login.Location = new Point(118, 332);
            lbl_error_login.Name = "lbl_error_login";
            lbl_error_login.Size = new Size(0, 20);
            lbl_error_login.TabIndex = 6;
            lbl_error_login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_error_mdp
            // 
            lbl_error_mdp.AutoSize = true;
            lbl_error_mdp.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_error_mdp.Location = new Point(98, 310);
            lbl_error_mdp.Name = "lbl_error_mdp";
            lbl_error_mdp.Size = new Size(0, 20);
            lbl_error_mdp.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 450);
            Controls.Add(lbl_error_mdp);
            Controls.Add(lbl_error_login);
            Controls.Add(lbl_error_id);
            Controls.Add(tb_mdp);
            Controls.Add(tb_identifient);
            Controls.Add(lbl_identifient);
            Controls.Add(lbl_mdp);
            Controls.Add(btn_login);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private Label lbl_mdp;
        private Label lbl_identifient;
        private TextBox tb_identifient;
        private TextBox tb_mdp;
        private Label lbl_error_id;
        private Label lbl_error_login;
        private Label lbl_error_mdp;
    }
}