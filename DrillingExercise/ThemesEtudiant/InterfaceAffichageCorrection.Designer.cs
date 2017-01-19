namespace ThemesEtudiant
{
    partial class InterfaceAffichageCorrection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_correction = new System.Windows.Forms.Label();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.rtxt_memo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_correction
            // 
            this.lbl_correction.AutoSize = true;
            this.lbl_correction.Location = new System.Drawing.Point(34, 22);
            this.lbl_correction.Name = "lbl_correction";
            this.lbl_correction.Size = new System.Drawing.Size(55, 13);
            this.lbl_correction.TabIndex = 0;
            this.lbl_correction.Text = "Correction";
            // 
            // lbl_answer
            // 
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Location = new System.Drawing.Point(34, 71);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(100, 13);
            this.lbl_answer.TabIndex = 1;
            this.lbl_answer.Text = "* la bonne réponse*";
            // 
            // rtxt_memo
            // 
            this.rtxt_memo.Location = new System.Drawing.Point(37, 122);
            this.rtxt_memo.Name = "rtxt_memo";
            this.rtxt_memo.Size = new System.Drawing.Size(219, 111);
            this.rtxt_memo.TabIndex = 3;
            this.rtxt_memo.Text = "";
            // 
            // InterfaceAffichageCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rtxt_memo);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.lbl_correction);
            this.Name = "InterfaceAffichageCorrection";
            this.Text = "Answer - Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_correction;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.RichTextBox rtxt_memo;
    }
}