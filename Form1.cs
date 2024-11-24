namespace Organisation
{
	public partial class OrganisationForm : Form
	{
		Organisation myorg;
		public OrganisationForm()
		{
			InitializeComponent();
			myorg = new Organisation();

		}

		private void InputTestData(object sender, EventArgs e)
		{
			var newdep = new Departament("Executive Management", "J. Oppen");
			myorg.departamentList.Add(newdep);
			var newsub = new Departament("Strategic Planning", "N. Marshmann");
            var newsublv2 = new Departament("Market Analysis", "P. Elvis");
            var newsublv3 = new Departament("Legal Compliance", "S. Hoshimachi");

            newdep.AddSubDep(newsub); // Dept 1
			newsub.AddEmpl(new Empl("K. Lin", "Senior Analyst"));
			newsub.AddEmpl(new Empl("S. Palin", "Junior Analyst"));
            newsub.AddEmpl(new Empl("J. McCain", "Junior Analyst"));
            newsub.AddSubDep(newsublv2);
            newsublv2.AddEmpl(new Empl("A. Yang", "Head of Marketing"));
            newsublv2.AddEmpl(new Empl("B. Sanders", "Senior Analyst"));
            newsublv2.AddEmpl(new Empl("J. Kerry", "Junior Analyst"));
            newsublv2 = new Departament("Competitive Intelligence", "J. Vance");
			newsub.AddSubDep(newsublv2);
            newsublv2.AddEmpl(new Empl("I. Jon", "Head of Intelligence"));
            newsublv2.AddEmpl(new Empl("J. Taylor", "Office Cat"));
            newsublv2.AddEmpl(new Empl("B. Ariandel", "Senior Researcher"));
            newsublv2.AddSubDep(newsublv3);
            newsublv3.AddEmpl(new Empl("K. Makise", "Board Liaison"));
            newsublv3.AddEmpl(new Empl("R. Ocelot", "Head of Compliance"));
            newsublv3.AddEmpl(new Empl("K. Attano", "Compliance Officer"));
            newsublv3.AddEmpl(new Empl("E. Caldwin", "Compliance Officer"));
            newsublv3.AddEmpl(new Empl("J. Caldwin", "Compliance Officer"));
            newsublv3.AddEmpl(new Empl("V. Sokolov", "Senior Compliance Officer"));
            newsublv3 = new Departament("Board Relations", "J. Casablancas");
            newsublv2.AddSubDep(newsublv3);
            newsublv3.AddEmpl(new Empl("A. Shevtsov", "Corporate Relations Manager"));
            newsublv3.AddEmpl(new Empl("A. Sikorskiy", "Corporate Relations Manager"));
            newsublv3.AddEmpl(new Empl("M. Sudin", "Board Secretary"));
            newsublv3 = new Departament("Risk Management", "J. F. Kennedy");
            newsublv2.AddSubDep(newsublv3);
            newsublv3.AddEmpl(new Empl("V. Ramaswami", "Risk Manager"));
            newsublv3.AddEmpl(new Empl("R. C. Mann", "Risk Analyst"));
            newsublv3.AddEmpl(new Empl("N. Haley", "Risk Analyst"));
            newsublv3.AddEmpl(new Empl("A. Gore", "Risk Manager"));
            newsublv3.AddEmpl(new Empl("J. Libermann", "Risk Manager"));
            newsublv3.AddEmpl(new Empl("D. Cheney", "Risk Manager"));
            newsublv2 = new Departament("Financial Risks", "R. F. Kennedy");
            newsublv3.AddSubDep(newsublv2);
            newsublv2.AddEmpl(new Empl("M. Frog", "Financial Risk Analyst"));
            newsublv2.AddEmpl(new Empl("M. Edwards", "Financial Risk Analyst"));
            newsublv2.AddEmpl(new Empl("T. Donald", "Credit Analyst"));
            newsublv2 = new Departament("Operational Risks", "R. F. Kennedy Jr.");
            newsublv3.AddSubDep(newsublv2);
            newsublv2.AddEmpl(new Empl("M. Carey", "Operational Risk Manager"));
            newsublv2.AddEmpl(new Empl("A. Bune", "Process Analyst"));
            newsublv2.AddEmpl(new Empl("S. Uistare", "Process Analyst"));


            newdep = new Departament("Human Resources", "R. Heimer"); // Dept 2
            myorg.departamentList.Add(newdep);
            newsub = new Departament("Recruitment & Talent Acquisition", "H. Maho");
            newdep.AddSubDep(newsub);
            newsub.AddEmpl(new Empl("V. Zhir", "Recruitment Specialist"));
            newsub.AddEmpl(new Empl("A. Naval", "Recruitment Specialist"));
            newsub.AddEmpl(new Empl("S. Miron", "Hiring Coordinator"));
            newsub.AddEmpl(new Empl("G. Zyuga", "Talent Acquisition Manager"));
            newsub.AddEmpl(new Empl("V. Dava", "Talent Acquisition Manager"));
            newsublv2 = new Departament("Training & Development", "M. Kirk");
            newsub.AddSubDep(newsublv2);
            newsublv2.AddEmpl(new Empl("H. Tonfa", "Training Manager"));
            newsublv2.AddEmpl(new Empl("E. Obukhov", "Training Manager"));
            newsublv2.AddEmpl(new Empl("T. Rakhmetullin", "Development Specialist"));
            newsublv2.AddEmpl(new Empl("N. Panchak", "Training Manager"));
            newsublv3 = new Departament("Compensation & Benefits", "C. T. Race");
            newsublv2.AddSubDep(newsublv3);
            newsublv3.AddEmpl(new Empl("S. G. Spamton", "Compensation Analyst"));
            newsublv3.AddEmpl(new Empl("I. Na", "Benefits Coordinator"));
            newsublv3.AddEmpl(new Empl("A. Morgenshtern", "Payroll Specialist"));	
            newsublv2 = new Departament("Employee Relations", "V. J. Link");
            newsub.AddSubDep(newsublv2);
            newsublv2.AddEmpl(new Empl("V. Saveliev", "Employee Relations Specialist"));
            newsublv2.AddEmpl(new Empl("O. Mongol", "Employee Relations Specialist"));
            newsublv2.AddEmpl(new Empl("D. Simon", "Employee Relations Specialist"));
            newsublv3 = new Departament("Diversity & Inclusion", "F. D. Wokisme");
            newsublv2.AddSubDep(newsublv3);
            newsublv3.AddEmpl(new Empl("J. R. Biden", "CEO of Woke"));
            newsublv3.AddEmpl(new Empl("H. Biden", "Deep State Analyst"));
            newsublv3.AddEmpl(new Empl("Dr. J. Biden", "Deep State Analyst"));
            newsublv3.AddEmpl(new Empl("K. Marx", "Marxism Expert"));
            newsublv3.AddEmpl(new Empl("D. State", "Deep State Expert"));
            newsublv3 = new Departament("Conflict Resolution", "J. Casablancas");
            newsublv2.AddSubDep(newsublv3);
            newsublv3.AddEmpl(new Empl("P. Daft", "Mediation Specialist"));
            newsublv3.AddEmpl(new Empl("F. Kafe", "Workplace Counselor"));
            newsublv3.AddEmpl(new Empl("S. Kafe", "Workplace Counselor"));




            DoRefreshDeps();

		}

		private void DoRefreshDeps()
		{
			treeView1.Nodes.Clear();
			foreach (var dep in myorg.departamentList)
			{
				var node = FillNode(dep);
				treeView1.Nodes.Add(node);
			}
			treeView2.Nodes.Clear();
			label2.Text = "";

			treeView1.ExpandAll();
			treeView1.Select();

		}

		private void DoRefreshList()
		{
			treeView2.Nodes.Clear();
			label2.Text = "";
			var selnode = treeView1.SelectedNode;
			if (selnode != null)
			{
				var seldep = selnode.Tag as Departament;
				if (seldep != null)
				{
					label2.Text = seldep.Name + ", " + seldep.Manager;
					foreach (var empl in seldep.Employees)
					{
						var item = new TreeNode();
						item.Tag = empl;
						item.Text = empl.Name + ", " + empl.Position;
						treeView2.Nodes.Add(item);
					}
				}
			}

		}

		private static TreeNode FillNode(Departament dep)
		{
			TreeNode node = new()
			{
				Tag = dep,
				Name = dep.Name,
				Text = dep.Name
			};
			foreach (var subdep in dep.Sub_deps)
			{
				var subnode = FillNode(subdep);
				node.Nodes.Add(subnode);
			}
			return node;

		}

		private void Button4_Click(object sender, EventArgs e)
		{
			DoRefreshDeps();
		}

		private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			DoRefreshList();
		}

		private void TreeView1_DragDrop(object sender, DragEventArgs e)
		{

		}

		private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}

		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var selnode = treeView1.SelectedNode;
			if (selnode != null)
			{
				var seldep = selnode.Tag as Departament;
				if (seldep != null)
				{
					New_dep dialog = new New_dep();
					dialog.Add_Dep(seldep.Name);
					var result = dialog.ShowDialog();
					if (result == DialogResult.OK)
					{
						var name = dialog.Get_Name();
						var manager = dialog.Get_Manager();
						seldep.AddSubDep(new Departament(name, manager));
						DoRefreshDeps();
					}
				}
			}
		}

		private void ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			var selnode = treeView1.SelectedNode;
			if (selnode != null)
			{
				var seldep = selnode.Tag as Departament;
				if (seldep != null)
				{
					if (MessageBox.Show(this, "Remove " + seldep.Name + " deparatment?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						if (myorg.RemoveDep(seldep))
						{
							MessageBox.Show(this, seldep.Name + " deparatment sucsessfully removed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show(this, seldep.Name + " deparatment not found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						//need to remove dep from myorg
					}
				}
				DoRefreshDeps();

			}
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			myorg.SaveToFile("save.xml");
		}

		private void NewEmployeerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var selnode = treeView1.SelectedNode;
			if (selnode != null)
			{
				var seldep = selnode.Tag as Departament;
				if (seldep != null)
				{
					New_dep dialog = new New_dep();
					dialog.Add_Emp(seldep.Name);
					var result = dialog.ShowDialog();
					if (result == DialogResult.OK)
					{
						var name = dialog.Get_Name();
						var position = dialog.Get_Position();
						seldep.AddEmpl(new Empl(name, position));
						DoRefreshList();
					}
				}
			}
		}

		private void ContextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}

		private void removeEmplToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var selnode2 = treeView2.SelectedNode;
			var selnode1 = treeView1.SelectedNode;
			if (selnode2 != null && selnode1 != null)
			{
				var selempl = selnode2.Tag as Empl;
				var seldep = selnode1.Tag as Departament;
				if (selempl != null && seldep != null)
				{
					if (MessageBox.Show(this, "Remove " + selempl.Name + " employeer?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						if (seldep.RemoveEmpl(selempl))
						{
							DoRefreshList();
							MessageBox.Show(this, selempl.Name + " employeer sucsessfully removed from " + seldep.Name, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show(this, selempl.Name + " employeer not found in " + seldep.Name, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						//need to remove dep from myorg
					}
				}
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			myorg.LoadFromFile("save.xml");
			DoRefreshDeps();
		}
	}
}
