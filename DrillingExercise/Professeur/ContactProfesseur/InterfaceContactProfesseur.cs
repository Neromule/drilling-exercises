﻿using System;
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
        InterfaceProfesseur m_parent;

        public InterfaceContactProfesseur(InterfaceProfesseur p)
        {
            InitializeComponent();
            m_parent = p;
        }

        private void cmd_return_Click(object sender, EventArgs e)
        {
            Close();
            m_parent.Show();
        }
    }
}
