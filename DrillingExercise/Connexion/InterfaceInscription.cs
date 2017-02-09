using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Drilling
{
    public partial class InterfaceInscription : Form
    {
        private InterfaceConnexion parent;

        private ToolTip toolTip = new ToolTip();

        private bool firstNameOk = false;
        private bool lastNameOk = false;
        private bool mailOk = false;
        private bool passwordOk = false;
        private bool mailSent = false;

        private string validationCode = string.Empty;
        private string password = string.Empty;

        public InterfaceInscription(InterfaceConnexion p)
        {
            InitializeComponent();
            Icon = Icons.UserAddIcon;
            txt_mail.SelectionStart = 0;
            cmd_signup.Image = Icons.SignUp;
            parent = p;
        }

        #region Buttons Events
        private void cmd_signup_Click(object sender, EventArgs e)
        {
            //Création de l'objet utilisateur
            //Hashage du mot de passe
            using (MD5 md5Hash = MD5.Create())
                password = GetMd5Hash(md5Hash, txt_password.Text);

            User u = new Student(txt_firstName.Text, txt_lastName.Text, txt_mail.Text, password);

            //Check si l'utilisateur n'existe pas déjà
            Cursor.Current = Cursors.WaitCursor;
            int existingUserResult = BDD.ExistingUser(u.Mail);

            if(existingUserResult == 0)
            {
                //* * * Calcul du code de validation * * *
                //Si le code n'est pas encore généré
                if (validationCode == string.Empty)
                {
                    Random rnd = new Random();
                    for (int i = 0; i < 6; i++)
                        validationCode += rnd.Next(0, 10).ToString();
                }

                mailSent = Mail.Send(u.Mail,
                         "[INSCRIPTION] Validation de votre compte",
                         "<!DOCTYPE html><html><head><meta charset = 'utf-8'/></head ><body>" +
                         "<b>Bonjour <FONT color = 'blue'> " + u.FirstName + "</FONT ></b>" +
                         "<br><br>Nous avons bien reçu votre demande d'inscription." +
                         "<br>Voici le code à inscrire pour valider votre compte :<br><FONT size='6pt'> " + validationCode + "</FONT >" +
                         "<br><br><i>Drilling Exercices" +
                         "<br><img src='https://i37.servimg.com/u/f37/15/56/50/31/logo-i10.png' alt='LOGO IUT INFO'></body></html >");

                Cursor.Current = Cursors.Default;

                //Si le mail a bien été envoyé
                if (mailSent)
                {
                    parent.Hide();
                    Hide();
                    new InterfaceValidation(validationCode, u, this, parent).ShowDialog();
                }
                else
                    MessageBox.Show("Mail delivery failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(existingUserResult == 1)
                MessageBox.Show("There is already an account with this email", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Server cannot be reached", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Cursor.Current = Cursors.Default;






        }

        private void cmd_return_Click(object sender, EventArgs e)
        {
            MessageBox.Show("firstNameOk : " + firstNameOk + Environment.NewLine
                         + "lastNameOk : " + lastNameOk + Environment.NewLine
                         + "mailOk : " + mailOk + Environment.NewLine
                         + "passwordOk : " + passwordOk + Environment.NewLine);
        }
        #endregion

        /*----------*/

        #region TextBox_TextChanged Events
        private void txt_firstName_TextChanged(object sender, EventArgs e)
        {
            if (txt_firstName.Text.Length > 0)
                firstNameOk = true;
            else
                firstNameOk = false;

            CheckFields();
        }

        private void txt_lastName_TextChanged(object sender, EventArgs e)
        {
            if (txt_lastName.Text.Length > 0)
                lastNameOk = true;
            else
                lastNameOk = false;

            CheckFields();
        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {
            if (txt_mail.Text.Contains("@") && txt_mail.Text.Contains("u-picardie.fr"))
                mailOk = true;
            else
                mailOk = false;

            CheckFields();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            string password = txt_password.Text;

            if ((password.Length >= 6 && password.Length <= 32) && password == txt_confirmPassword.Text)
                passwordOk = true;
            else
                passwordOk = false;

            CheckFields();
        }

        private void CheckFields()
        {
            if (firstNameOk && lastNameOk && mailOk && passwordOk)
                cmd_signup.Enabled = true;
            else
                cmd_signup.Enabled = false;
                          
        }
        #endregion

        #region TextBox_Enter Events for ToolTips
        private void txt_mail_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            toolTip.Show("E-mail address must be in the UPJV domain", t, t.Size.Width + 10, 0, 3000);
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            toolTip.Show("A valid password must be between 6 and 32 characters", t, t.Size.Width + 10, 0, 3000);
        }

        private void txt_confirmPassword_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            toolTip.Show("The two passwords must match", t, t.Size.Width + 10, 0, 2000);
        }
        #endregion

        #region MD5 Hashing Method
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        #endregion
    }
}
