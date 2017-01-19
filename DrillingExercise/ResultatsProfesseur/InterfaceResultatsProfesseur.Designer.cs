namespace ResultatsProfesseur
{
    partial class InterfaceResultatsProfesseur
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
            this.opt_by_theme = new System.Windows.Forms.RadioButton();
            this.opt_by_mark = new System.Windows.Forms.RadioButton();
            this.opt_by_name = new System.Windows.Forms.RadioButton();
            this.lbl_results = new System.Windows.Forms.Label();
            this.dgd_results = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgd_results)).BeginInit();
            this.SuspendLayout();
            // 
            // opt_by_theme
            // 
            this.opt_by_theme.AutoSize = true;
            this.opt_by_theme.Location = new System.Drawing.Point(32, 36);
            this.opt_by_theme.Name = "opt_by_theme";
            this.opt_by_theme.Size = new System.Drawing.Size(72, 17);
            this.opt_by_theme.TabIndex = 0;
            this.opt_by_theme.TabStop = true;
            this.opt_by_theme.Text = "by Theme";
            this.opt_by_theme.UseVisualStyleBackColor = true;
            // 
            // opt_by_mark
            // 
            this.opt_by_mark.AutoSize = true;
            this.opt_by_mark.Location = new System.Drawing.Point(116, 36);
            this.opt_by_mark.Name = "opt_by_mark";
            this.opt_by_mark.Size = new System.Drawing.Size(63, 17);
            this.opt_by_mark.TabIndex = 1;
            this.opt_by_mark.TabStop = true;
            this.opt_by_mark.Text = "by Mark";
            this.opt_by_mark.UseVisualStyleBackColor = true;
            // 
            // opt_by_name
            // 
            this.opt_by_name.AutoSize = true;
            this.opt_by_name.Location = new System.Drawing.Point(207, 36);
            this.opt_by_name.Name = "opt_by_name";
            this.opt_by_name.Size = new System.Drawing.Size(67, 17);
            this.opt_by_name.TabIndex = 2;
            this.opt_by_name.TabStop = true;
            this.opt_by_name.Text = "by Name";
            this.opt_by_name.UseVisualStyleBackColor = true;
            // 
            // lbl_results
            // 
            this.lbl_results.AutoSize = true;
            this.lbl_results.Location = new System.Drawing.Point(29, 12);
            this.lbl_results.Name = "lbl_results";
            this.lbl_results.Size = new System.Drawing.Size(45, 13);
            this.lbl_results.TabIndex = 3;
            this.lbl_results.Text = "Results ";
            // 
            // dgd_results
            // 
            this.dgd_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgd_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgd_results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgd_results.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgd_results.Location = new System.Drawing.Point(0, 59);
            this.dgd_results.Name = "dgd_results";
            this.dgd_results.Size = new System.Drawing.Size(688, 203);
            this.dgd_results.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Last Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "First Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nickname";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mark /20";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mark /xx";
            this.Column6.Name = "Column6";
            // 
            // InterfaceResultatsProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 262);
            this.Controls.Add(this.dgd_results);
            this.Controls.Add(this.lbl_results);
            this.Controls.Add(this.opt_by_name);
            this.Controls.Add(this.opt_by_mark);
            this.Controls.Add(this.opt_by_theme);
            this.Name = "InterfaceResultatsProfesseur";
            this.Text = "Results - Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.dgd_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton opt_by_theme;
        private System.Windows.Forms.RadioButton opt_by_mark;
        private System.Windows.Forms.RadioButton opt_by_name;
        private System.Windows.Forms.Label lbl_results;
        private System.Windows.Forms.DataGridView dgd_results;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

