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
    public partial class InterfaceProfesseur : Form
    {
        public InterfaceProfesseur()
        {
            InitializeComponent();
        }

        private void InterfaceProfesseur_Load(object sender, EventArgs e)
        {

        }

        private void InterfaceProfesseur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmd_contact_p_Click(object sender, EventArgs e)
        {
            //new InterfaceContactProfesseur().Show();
        }

        private void cmd_results_p_Click(object sender, EventArgs e)
        {
            new InterfaceResultatsProfesseur().Show();
            this.Hide();
        }

        private void cmd_themes_p_Click(object sender, EventArgs e)
        {
            new InterfaceThemesProfesseur().Show();
            this.Hide();
        }
    }
}
