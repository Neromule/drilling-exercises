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
    public partial class InterfaceThemesProfesseur : Form
    {
        Form m_parent;

        public InterfaceThemesProfesseur(Form p)
        {
            InitializeComponent();
            m_parent = p;
        }

        private void InterfaceThemesProfesseur_Load(object sender, EventArgs e)
        {
            cmd_delete_items.Visible = false;
            cmd_cancel_delete.Visible = false;
        }

        private void cmd_return_Click(object sender, EventArgs e)
        {
            Close();
            m_parent.Show();
        }

        private void cmd_theme1_Click(object sender, EventArgs e)
        {
            Hide();
            new InterfaceModifierTheme(this).ShowDialog();
        }

        private void cmd_add_theme_Click(object sender, EventArgs e)
        {
            new InterfaceAjouterTheme(this).ShowDialog();
        }

        private void cmd_delete_theme_Click(object sender, EventArgs e)
        {
            cmd_delete_items.Visible = true;
            cmd_cancel_delete.Visible = true;
            cmd_delete_theme.Enabled = false;
            cmd_add_theme.Enabled = false;
        }

        private void cmd_cancel_delete_Click(object sender, EventArgs e)
        {
            cmd_delete_items.Visible = false;
            cmd_cancel_delete.Visible = false;
            cmd_add_theme.Enabled = true;
            cmd_delete_theme.Enabled = true;
        }
    }
}
