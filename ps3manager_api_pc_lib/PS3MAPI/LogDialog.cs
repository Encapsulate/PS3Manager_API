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
	public partial class LogDialog : Form
	{
		public LogDialog()
		{
			InitializeComponent();
		}

        public LogDialog(String Log)
            : this()
        {
            tB_Log.Text = Log;
        }


	}
}
