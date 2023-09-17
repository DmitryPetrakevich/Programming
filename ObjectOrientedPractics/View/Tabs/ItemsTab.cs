using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
	public class ItemsTab : UserControl
	{
		public ItemsTab()
		{
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.ItemsListBox = new ListBox();
			this.ItemsLabel = new Label();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.AddButton = new Button();
			this.RemoveButton = new Button();
			this.splitContainer1 = new SplitContainer();
			this.IdTextBox = new TextBox();
			this.SelectedItemLabel = new Label();
			this.IdLabel = new Label();
			this.NameLabel = new Label();
			this.NameTextBox = new TextBox();
			this.DescriptionTextBox = new TextBox();
			this.DescriptionLabel = new Label();
			this.CostLabel = new Label();
			this.CostTextBox = new TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			((ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			base.SuspendLayout();
			this.ItemsListBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.ItemsListBox.FormattingEnabled = true;
			this.ItemsListBox.IntegralHeight = false;
			this.ItemsListBox.Location = new Point(3, 21);
			this.ItemsListBox.Name = "ItemsListBox";
			this.ItemsListBox.Size = new Size(294, 434);
			this.ItemsListBox.TabIndex = 0;
			this.ItemsLabel.AutoSize = true;
			this.ItemsLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.ItemsLabel.Location = new Point(3, 5);
			this.ItemsLabel.Name = "ItemsLabel";
			this.ItemsLabel.Size = new Size(37, 13);
			this.ItemsLabel.TabIndex = 1;
			this.ItemsLabel.Text = "Items";
			this.tableLayoutPanel1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
			this.tableLayoutPanel1.Controls.Add(this.AddButton, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.RemoveButton, 1, 0);
			this.tableLayoutPanel1.Location = new Point(3, 458);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new Size(294, 41);
			this.tableLayoutPanel1.TabIndex = 2;
			this.AddButton.Dock = DockStyle.Fill;
			this.AddButton.Location = new Point(3, 3);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new Size(92, 35);
			this.AddButton.TabIndex = 0;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Dock = DockStyle.Fill;
			this.RemoveButton.Location = new Point(101, 3);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new Size(92, 35);
			this.RemoveButton.TabIndex = 1;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.splitContainer1.Dock = DockStyle.Fill;
			this.splitContainer1.Location = new Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.ItemsLabel);
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Panel1.Controls.Add(this.ItemsListBox);
			this.splitContainer1.Panel1MinSize = 200;
			this.splitContainer1.Panel2.BackColor = Color.White;
			this.splitContainer1.Panel2.Controls.Add(this.CostLabel);
			this.splitContainer1.Panel2.Controls.Add(this.CostTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.DescriptionTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.DescriptionLabel);
			this.splitContainer1.Panel2.Controls.Add(this.NameTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.NameLabel);
			this.splitContainer1.Panel2.Controls.Add(this.IdLabel);
			this.splitContainer1.Panel2.Controls.Add(this.SelectedItemLabel);
			this.splitContainer1.Panel2.Controls.Add(this.IdTextBox);
			this.splitContainer1.Panel2MinSize = 200;
			this.splitContainer1.Size = new Size(733, 502);
			this.splitContainer1.SplitterDistance = 300;
			this.splitContainer1.TabIndex = 3;
			this.IdTextBox.Location = new Point(45, 31);
			this.IdTextBox.Name = "IdTextBox";
			this.IdTextBox.Size = new Size(122, 20);
			this.IdTextBox.TabIndex = 0;
			this.SelectedItemLabel.AutoSize = true;
			this.SelectedItemLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.SelectedItemLabel.Location = new Point(3, 5);
			this.SelectedItemLabel.Name = "SelectedItemLabel";
			this.SelectedItemLabel.Size = new Size(85, 13);
			this.SelectedItemLabel.TabIndex = 1;
			this.SelectedItemLabel.Text = "Selected Item";
			this.IdLabel.AutoSize = true;
			this.IdLabel.Location = new Point(3, 34);
			this.IdLabel.Name = "IdLabel";
			this.IdLabel.Size = new Size(21, 13);
			this.IdLabel.TabIndex = 2;
			this.IdLabel.Text = "ID:";
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new Point(3, 85);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new Size(38, 13);
			this.NameLabel.TabIndex = 3;
			this.NameLabel.Text = "Name:";
			this.NameTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.NameTextBox.Location = new Point(6, 101);
			this.NameTextBox.Multiline = true;
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new Size(420, 83);
			this.NameTextBox.TabIndex = 4;
			this.DescriptionTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.DescriptionTextBox.Location = new Point(6, 208);
			this.DescriptionTextBox.Multiline = true;
			this.DescriptionTextBox.Name = "DescriptionTextBox";
			this.DescriptionTextBox.Size = new Size(420, 152);
			this.DescriptionTextBox.TabIndex = 6;
			this.DescriptionLabel.AutoSize = true;
			this.DescriptionLabel.Location = new Point(3, 192);
			this.DescriptionLabel.Name = "DescriptionLabel";
			this.DescriptionLabel.Size = new Size(63, 13);
			this.DescriptionLabel.TabIndex = 5;
			this.DescriptionLabel.Text = "Description:";
			this.CostLabel.AutoSize = true;
			this.CostLabel.Location = new Point(3, 60);
			this.CostLabel.Name = "CostLabel";
			this.CostLabel.Size = new Size(31, 13);
			this.CostLabel.TabIndex = 8;
			this.CostLabel.Text = "Cost:";
			this.CostTextBox.Location = new Point(45, 57);
			this.CostTextBox.Name = "CostTextBox";
			this.CostTextBox.Size = new Size(122, 20);
			this.CostTextBox.TabIndex = 7;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.splitContainer1);
			base.Name = "ItemsTab";
			base.Size = new Size(733, 502);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private IContainer components;

		private ListBox ItemsListBox;

		private Label ItemsLabel;

		private TableLayoutPanel tableLayoutPanel1;

		private Button AddButton;

		private Button RemoveButton;

		private SplitContainer splitContainer1;

		private Label CostLabel;

		private TextBox CostTextBox;

		private TextBox DescriptionTextBox;

		private Label DescriptionLabel;

		private TextBox NameTextBox;

		private Label NameLabel;

		private Label IdLabel;

		private Label SelectedItemLabel;

		private TextBox IdTextBox;
	}
}
