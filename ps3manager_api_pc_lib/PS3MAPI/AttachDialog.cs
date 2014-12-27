// ******************************************************************
//
//	If this code works it was written by:
//		Malcolm
//		MamSoft / Manniff Computers
//		© 2008 - 2008...
//
//	if not, I have no idea who wrote it.
//
// ******************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PS3ManagerAPI
{
    public partial class AttachDialog : Form
	{
        public AttachDialog()
		{
			InitializeComponent();
		}

        public AttachDialog(PS3ManagerAPI.PS3MAPI MyPS3MAPI)
            : this()
        {
            comboBox1.Items.Clear();
            MyPS3MAPI.processes_pid = MyPS3MAPI.Process.GetPidProcesses();
            foreach (uint pid in MyPS3MAPI.processes_pid)
            {
                if (pid != 0) comboBox1.Items.Add(MyPS3MAPI.Process.GetName(pid));
                else break;
            }
            comboBox1.SelectedIndex = 0;
        }
	}
}
