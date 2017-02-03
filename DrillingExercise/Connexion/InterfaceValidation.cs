using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Components;
using System.Text.RegularExpressions;

namespace Drilling
{
    public partial class InterfaceValidation : Form
    {
        private string validationCode;
        private User user;
        private int userCreateStatus;
        private InterfaceInscription parent;
        private InterfaceConnexion grandParent;

        public InterfaceValidation(string code, User u, InterfaceInscription p, InterfaceConnexion g)
        {
            InitializeComponent();        
            validationCode = code;
            user = u;
            parent = p;
            grandParent = g;
            Location = new System.Drawing.Point(parent.Left + (parent.Width - Width) / 2, parent.Top + (parent.Height - Height) / 2);

            Win.SendMessage(txt_validation.Handle, 0x1501, 1, "Enter validation code here");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
            grandParent.Show();
            parent.Show();
        }

        private void txt_validation_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            if(txt_validation.Text == validationCode)
            {
                BDD bdd = new BDD();
                userCreateStatus = bdd.AddUser(user);

                if(userCreateStatus == 0)
                {
                    MessageBox.Show("Your account has been activated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    grandParent.Show();
                }
                else if(userCreateStatus == 1)
                {
                    MessageBox.Show("There is already an account with this email", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
                else
                    MessageBox.Show("Server cannot be reached", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("The entered activation code is incorrect", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txt_validation_KeyUp(object sender, KeyEventArgs e)
        {
            string c = Clipboard.GetText();

            if ((e.KeyData == (Keys.Control | Keys.V)) && c.Length <= 6 && Regex.IsMatch(c, @"^\d+$"))
                (sender as TextBox).Paste();        
        }

        private void lbl_retry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool mailSent = Mail.Send(user.Mail,
                     "[INSCRIPTION] Validation de votre compte",
                     "<!DOCTYPE html><html><head><meta charset = 'utf-8'/></head ><body>" +
                     "<b>Bonjour <FONT color = 'blue'> " + user.FirstName + "</FONT ></b>" +
                     "<br><br>Nous avons bien reçu votre demande d'inscription." +
                     "<br>Voici le code à inscrire pour valider votre compte :<br><FONT size='6pt'> " + validationCode + "</FONT >" +
                     "<br><br><i>Drilling Exercices" +
                     "<br><img src='https://i37.servimg.com/u/f37/15/56/50/31/logo-i10.png' alt='LOGO IUT INFO'></body></html >");

            if (mailSent)
                MessageBox.Show("Mail sent successfully","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Mail delivery failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_validation_TextChanged(object sender, EventArgs e)
        {
            if (txt_validation.Text.Length == 6)
                btn_validate.Enabled = true;
            else
                btn_validate.Enabled = false;
        }
    }
}
