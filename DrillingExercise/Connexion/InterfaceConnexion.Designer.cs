namespace Drilling
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
            this.txt_pswd = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_pswd = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.grp_connect = new System.Windows.Forms.GroupBox();
            this.lbl_register = new System.Windows.Forms.LinkLabel();
            this.lbl_lostPassword = new System.Windows.Forms.LinkLabel();
            this.grp_connect.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_signin
            // 
            this.cmd_signin.Location = new System.Drawing.Point(116, 80);
            this.cmd_signin.Name = "cmd_signin";
            this.cmd_signin.Size = new System.Drawing.Size(73, 23);
            this.cmd_signin.TabIndex = 11;
            this.cmd_signin.Text = "Log in";
            this.cmd_signin.UseVisualStyleBackColor = true;
            this.cmd_signin.Click += new System.EventHandler(this.cmd_signin_Click);
            // 
            // txt_pswd
            // 
            this.txt_pswd.Location = new System.Drawing.Point(65, 54);
            this.txt_pswd.Name = "txt_pswd";
            this.txt_pswd.Size = new System.Drawing.Size(180, 20);
            this.txt_pswd.TabIndex = 9;
            this.txt_pswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pswd.UseSystemPasswordChar = true;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(65, 28);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(180, 20);
            this.txt_user.TabIndex = 8;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_pswd
            // 
            this.lbl_pswd.AutoSize = true;
            this.lbl_pswd.Location = new System.Drawing.Point(6, 57);
            this.lbl_pswd.Name = "lbl_pswd";
            this.lbl_pswd.Size = new System.Drawing.Size(53, 13);
            this.lbl_pswd.TabIndex = 7;
            this.lbl_pswd.Text = "Password";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(6, 31);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(29, 13);
            this.lbl_user.TabIndex = 6;
            this.lbl_user.Text = "User";
            // 
            // grp_connect
            // 
            this.grp_connect.Controls.Add(this.lbl_user);
            this.grp_connect.Controls.Add(this.cmd_signin);
            this.grp_connect.Controls.Add(this.txt_user);
            this.grp_connect.Controls.Add(this.lbl_pswd);
            this.grp_connect.Controls.Add(this.txt_pswd);
            this.grp_connect.Location = new System.Drawing.Point(12, 12);
            this.grp_connect.Name = "grp_connect";
            this.grp_connect.Size = new System.Drawing.Size(251, 109);
            this.grp_connect.TabIndex = 12;
            this.grp_connect.TabStop = false;
            this.grp_connect.Text = "Connection";
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.Location = new System.Drawing.Point(18, 126);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(46, 13);
            this.lbl_register.TabIndex = 12;
            this.lbl_register.TabStop = true;
            this.lbl_register.Text = "Register";
            this.lbl_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_lostPassword
            // 
            this.lbl_lostPassword.AutoSize = true;
            this.lbl_lostPassword.Location = new System.Drawing.Point(191, 124);
            this.lbl_lostPassword.Name = "lbl_lostPassword";
            this.lbl_lostPassword.Size = new System.Drawing.Size(72, 13);
            this.lbl_lostPassword.TabIndex = 13;
            this.lbl_lostPassword.TabStop = true;
            this.lbl_lostPassword.Text = "Password lost";
            // 
            // InterfaceConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 148);
            this.Controls.Add(this.lbl_lostPassword);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.grp_connect);
            this.Name = "InterfaceConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drilling Exercices";
            this.grp_connect.ResumeLayout(false);
            this.grp_connect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_signin;
        private System.Windows.Forms.TextBox txt_pswd;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_pswd;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.GroupBox grp_connect;
        private System.Windows.Forms.LinkLabel lbl_register;
        private System.Windows.Forms.LinkLabel lbl_lostPassword;
    }
}

