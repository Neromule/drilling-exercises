namespace Drilling
{
    partial class InterfaceAjouterTheme
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
            this.lbl_name_theme = new System.Windows.Forms.Label();
            this.txt_add_theme = new System.Windows.Forms.TextBox();
            this.cmd_ok = new System.Windows.Forms.Button();
            this.cmd_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name_theme
            // 
            this.lbl_name_theme.AutoSize = true;
            this.lbl_name_theme.Location = new System.Drawing.Point(36, 59);
            this.lbl_name_theme.Name = "lbl_name_theme";
            this.lbl_name_theme.Size = new System.Drawing.Size(76, 13);
            this.lbl_name_theme.TabIndex = 0;
            this.lbl_name_theme.Text = "Theme\'s name";
            // 
            // txt_add_theme
            // 
            this.txt_add_theme.Location = new System.Drawing.Point(133, 56);
            this.txt_add_theme.Name = "txt_add_theme";
            this.txt_add_theme.Size = new System.Drawing.Size(100, 20);
            this.txt_add_theme.TabIndex = 1;
            // 
            // cmd_ok
            // 
            this.cmd_ok.Location = new System.Drawing.Point(158, 111);
            this.cmd_ok.Name = "cmd_ok";
            this.cmd_ok.Size = new System.Drawing.Size(75, 23);
            this.cmd_ok.TabIndex = 2;
            this.cmd_ok.Text = "OK";
            this.cmd_ok.UseVisualStyleBackColor = true;
            this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
            // 
            // cmd_return
            // 
            this.cmd_return.Location = new System.Drawing.Point(28, 111);
            this.cmd_return.Name = "cmd_return";
            this.cmd_return.Size = new System.Drawing.Size(33, 33);
            this.cmd_return.TabIndex = 4;
            this.cmd_return.Text = "←";
            this.cmd_return.UseVisualStyleBackColor = true;
            this.cmd_return.Click += new System.EventHandler(this.cmd_return_Click);
            // 
            // InterfaceAjouterTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 174);
            this.Controls.Add(this.cmd_return);
            this.Controls.Add(this.cmd_ok);
            this.Controls.Add(this.txt_add_theme);
            this.Controls.Add(this.lbl_name_theme);
            this.Name = "InterfaceAjouterTheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a theme - Teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name_theme;
        private System.Windows.Forms.TextBox txt_add_theme;
        private System.Windows.Forms.Button cmd_ok;
        private System.Windows.Forms.Button cmd_return;
    }
}