using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Etudiant
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
    }
}
