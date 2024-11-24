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
			var newdep = new Departament("Great Music", "Mozart");
			myorg.departamentList.Add(newdep);
			var newsub = new Departament("Rock-n-Roll", "Elvis");
			newdep.AddSubDep(newsub);
			newsub.AddEmpl(new Empl("John Lennon", "solo guitar"));
			newsub.AddEmpl(new Empl("Paul MacCartney", "bass"));

			newsub = new Departament("Grang", "Cobain");
			newdep.AddSubDep(newsub);
			newsub.AddEmpl(new Empl("Krist Novoselic", "solo guitar"));
			newsub.AddEmpl(new Empl("Chad Channing", "bass"));


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
	}
}
