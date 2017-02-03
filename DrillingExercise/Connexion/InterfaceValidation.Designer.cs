namespace Drilling
{
    partial class InterfaceValidation
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
            this.grp_validation = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_retry = new System.Windows.Forms.LinkLabel();
            this.btn_validate = new System.Windows.Forms.Button();
            this.txt_validation = new System.Windows.Forms.TextBox();
            this.grp_validation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_validation
            // 
            this.grp_validation.Controls.Add(this.btn_cancel);
            this.grp_validation.Controls.Add(this.lbl_retry);
            this.grp_validation.Controls.Add(this.btn_validate);
            this.grp_validation.Controls.Add(this.txt_validation);
            this.grp_validation.Location = new System.Drawing.Point(8, 6);
            this.grp_validation.Name = "grp_validation";
            this.grp_validation.Size = new System.Drawing.Size(212, 102);
            this.grp_validation.TabIndex = 0;
            this.grp_validation.TabStop = false;
            this.grp_validation.Text = "Validating your account";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(23, 53);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_retry
            // 
            this.lbl_retry.AutoSize = true;
            this.lbl_retry.Location = new System.Drawing.Point(63, 86);
            this.lbl_retry.Name = "lbl_retry";
            this.lbl_retry.Size = new System.Drawing.Size(143, 13);
            this.lbl_retry.TabIndex = 2;
            this.lbl_retry.TabStop = true;
            this.lbl_retry.Text = "Mail not receved ? Resend it";
            this.lbl_retry.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_retry_LinkClicked);
            // 
            // btn_validate
            // 
            this.btn_validate.Enabled = false;
            this.btn_validate.Location = new System.Drawing.Point(104, 53);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(79, 23);
            this.btn_validate.TabIndex = 1;
            this.btn_validate.Text = "Validate";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // txt_validation
            // 
            this.txt_validation.Location = new System.Drawing.Point(23, 27);
            this.txt_validation.MaxLength = 6;
            this.txt_validation.Name = "txt_validation";
            this.txt_validation.Size = new System.Drawing.Size(160, 20);
            this.txt_validation.TabIndex = 0;
            this.txt_validation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_validation.TextChanged += new System.EventHandler(this.txt_validation_TextChanged);
            this.txt_validation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_validation_KeyPress);
            this.txt_validation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_validation_KeyUp);
            // 
            // InterfaceValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 117);
            this.ControlBox = false;
            this.Controls.Add(this.grp_validation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfaceValidation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Drilling Exercice";
            this.grp_validation.ResumeLayout(false);
            this.grp_validation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_validation;
        private System.Windows.Forms.LinkLabel lbl_retry;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.TextBox txt_validation;
        private System.Windows.Forms.Button btn_cancel;
    }
}