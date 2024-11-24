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
					label2.Text = seldep.name + ", " + seldep.manager;
					foreach (var empl in seldep.employees)
					{
						var item = new TreeNode();
						item.Tag = empl;
						item.Text = empl.name + ", " + empl.position;
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
				Name = dep.name,
				Text = dep.name
			};
			foreach (var subdep in dep.sub_deps)
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

		}

		private void ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			var selnode = treeView1.SelectedNode;
			if (selnode != null)
			{
				var seldep = selnode.Tag as Departament;
				if (seldep != null)
				{
					if (MessageBox.Show(this, "Remove " + seldep.name + " deparatment?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						if(myorg.RemoveDep(seldep))
						{
							MessageBox.Show(this, seldep.name + " deparatment sucsessfully removed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show(this, seldep.name + " deparatment not found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
	}
}
