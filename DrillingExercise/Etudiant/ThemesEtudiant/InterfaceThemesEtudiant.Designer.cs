namespace Drilling
{
    partial class InterfaceThemesEtudiant
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmd_theme_1 = new System.Windows.Forms.Button();
            this.cmd_theme_2 = new System.Windows.Forms.Button();
            this.cmd_theme_3 = new System.Windows.Forms.Button();
            this.cmd_theme_4 = new System.Windows.Forms.Button();
            this.cmd_return = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cmd_theme_1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmd_theme_2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmd_theme_3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmd_theme_4, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmd_theme_1
            // 
            this.cmd_theme_1.Location = new System.Drawing.Point(3, 3);
            this.cmd_theme_1.Name = "cmd_theme_1";
            this.cmd_theme_1.Size = new System.Drawing.Size(75, 23);
            this.cmd_theme_1.TabIndex = 0;
            this.cmd_theme_1.Text = "theme1";
            this.cmd_theme_1.UseVisualStyleBackColor = true;
            // 
            // cmd_theme_2
            // 
            this.cmd_theme_2.Location = new System.Drawing.Point(103, 3);
            this.cmd_theme_2.Name = "cmd_theme_2";
            this.cmd_theme_2.Size = new System.Drawing.Size(75, 23);
            this.cmd_theme_2.TabIndex = 1;
            this.cmd_theme_2.Text = "theme2";
            this.cmd_theme_2.UseVisualStyleBackColor = true;
            // 
            // cmd_theme_3
            // 
            this.cmd_theme_3.Location = new System.Drawing.Point(3, 53);
            this.cmd_theme_3.Name = "cmd_theme_3";
            this.cmd_theme_3.Size = new System.Drawing.Size(75, 23);
            this.cmd_theme_3.TabIndex = 2;
            this.cmd_theme_3.Text = "theme3";
            this.cmd_theme_3.UseVisualStyleBackColor = true;
            // 
            // cmd_theme_4
            // 
            this.cmd_theme_4.Location = new System.Drawing.Point(103, 53);
            this.cmd_theme_4.Name = "cmd_theme_4";
            this.cmd_theme_4.Size = new System.Drawing.Size(75, 23);
            this.cmd_theme_4.TabIndex = 3;
            this.cmd_theme_4.Text = "theme4";
            this.cmd_theme_4.UseVisualStyleBackColor = true;
            // 
            // cmd_return
            // 
            this.cmd_return.Location = new System.Drawing.Point(33, 198);
            this.cmd_return.Name = "cmd_return";
            this.cmd_return.Size = new System.Drawing.Size(33, 33);
            this.cmd_return.TabIndex = 4;
            this.cmd_return.Text = "←";
            this.cmd_return.UseVisualStyleBackColor = true;
            this.cmd_return.Click += new System.EventHandler(this.cmd_return_Click);
            // 
            // InterfaceThemesEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmd_return);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InterfaceThemesEtudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Themes - Student";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cmd_theme_1;
        private System.Windows.Forms.Button cmd_theme_2;
        private System.Windows.Forms.Button cmd_theme_3;
        private System.Windows.Forms.Button cmd_theme_4;
        private System.Windows.Forms.Button cmd_return;
    }
}

