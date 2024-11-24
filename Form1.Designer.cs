namespace Organisation
{
	partial class OrganisationForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			label1 = new Label();
			button4 = new Button();
			treeView1 = new TreeView();
			contextMenuStrip1 = new ContextMenuStrip(components);
			toolStripMenuItem1 = new ToolStripMenuItem();
			toolStripMenuItem2 = new ToolStripMenuItem();
			newEmployeerToolStripMenuItem = new ToolStripMenuItem();
			label2 = new Label();
			treeView2 = new TreeView();
			contextMenuStrip2 = new ContextMenuStrip(components);
			removeEmplToolStripMenuItem = new ToolStripMenuItem();
			contextMenuStrip1.SuspendLayout();
			contextMenuStrip2.SuspendLayout();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(12, 12);
			button1.Name = "button1";
			button1.Size = new Size(136, 29);
			button1.TabIndex = 0;
			button1.Text = "Input Test Data";
			button1.UseVisualStyleBackColor = true;
			button1.Click += InputTestData;
			// 
			// button2
			// 
			button2.Location = new Point(154, 12);
			button2.Name = "button2";
			button2.Size = new Size(139, 29);
			button2.TabIndex = 1;
			button2.Text = "Load from File";
			button2.UseVisualStyleBackColor = true;
			button2.Click += Button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(299, 12);
			button3.Name = "button3";
			button3.Size = new Size(94, 29);
			button3.TabIndex = 2;
			button3.Text = "Save to File";
			button3.UseVisualStyleBackColor = true;
			button3.Click += Button3_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(13, 54);
			label1.Name = "label1";
			label1.Size = new Size(106, 20);
			label1.TabIndex = 4;
			label1.Text = "Departaments:";
			// 
			// button4
			// 
			button4.Location = new Point(399, 12);
			button4.Name = "button4";
			button4.Size = new Size(94, 29);
			button4.TabIndex = 5;
			button4.Text = "Refresh";
			button4.UseVisualStyleBackColor = true;
			button4.Click += Button4_Click;
			// 
			// treeView1
			// 
			treeView1.ContextMenuStrip = contextMenuStrip1;
			treeView1.Location = new Point(18, 83);
			treeView1.Name = "treeView1";
			treeView1.Size = new Size(151, 355);
			treeView1.TabIndex = 6;
			treeView1.AfterSelect += TreeView1_AfterSelect;
			treeView1.DragDrop += TreeView1_DragDrop;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new Size(20, 20);
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, newEmployeerToolStripMenuItem });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(181, 76);
			contextMenuStrip1.Opening += ContextMenuStrip1_Opening;
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(180, 24);
			toolStripMenuItem1.Text = "new dep";
			toolStripMenuItem1.Click += ToolStripMenuItem1_Click;
			// 
			// toolStripMenuItem2
			// 
			toolStripMenuItem2.Name = "toolStripMenuItem2";
			toolStripMenuItem2.Size = new Size(180, 24);
			toolStripMenuItem2.Text = "remove dep";
			toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
			// 
			// newEmployeerToolStripMenuItem
			// 
			newEmployeerToolStripMenuItem.Name = "newEmployeerToolStripMenuItem";
			newEmployeerToolStripMenuItem.Size = new Size(180, 24);
			newEmployeerToolStripMenuItem.Text = "new employeer";
			newEmployeerToolStripMenuItem.Click += NewEmployeerToolStripMenuItem_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(198, 54);
			label2.Name = "label2";
			label2.Size = new Size(0, 20);
			label2.TabIndex = 8;
			// 
			// treeView2
			// 
			treeView2.ContextMenuStrip = contextMenuStrip2;
			treeView2.Location = new Point(198, 83);
			treeView2.Name = "treeView2";
			treeView2.Size = new Size(294, 355);
			treeView2.TabIndex = 9;
			// 
			// contextMenuStrip2
			// 
			contextMenuStrip2.ImageScalingSize = new Size(20, 20);
			contextMenuStrip2.Items.AddRange(new ToolStripItem[] { removeEmplToolStripMenuItem });
			contextMenuStrip2.Name = "contextMenuStrip2";
			contextMenuStrip2.Size = new Size(167, 28);
			// 
			// removeEmplToolStripMenuItem
			// 
			removeEmplToolStripMenuItem.Name = "removeEmplToolStripMenuItem";
			removeEmplToolStripMenuItem.Size = new Size(166, 24);
			removeEmplToolStripMenuItem.Text = "remove empl";
			removeEmplToolStripMenuItem.Click += removeEmplToolStripMenuItem_Click;
			// 
			// OrganisationForm
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(504, 451);
			Controls.Add(treeView2);
			Controls.Add(label2);
			Controls.Add(treeView1);
			Controls.Add(button4);
			Controls.Add(label1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "OrganisationForm";
			Text = "Organisation";
			contextMenuStrip1.ResumeLayout(false);
			contextMenuStrip2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button button2;
		private Button button3;
		private Label label1;
		private Button button4;
		private TreeView treeView1;
		private Label label2;
		private TreeView treeView2;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem toolStripMenuItem2;
		private ToolStripMenuItem newEmployeerToolStripMenuItem;
		private ContextMenuStrip contextMenuStrip2;
		private ToolStripMenuItem removeEmplToolStripMenuItem;
	}
}
