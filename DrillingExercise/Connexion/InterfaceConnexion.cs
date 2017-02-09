using Etudiant;
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
    public partial class InterfaceConnexion : Form
    {   
        public InterfaceConnexion()
        {
            InitializeComponent();
            Icon = Icons.LogoDrilling;
        }

        private void cmd_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InterfaceProfesseur().ShowDialog();   
            this.Close();      
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new InterfaceInscription(this).ShowDialog();
        }

        private void lbl_lostPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //todo
        }
    }
}
