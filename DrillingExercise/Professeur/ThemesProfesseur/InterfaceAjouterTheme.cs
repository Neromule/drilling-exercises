using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drilling;

namespace Drilling
{
    public partial class InterfaceAjouterTheme : Form
    {
        Form m_parent;

        public InterfaceAjouterTheme(Form p)
        {
            InitializeComponent();
            m_parent = p;
        }

        private void cmd_ok_Click(object sender, EventArgs e)
        {
            // Ajout d'un titre au theme
            /*string nametheme;
            Theme theme = new Theme();
            nametheme = txt_add_theme.Text;

            if (bdd.Title == nametheme)
            {
                MessageBox.Show("This theme already exist, please choose another name for your theme");
            }
            else if(nametheme == null)
            {
                MessageBox.Show("Please enter a name to your theme");
            }
            else
            {
                theme.Title = nametheme;
                Close();
                m_parent.Show();
            }
            */
            
        }

        private void cmd_return_Click(object sender, EventArgs e)
        {
            Close();
            m_parent.Show();
        }
    }
}
