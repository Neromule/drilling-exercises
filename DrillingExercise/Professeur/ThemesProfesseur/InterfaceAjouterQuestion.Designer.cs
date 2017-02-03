namespace Drilling
{
    partial class InterfaceAjouterQuestion
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
            this.lbl_question = new System.Windows.Forms.Label();
            this.opt_1 = new System.Windows.Forms.RadioButton();
            this.opt_2 = new System.Windows.Forms.RadioButton();
            this.opt_3 = new System.Windows.Forms.RadioButton();
            this.txt_question = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_reponse_3 = new System.Windows.Forms.Label();
            this.lbl_reponse_2 = new System.Windows.Forms.Label();
            this.lbl_reponse_1 = new System.Windows.Forms.Label();
            this.cmd_add_question = new System.Windows.Forms.Button();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.opt_qcm = new System.Windows.Forms.RadioButton();
            this.opt_gapfield = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_poss_4 = new System.Windows.Forms.TextBox();
            this.txt_poss_3 = new System.Windows.Forms.TextBox();
            this.txt_poss_2 = new System.Windows.Forms.TextBox();
            this.txt_poss_1 = new System.Windows.Forms.TextBox();
            this.cmd_return = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(37, 36);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(55, 13);
            this.lbl_question.TabIndex = 0;
            this.lbl_question.Text = "Question :";
            this.lbl_question.Click += new System.EventHandler(this.label1_Click);
            // 
            // opt_1
            // 
            this.opt_1.AutoSize = true;
            this.opt_1.Location = new System.Drawing.Point(3, 3);
            this.opt_1.Name = "opt_1";
            this.opt_1.Size = new System.Drawing.Size(14, 13);
            this.opt_1.TabIndex = 1;
            this.opt_1.TabStop = true;
            this.opt_1.UseVisualStyleBackColor = true;
            // 
            // opt_2
            // 
            this.opt_2.AutoSize = true;
            this.opt_2.Location = new System.Drawing.Point(3, 37);
            this.opt_2.Name = "opt_2";
            this.opt_2.Size = new System.Drawing.Size(14, 13);
            this.opt_2.TabIndex = 2;
            this.opt_2.TabStop = true;
            this.opt_2.UseVisualStyleBackColor = true;
            // 
            // opt_3
            // 
            this.opt_3.AutoSize = true;
            this.opt_3.Location = new System.Drawing.Point(3, 68);
            this.opt_3.Name = "opt_3";
            this.opt_3.Size = new System.Drawing.Size(14, 13);
            this.opt_3.TabIndex = 3;
            this.opt_3.TabStop = true;
            this.opt_3.UseVisualStyleBackColor = true;
            // 
            // txt_question
            // 
            this.txt_question.Location = new System.Drawing.Point(98, 33);
            this.txt_question.Name = "txt_question";
            this.txt_question.Size = new System.Drawing.Size(132, 20);
            this.txt_question.TabIndex = 4;
            this.txt_question.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_reponse_3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_reponse_2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.opt_3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.opt_2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.opt_1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_reponse_1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 111);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.30769F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.69231F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lbl_reponse_3
            // 
            this.lbl_reponse_3.AutoSize = true;
            this.lbl_reponse_3.Location = new System.Drawing.Point(103, 65);
            this.lbl_reponse_3.Name = "lbl_reponse_3";
            this.lbl_reponse_3.Size = new System.Drawing.Size(36, 13);
            this.lbl_reponse_3.TabIndex = 6;
            this.lbl_reponse_3.Text = "*rep3*";
            // 
            // lbl_reponse_2
            // 
            this.lbl_reponse_2.AutoSize = true;
            this.lbl_reponse_2.Location = new System.Drawing.Point(103, 34);
            this.lbl_reponse_2.Name = "lbl_reponse_2";
            this.lbl_reponse_2.Size = new System.Drawing.Size(36, 13);
            this.lbl_reponse_2.TabIndex = 5;
            this.lbl_reponse_2.Text = "*rep2*";
            // 
            // lbl_reponse_1
            // 
            this.lbl_reponse_1.AutoSize = true;
            this.lbl_reponse_1.Location = new System.Drawing.Point(103, 0);
            this.lbl_reponse_1.Name = "lbl_reponse_1";
            this.lbl_reponse_1.Size = new System.Drawing.Size(39, 13);
            this.lbl_reponse_1.TabIndex = 4;
            this.lbl_reponse_1.Text = "*rep 1*";
            // 
            // cmd_add_question
            // 
            this.cmd_add_question.Location = new System.Drawing.Point(155, 222);
            this.cmd_add_question.Name = "cmd_add_question";
            this.cmd_add_question.Size = new System.Drawing.Size(75, 23);
            this.cmd_add_question.TabIndex = 6;
            this.cmd_add_question.Text = "Add";
            this.cmd_add_question.UseVisualStyleBackColor = true;
            // 
            // lbl_answer
            // 
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Location = new System.Drawing.Point(30, 81);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(53, 13);
            this.lbl_answer.TabIndex = 4;
            this.lbl_answer.Text = "Answer(s)";
            this.lbl_answer.Click += new System.EventHandler(this.label2_Click);
            // 
            // opt_qcm
            // 
            this.opt_qcm.AutoSize = true;
            this.opt_qcm.Location = new System.Drawing.Point(107, 79);
            this.opt_qcm.Name = "opt_qcm";
            this.opt_qcm.Size = new System.Drawing.Size(49, 17);
            this.opt_qcm.TabIndex = 7;
            this.opt_qcm.TabStop = true;
            this.opt_qcm.Text = "QCM";
            this.opt_qcm.UseVisualStyleBackColor = true;
            // 
            // opt_gapfield
            // 
            this.opt_gapfield.AutoSize = true;
            this.opt_gapfield.Location = new System.Drawing.Point(285, 81);
            this.opt_gapfield.Name = "opt_gapfield";
            this.opt_gapfield.Size = new System.Drawing.Size(67, 17);
            this.opt_gapfield.TabIndex = 8;
            this.opt_gapfield.TabStop = true;
            this.opt_gapfield.Text = "GapField";
            this.opt_gapfield.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txt_poss_4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_poss_3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_poss_2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_poss_1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(285, 114);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // txt_poss_4
            // 
            this.txt_poss_4.Location = new System.Drawing.Point(103, 53);
            this.txt_poss_4.Name = "txt_poss_4";
            this.txt_poss_4.Size = new System.Drawing.Size(94, 20);
            this.txt_poss_4.TabIndex = 13;
            // 
            // txt_poss_3
            // 
            this.txt_poss_3.Location = new System.Drawing.Point(3, 53);
            this.txt_poss_3.Name = "txt_poss_3";
            this.txt_poss_3.Size = new System.Drawing.Size(94, 20);
            this.txt_poss_3.TabIndex = 12;
            // 
            // txt_poss_2
            // 
            this.txt_poss_2.Location = new System.Drawing.Point(103, 3);
            this.txt_poss_2.Name = "txt_poss_2";
            this.txt_poss_2.Size = new System.Drawing.Size(94, 20);
            this.txt_poss_2.TabIndex = 11;
            // 
            // txt_poss_1
            // 
            this.txt_poss_1.Location = new System.Drawing.Point(3, 3);
            this.txt_poss_1.Name = "txt_poss_1";
            this.txt_poss_1.Size = new System.Drawing.Size(94, 20);
            this.txt_poss_1.TabIndex = 10;
            // 
            // cmd_return
            // 
            this.cmd_return.Location = new System.Drawing.Point(30, 217);
            this.cmd_return.Name = "cmd_return";
            this.cmd_return.Size = new System.Drawing.Size(33, 33);
            this.cmd_return.TabIndex = 10;
            this.cmd_return.Text = "←";
            this.cmd_return.UseVisualStyleBackColor = true;
            // 
            // InterfaceAjouterQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 262);
            this.Controls.Add(this.cmd_return);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.opt_gapfield);
            this.Controls.Add(this.opt_qcm);
            this.Controls.Add(this.cmd_add_question);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.lbl_question);
            this.Name = "InterfaceAjouterQuestion";
            this.Text = "Add a question -Teacher";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.RadioButton opt_1;
        private System.Windows.Forms.RadioButton opt_2;
        private System.Windows.Forms.RadioButton opt_3;
        private System.Windows.Forms.TextBox txt_question;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cmd_add_question;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.RadioButton opt_qcm;
        private System.Windows.Forms.RadioButton opt_gapfield;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_poss_4;
        private System.Windows.Forms.TextBox txt_poss_3;
        private System.Windows.Forms.TextBox txt_poss_2;
        private System.Windows.Forms.TextBox txt_poss_1;
        private System.Windows.Forms.Label lbl_reponse_3;
        private System.Windows.Forms.Label lbl_reponse_2;
        private System.Windows.Forms.Label lbl_reponse_1;
        private System.Windows.Forms.Button cmd_return;
    }
}