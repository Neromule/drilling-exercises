namespace ContactProfesseur
{
    partial class InterfaceContactProfesseur
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_LastName,
            this.Column_FirstName,
            this.Column_Nickname,
            this.Column_email});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column_LastName
            // 
            this.Column_LastName.HeaderText = "Last Name";
            this.Column_LastName.Name = "Column_LastName";
            // 
            // Column_FirstName
            // 
            this.Column_FirstName.HeaderText = "First Name";
            this.Column_FirstName.Name = "Column_FirstName";
            // 
            // Column_Nickname
            // 
            this.Column_Nickname.HeaderText = "Nickname";
            this.Column_Nickname.Name = "Column_Nickname";
            // 
            // Column_email
            // 
            this.Column_email.HeaderText = "Email";
            this.Column_email.Name = "Column_email";
            // 
            // cmd_return
            // 
            this.cmd_return.Location = new System.Drawing.Point(12, 268);
            this.cmd_return.Name = "cmd_return";
            this.cmd_return.Size = new System.Drawing.Size(33, 33);
            this.cmd_return.TabIndex = 3;
            this.cmd_return.Text = "←";
            this.cmd_return.UseVisualStyleBackColor = true;
            // 
            // InterfaceContactProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 333);
            this.Controls.Add(this.cmd_return);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InterfaceContactProfesseur";
            this.Text = "Contact - Teacher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InterfaceContactProfesseur_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_email;
        private System.Windows.Forms.Button cmd_return;
    }
}

