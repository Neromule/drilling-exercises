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
    public partial class InterfaceContactProfesseur : Form
    {
        public InterfaceContactProfesseur()
        {
            InitializeComponent();
        }

        private void InterfaceContactProfesseur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmd_return_Click(object sender, EventArgs e)
        {

        }
    }
}
