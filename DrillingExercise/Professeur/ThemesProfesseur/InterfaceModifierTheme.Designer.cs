namespace Drilling
{
    partial class InterfaceModifierTheme
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.opt_2 = new System.Windows.Forms.RadioButton();
            this.opt_1 = new System.Windows.Forms.RadioButton();
            this.opt_3 = new System.Windows.Forms.RadioButton();
            this.lbl_q1 = new System.Windows.Forms.Label();
            this.lbl_q2 = new System.Windows.Forms.Label();
            this.lbl_q3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name_theme = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmd_return = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.5F));
            this.tableLayoutPanel1.Controls.Add(this.opt_2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.opt_1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.opt_3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_q1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_q2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_q3, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // opt_2
            // 
            this.opt_2.AutoSize = true;
            this.opt_2.Location = new System.Drawing.Point(3, 36);
            this.opt_2.Name = "opt_2";
            this.opt_2.Size = new System.Drawing.Size(14, 13);
            this.opt_2.TabIndex = 2;
            this.opt_2.TabStop = true;
            this.opt_2.UseVisualStyleBackColor = true;
            // 
            // opt_1
            // 
            this.opt_1.AutoSize = true;
            this.opt_1.Location = new System.Drawing.Point(3, 3);
            this.opt_1.Name = "opt_1";
            this.opt_1.Size = new System.Drawing.Size(14, 13);
            this.opt_1.TabIndex = 0;
            this.opt_1.TabStop = true;
            this.opt_1.UseVisualStyleBackColor = true;
            // 
            // opt_3
            // 
            this.opt_3.AutoSize = true;
            this.opt_3.Location = new System.Drawing.Point(3, 69);
            this.opt_3.Name = "opt_3";
            this.opt_3.Size = new System.Drawing.Size(14, 13);
            this.opt_3.TabIndex = 1;
            this.opt_3.TabStop = true;
            this.opt_3.UseVisualStyleBackColor = true;
            // 
            // lbl_q1
            // 
            this.lbl_q1.AutoSize = true;
            this.lbl_q1.Location = new System.Drawing.Point(60, 0);
            this.lbl_q1.Name = "lbl_q1";
            this.lbl_q1.Size = new System.Drawing.Size(66, 13);
            this.lbl_q1.TabIndex = 3;
            this.lbl_q1.Text = "*Question 1*";
            // 
            // lbl_q2
            // 
            this.lbl_q2.AutoSize = true;
            this.lbl_q2.Location = new System.Drawing.Point(60, 33);
            this.lbl_q2.Name = "lbl_q2";
            this.lbl_q2.Size = new System.Drawing.Size(66, 13);
            this.lbl_q2.TabIndex = 4;
            this.lbl_q2.Text = "*Question 2*";
            // 
            // lbl_q3
            // 
            this.lbl_q3.AutoSize = true;
            this.lbl_q3.Location = new System.Drawing.Point(60, 66);
            this.lbl_q3.Name = "lbl_q3";
            this.lbl_q3.Size = new System.Drawing.Size(66, 13);
            this.lbl_q3.TabIndex = 5;
            this.lbl_q3.Text = "*Question 3*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Theme :";
            // 
            // txt_name_theme
            // 
            this.txt_name_theme.Location = new System.Drawing.Point(121, 27);
            this.txt_name_theme.Name = "txt_name_theme";
            this.txt_name_theme.Size = new System.Drawing.Size(100, 20);
            this.txt_name_theme.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete a question";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add a question";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmd_return
            // 
            this.cmd_return.Location = new System.Drawing.Point(34, 217);
            this.cmd_return.Name = "cmd_return";
            this.cmd_return.Size = new System.Drawing.Size(33, 33);
            this.cmd_return.TabIndex = 4;
            this.cmd_return.Text = "←";
            this.cmd_return.UseVisualStyleBackColor = true;
            this.cmd_return.Click += new System.EventHandler(this.cmd_return_Click);
            // 
            // InterfaceModifierTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmd_return);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_name_theme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InterfaceModifierTheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify a theme - Teacher";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton opt_2;
        private System.Windows.Forms.RadioButton opt_1;
        private System.Windows.Forms.RadioButton opt_3;
        private System.Windows.Forms.Label lbl_q1;
        private System.Windows.Forms.Label lbl_q2;
        private System.Windows.Forms.Label lbl_q3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name_theme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmd_return;
    }
}