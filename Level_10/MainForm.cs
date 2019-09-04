using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Level_10
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		private void MainFormKeyPress(object sender, KeyPressEventArgs e)
		{
			Close();
		}
	}
}

