using Etudiant;
using Inscription;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connexion
{
    public partial class InterfaceConnexion : Form
    {   
        public InterfaceConnexion()
        {
            InitializeComponent();
        }

        private void cmd_signin_Click(object sender, EventArgs e)
        {

            InterfaceEtudiant etud = new InterfaceEtudiant();
            etud.Show();
            etud.Activate();
            this.Hide();
            


        }

        private void cmd_signup_Click(object sender, EventArgs e)
        {
            new InterfaceInscription().Show();

        }
    }
}
