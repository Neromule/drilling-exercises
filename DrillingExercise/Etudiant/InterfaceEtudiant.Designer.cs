namespace Etudiant
{
    partial class InterfaceEtudiant
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
            this.cmd_contact_e = new System.Windows.Forms.Button();
            this.cmd_results_e = new System.Windows.Forms.Button();
            this.cmd_themes_e = new System.Windows.Forms.Button();
            this.lbl_name_student = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_contact_e
            // 
            this.cmd_contact_e.Location = new System.Drawing.Point(188, 128);
            this.cmd_contact_e.Name = "cmd_contact_e";
            this.cmd_contact_e.Size = new System.Drawing.Size(75, 66);
            this.cmd_contact_e.TabIndex = 7;
            this.cmd_contact_e.Text = "Contact";
            this.cmd_contact_e.UseVisualStyleBackColor = true;
            // 
            // cmd_results_e
            // 
            this.cmd_results_e.Location = new System.Drawing.Point(107, 128);
            this.cmd_results_e.Name = "cmd_results_e";
            this.cmd_results_e.Size = new System.Drawing.Size(75, 66);
            this.cmd_results_e.TabIndex = 6;
            this.cmd_results_e.Text = "Results";
            this.cmd_results_e.UseVisualStyleBackColor = true;
            // 
            // cmd_themes_e
            // 
            this.cmd_themes_e.Location = new System.Drawing.Point(26, 128);
            this.cmd_themes_e.Name = "cmd_themes_e";
            this.cmd_themes_e.Size = new System.Drawing.Size(75, 66);
            this.cmd_themes_e.TabIndex = 5;
            this.cmd_themes_e.Text = "Themes";
            this.cmd_themes_e.UseVisualStyleBackColor = true;
            // 
            // lbl_name_student
            // 
            this.lbl_name_student.AutoSize = true;
            this.lbl_name_student.Location = new System.Drawing.Point(84, 69);
            this.lbl_name_student.Name = "lbl_name_student";
            this.lbl_name_student.Size = new System.Drawing.Size(135, 13);
            this.lbl_name_student.TabIndex = 4;
            this.lbl_name_student.Text = "*Nom et prenom de l\'eleve*";
            // 
            // InterfaceEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmd_contact_e);
            this.Controls.Add(this.cmd_results_e);
            this.Controls.Add(this.cmd_themes_e);
            this.Controls.Add(this.lbl_name_student);
            this.Name = "InterfaceEtudiant";
            this.Text = "Homepage - Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InterfaceEtudiant_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_contact_e;
        private System.Windows.Forms.Button cmd_results_e;
        private System.Windows.Forms.Button cmd_themes_e;
        private System.Windows.Forms.Label lbl_name_student;
    }
}

