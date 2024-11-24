using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organisation
{
	public partial class New_dep : Form
	{
		public New_dep()
		{
			InitializeComponent();
		}

		public void Set_Root(string root)
		{
			label1.Text = root;
		}

		public string Get_Name() { return textBox1.Text; }

		public string Get_Manager() { return textBox2.Text; }
	}
}
