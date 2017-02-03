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
    public partial class InterfaceEtudiant : Form
    {
        public InterfaceEtudiant()
        {
            InitializeComponent();
        }

        private void InterfaceEtudiant_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmd_contact_e_Click(object sender, EventArgs e)
        {
            Hide();
            new InterfaceContactEtudiant(this).ShowDialog();
        }

        private void cmd_themes_e_Click(object sender, EventArgs e)
        {
            Hide();
            new InterfaceThemesEtudiant(this).ShowDialog();
        }

        private void cmd_results_e_Click(object sender, EventArgs e)
        {
            Hide();
            new InterfaceResultatsEtudiant(this).ShowDialog();
        }

        private void InterfaceEtudiant_Load(object sender, EventArgs e)
        {

        }
    }
}
