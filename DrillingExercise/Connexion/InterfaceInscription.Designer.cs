namespace Drilling
{
    partial class InterfaceInscription
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_pswd = new System.Windows.Forms.Label();
            this.cmd_signup = new System.Windows.Forms.Button();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.lbl_confirm_pswd = new System.Windows.Forms.Label();
            this.txt_confirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(12, 9);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(57, 13);
            this.lbl_firstname.TabIndex = 0;
            this.lbl_firstname.Text = "First Name";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(135, 9);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(58, 13);
            this.lbl_lastname.TabIndex = 0;
            this.lbl_lastname.Text = "Last Name";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(12, 60);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(73, 13);
            this.lbl_mail.TabIndex = 0;
            this.lbl_mail.Text = "Email Address";
            // 
            // lbl_pswd
            // 
            this.lbl_pswd.AutoSize = true;
            this.lbl_pswd.Location = new System.Drawing.Point(12, 111);
            this.lbl_pswd.Name = "lbl_pswd";
            this.lbl_pswd.Size = new System.Drawing.Size(53, 13);
            this.lbl_pswd.TabIndex = 0;
            this.lbl_pswd.Text = "Password";
            // 
            // cmd_signup
            // 
            this.cmd_signup.Enabled = false;
            this.cmd_signup.Location = new System.Drawing.Point(74, 164);
            this.cmd_signup.Name = "cmd_signup";
            this.cmd_signup.Size = new System.Drawing.Size(100, 29);
            this.cmd_signup.TabIndex = 6;
            this.cmd_signup.Text = "Sign up";
            this.cmd_signup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmd_signup.UseVisualStyleBackColor = true;
            this.cmd_signup.Click += new System.EventHandler(this.cmd_signup_Click);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(138, 25);
            this.txt_lastName.MaxLength = 50;
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(100, 20);
            this.txt_lastName.TabIndex = 2;
            this.txt_lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_lastName.TextChanged += new System.EventHandler(this.txt_lastName_TextChanged);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(12, 76);
            this.txt_mail.MaxLength = 128;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(226, 20);
            this.txt_mail.TabIndex = 3;
            this.txt_mail.Text = "@etud.u-picardie.fr";
            this.txt_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mail.TextChanged += new System.EventHandler(this.txt_mail_TextChanged);
            this.txt_mail.Enter += new System.EventHandler(this.txt_mail_Enter);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(12, 127);
            this.txt_password.MaxLength = 32;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 4;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(12, 25);
            this.txt_firstName.MaxLength = 50;
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(100, 20);
            this.txt_firstName.TabIndex = 1;
            this.txt_firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_firstName.TextChanged += new System.EventHandler(this.txt_firstName_TextChanged);
            // 
            // lbl_confirm_pswd
            // 
            this.lbl_confirm_pswd.AutoSize = true;
            this.lbl_confirm_pswd.Location = new System.Drawing.Point(135, 111);
            this.lbl_confirm_pswd.Name = "lbl_confirm_pswd";
            this.lbl_confirm_pswd.Size = new System.Drawing.Size(91, 13);
            this.lbl_confirm_pswd.TabIndex = 0;
            this.lbl_confirm_pswd.Text = "Confirm Password";
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.Location = new System.Drawing.Point(138, 127);
            this.txt_confirmPassword.MaxLength = 32;
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_confirmPassword.TabIndex = 5;
            this.txt_confirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_confirmPassword.UseSystemPasswordChar = true;
            this.txt_confirmPassword.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            this.txt_confirmPassword.Enter += new System.EventHandler(this.txt_confirmPassword_Enter);
            // 
            // InterfaceInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 205);
            this.Controls.Add(this.txt_confirmPassword);
            this.Controls.Add(this.lbl_confirm_pswd);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.cmd_signup);
            this.Controls.Add(this.lbl_pswd);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InterfaceInscription";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_pswd;
        private System.Windows.Forms.Button cmd_signup;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label lbl_confirm_pswd;
        private System.Windows.Forms.TextBox txt_confirmPassword;
    }
}

