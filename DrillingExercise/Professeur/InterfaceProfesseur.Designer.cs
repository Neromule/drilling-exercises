namespace Drilling
{
    partial class InterfaceProfesseur
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
            this.lbl_name_teacher = new System.Windows.Forms.Label();
            this.cmd_themes_p = new System.Windows.Forms.Button();
            this.cmd_results_p = new System.Windows.Forms.Button();
            this.cmd_contact_p = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name_teacher
            // 
            this.lbl_name_teacher.AutoSize = true;
            this.lbl_name_teacher.Location = new System.Drawing.Point(81, 51);
            this.lbl_name_teacher.Name = "lbl_name_teacher";
            this.lbl_name_teacher.Size = new System.Drawing.Size(123, 13);
            this.lbl_name_teacher.TabIndex = 0;
            this.lbl_name_teacher.Text = "*Nom et prenom du prof*";
            // 
            // cmd_themes_p
            // 
            this.cmd_themes_p.Location = new System.Drawing.Point(18, 110);
            this.cmd_themes_p.Name = "cmd_themes_p";
            this.cmd_themes_p.Size = new System.Drawing.Size(75, 66);
            this.cmd_themes_p.TabIndex = 1;
            this.cmd_themes_p.Text = "Themes";
            this.cmd_themes_p.UseVisualStyleBackColor = true;
            this.cmd_themes_p.Click += new System.EventHandler(this.cmd_themes_p_Click);
            // 
            // cmd_results_p
            // 
            this.cmd_results_p.Location = new System.Drawing.Point(104, 110);
            this.cmd_results_p.Name = "cmd_results_p";
            this.cmd_results_p.Size = new System.Drawing.Size(75, 66);
            this.cmd_results_p.TabIndex = 2;
            this.cmd_results_p.Text = "Results";
            this.cmd_results_p.UseVisualStyleBackColor = true;
            this.cmd_results_p.Click += new System.EventHandler(this.cmd_results_p_Click);
            // 
            // cmd_contact_p
            // 
            this.cmd_contact_p.Location = new System.Drawing.Point(185, 110);
            this.cmd_contact_p.Name = "cmd_contact_p";
            this.cmd_contact_p.Size = new System.Drawing.Size(75, 66);
            this.cmd_contact_p.TabIndex = 3;
            this.cmd_contact_p.Text = "Contact";
            this.cmd_contact_p.UseVisualStyleBackColor = true;
            this.cmd_contact_p.Click += new System.EventHandler(this.cmd_contact_p_Click);
            // 
            // InterfaceProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmd_contact_p);
            this.Controls.Add(this.cmd_results_p);
            this.Controls.Add(this.cmd_themes_p);
            this.Controls.Add(this.lbl_name_teacher);
            this.Name = "InterfaceProfesseur";
            this.Text = "Homepage - Teacher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InterfaceProfesseur_FormClosed);
            this.Load += new System.EventHandler(this.InterfaceProfesseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name_teacher;
        private System.Windows.Forms.Button cmd_themes_p;
        private System.Windows.Forms.Button cmd_results_p;
        private System.Windows.Forms.Button cmd_contact_p;
    }
}

