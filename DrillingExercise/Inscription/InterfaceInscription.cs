using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscription
{
    public partial class InterfaceInscription : Form
    {
        public InterfaceInscription()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmd_signup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code d'inscription", "entrer le code:",0);
        }
    }
}
