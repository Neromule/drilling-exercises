namespace Connexion
{
    partial class InterfaceConnexion
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
            this.cmd_signin = new System.Windows.Forms.Button();
            this.cmd_signup = new System.Windows.Forms.Button();
            this.txt_pswd = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_pswd = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_signin
            // 
            this.cmd_signin.Location = new System.Drawing.Point(172, 185);
            this.cmd_signin.Name = "cmd_signin";
            this.cmd_signin.Size = new System.Drawing.Size(75, 23);
            this.cmd_signin.TabIndex = 11;
            this.cmd_signin.Text = "Sign in";
            this.cmd_signin.UseVisualStyleBackColor = true;
            // 
            // cmd_signup
            // 
            this.cmd_signup.Location = new System.Drawing.Point(37, 185);
            this.cmd_signup.Name = "cmd_signup";
            this.cmd_signup.Size = new System.Drawing.Size(75, 23);
            this.cmd_signup.TabIndex = 10;
            this.cmd_signup.Text = "Sign up";
            this.cmd_signup.UseVisualStyleBackColor = true;
            // 
            // txt_pswd
            // 
            this.txt_pswd.Location = new System.Drawing.Point(147, 111);
            this.txt_pswd.Name = "txt_pswd";
            this.txt_pswd.Size = new System.Drawing.Size(100, 20);
            this.txt_pswd.TabIndex = 9;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(147, 55);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(100, 20);
            this.txt_user.TabIndex = 8;
            // 
            // lbl_pswd
            // 
            this.lbl_pswd.AutoSize = true;
            this.lbl_pswd.Location = new System.Drawing.Point(52, 118);
            this.lbl_pswd.Name = "lbl_pswd";
            this.lbl_pswd.Size = new System.Drawing.Size(53, 13);
            this.lbl_pswd.TabIndex = 7;
            this.lbl_pswd.Text = "Password";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(52, 58);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(29, 13);
            this.lbl_user.TabIndex = 6;
            this.lbl_user.Text = "User";
            // 
            // InterfaceConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmd_signin);
            this.Controls.Add(this.cmd_signup);
            this.Controls.Add(this.txt_pswd);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_pswd);
            this.Controls.Add(this.lbl_user);
            this.Name = "InterfaceConnexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_signin;
        private System.Windows.Forms.Button cmd_signup;
        private System.Windows.Forms.TextBox txt_pswd;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_pswd;
        private System.Windows.Forms.Label lbl_user;
    }
}

