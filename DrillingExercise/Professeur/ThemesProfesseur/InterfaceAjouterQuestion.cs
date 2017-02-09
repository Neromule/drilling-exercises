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
    public partial class InterfaceAjouterQuestion : Form
    {
        Form m_parent;

        public InterfaceAjouterQuestion(Form p)
        {
            InitializeComponent();
            m_parent = p;
        }

        private void opt_gapfield_CheckedChanged(object sender, EventArgs e)
        {
            tableLP_GapFill.Visible = true;
            tableLP_GapFill.Location = tableLP_QCM.Location;
            tableLP_QCM.Visible = false;
        }

        private void opt_qcm_CheckedChanged(object sender, EventArgs e)
        {
            tableLP_QCM.Visible = true;
            tableLP_GapFill.Visible = false;
        }

        private void cmd_return_Click(object sender, EventArgs e)
        {
            Close();
            m_parent.Show();
        }

        private void InterfaceAjouterQuestion_Load(object sender, EventArgs e)
        {
            tableLP_GapFill.Visible = false;
            tableLP_QCM.Visible = true;
        }
    }
}
