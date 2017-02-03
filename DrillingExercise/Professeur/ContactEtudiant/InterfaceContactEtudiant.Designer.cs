namespace Drilling
{
    partial class InterfaceContactEtudiant
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
            this.lbl_mail_teacher = new System.Windows.Forms.Label();
            this.lbl_name_teacher = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.cmd_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_mail_teacher
            // 
            this.lbl_mail_teacher.AutoSize = true;
            this.lbl_mail_teacher.Location = new System.Drawing.Point(84, 107);
            this.lbl_mail_teacher.Name = "lbl_mail_teacher";
            this.lbl_mail_teacher.Size = new System.Drawing.Size(120, 13);
            this.lbl_mail_teacher.TabIndex = 0;
            this.lbl_mail_teacher.Text = "*adresse mail de la prof*";
            this.lbl_mail_teacher.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_name_teacher
            // 
            this.lbl_name_teacher.AutoSize = true;
            this.lbl_name_teacher.Location = new System.Drawing.Point(78, 59);
            this.lbl_name_teacher.Name = "lbl_name_teacher";
            this.lbl_name_teacher.Size = new System.Drawing.Size(126, 13);
            this.lbl_name_teacher.TabIndex = 1;
            this.lbl_name_teacher.Text = "*nom et prenom delaprof*";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(110, 151);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(64, 13);
            this.lbl_phone.TabIndex = 2;
            this.lbl_phone.Text = "*num de tel*";
            // 
            // cmd_return
            // 
            this.cmd_return.Location = new System.Drawing.Point(32, 206);
            this.cmd_return.Name = "cmd_return";
            this.cmd_return.Size = new System.Drawing.Size(33, 33);
            this.cmd_return.TabIndex = 4;
            this.cmd_return.Text = "←";
            this.cmd_return.UseVisualStyleBackColor = true;
            this.cmd_return.Click += new System.EventHandler(this.cmd_return_Click);
            // 
            // InterfaceContactEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmd_return);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_name_teacher);
            this.Controls.Add(this.lbl_mail_teacher);
            this.Name = "InterfaceContactEtudiant";
            this.Text = "Contact - Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InterfaceContactEtudiant_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mail_teacher;
        private System.Windows.Forms.Label lbl_name_teacher;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Button cmd_return;
    }
}

