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


		public void Add_Dep(string root)
		{
			label1.Text = root;
			Text = "Add new departament";
			label3.Text = "Manager";
		}

		public void Add_Emp(string root)
		{
			label1.Text = root;
			Text = "Add new employeer";
			label3.Text = "Position";
		}

		public string Get_Name() { return textBox1.Text; }

		public string Get_Manager() { return textBox2.Text; }

		public string Get_Position() { return textBox2.Text; }
	}
}
