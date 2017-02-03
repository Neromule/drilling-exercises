using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drilling
{
    partial class InterfaceResultatsEtudiant : Form
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
            this.dgd_results_e = new System.Windows.Forms.DataGridView();
            this.Column_themes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgd_results_e)).BeginInit();
            this.SuspendLayout();
            // 
            // dgd_results_e
            // 
            this.dgd_results_e.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgd_results_e.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgd_results_e.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_themes,
            this.Column_marks});
            this.dgd_results_e.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgd_results_e.Location = new System.Drawing.Point(0, 0);
            this.dgd_results_e.Name = "dgd_results_e";
            this.dgd_results_e.Size = new System.Drawing.Size(284, 189);
            this.dgd_results_e.TabIndex = 4;
            // 
            // Column_themes
            // 
            this.Column_themes.HeaderText = "Themes";
            this.Column_themes.Name = "Column_themes";
            // 
            // Column_marks
            // 
            this.Column_marks.HeaderText = "Marks";
            this.Column_marks.Name = "Column_marks";
            // 
            // cmd_return
            // 
            this.cmd_return.Location = new System.Drawing.Point(12, 207);
            this.cmd_return.Name = "cmd_return";
            this.cmd_return.Size = new System.Drawing.Size(33, 33);
            this.cmd_return.TabIndex = 5;
            this.cmd_return.Text = "←";
            this.cmd_return.UseVisualStyleBackColor = true;
            this.cmd_return.Click += new System.EventHandler(this.cmd_return_Click);
            // 
            // InterfaceResultatsEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmd_return);
            this.Controls.Add(this.dgd_results_e);
            this.Name = "InterfaceResultatsEtudiant";
            this.Text = "Results - Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InterfaceResultatsEtudiant_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgd_results_e)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgd_results_e;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_themes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_marks;
        private System.Windows.Forms.Button cmd_return;
    }
}

