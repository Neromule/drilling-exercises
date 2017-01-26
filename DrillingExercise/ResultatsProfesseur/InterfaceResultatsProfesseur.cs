using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultatsProfesseur
{
    public partial class InterfaceResultatsProfesseur : Form
    {
        public InterfaceResultatsProfesseur()
        {
            InitializeComponent();
        }

        private void InterfaceResultatsProfesseur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
