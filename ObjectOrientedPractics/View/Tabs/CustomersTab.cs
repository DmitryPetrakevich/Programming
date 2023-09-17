using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
	public class CustomersTab : UserControl
	{
		public CustomersTab()
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
			this.CustomersLabel = new Label();
			this.ButtonsTableLayout = new TableLayoutPanel();
			this.AddButon = new Button();
			this.RemoveButton = new Button();
			this.CustomersListBox = new ListBox();
			this.MainSplitContainer = new SplitContainer();
			this.FullNameLabel = new Label();
			this.FullNameTextBox = new TextBox();
			this.AddressTextBox = new TextBox();
			this.AddressLabel = new Label();
			this.IdLabel = new Label();
			this.SelectedCustomerLabel = new Label();
			this.IdTextBox = new TextBox();
			this.SecondarySplitContainer = new SplitContainer();
			this.ButtonsTableLayout.SuspendLayout();
			((ISupportInitialize)this.MainSplitContainer).BeginInit();
			this.MainSplitContainer.Panel1.SuspendLayout();
			this.MainSplitContainer.Panel2.SuspendLayout();
			this.MainSplitContainer.SuspendLayout();
			((ISupportInitialize)this.SecondarySplitContainer).BeginInit();
			this.SecondarySplitContainer.Panel1.SuspendLayout();
			this.SecondarySplitContainer.SuspendLayout();
			base.SuspendLayout();
			this.CustomersLabel.AutoSize = true;
			this.CustomersLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.CustomersLabel.Location = new Point(3, 5);
			this.CustomersLabel.Name = "CustomersLabel";
			this.CustomersLabel.Size = new Size(65, 13);
			this.CustomersLabel.TabIndex = 1;
			this.CustomersLabel.Text = "Customers";
			this.ButtonsTableLayout.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.ButtonsTableLayout.ColumnCount = 3;
			this.ButtonsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
			this.ButtonsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
			this.ButtonsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
			this.ButtonsTableLayout.Controls.Add(this.AddButon, 0, 0);
			this.ButtonsTableLayout.Controls.Add(this.RemoveButton, 1, 0);
			this.ButtonsTableLayout.Location = new Point(3, 489);
			this.ButtonsTableLayout.Name = "ButtonsTableLayout";
			this.ButtonsTableLayout.RowCount = 1;
			this.ButtonsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.ButtonsTableLayout.Size = new Size(315, 41);
			this.ButtonsTableLayout.TabIndex = 2;
			this.AddButon.Dock = DockStyle.Fill;
			this.AddButon.Location = new Point(3, 3);
			this.AddButon.Name = "AddButon";
			this.AddButon.Size = new Size(99, 35);
			this.AddButon.TabIndex = 0;
			this.AddButon.Text = "Add";
			this.AddButon.UseVisualStyleBackColor = true;
			this.RemoveButton.Dock = DockStyle.Fill;
			this.RemoveButton.Location = new Point(108, 3);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new Size(99, 35);
			this.RemoveButton.TabIndex = 1;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.CustomersListBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.CustomersListBox.FormattingEnabled = true;
			this.CustomersListBox.IntegralHeight = false;
			this.CustomersListBox.Location = new Point(3, 21);
			this.CustomersListBox.Name = "CustomersListBox";
			this.CustomersListBox.Size = new Size(315, 465);
			this.CustomersListBox.TabIndex = 0;
			this.MainSplitContainer.Dock = DockStyle.Fill;
			this.MainSplitContainer.Location = new Point(0, 0);
			this.MainSplitContainer.Name = "MainSplitContainer";
			this.MainSplitContainer.Panel1.Controls.Add(this.CustomersLabel);
			this.MainSplitContainer.Panel1.Controls.Add(this.ButtonsTableLayout);
			this.MainSplitContainer.Panel1.Controls.Add(this.CustomersListBox);
			this.MainSplitContainer.Panel1MinSize = 200;
			this.MainSplitContainer.Panel2.BackColor = Color.White;
			this.MainSplitContainer.Panel2.Controls.Add(this.SecondarySplitContainer);
			this.MainSplitContainer.Panel2MinSize = 200;
			this.MainSplitContainer.Size = new Size(786, 533);
			this.MainSplitContainer.SplitterDistance = 321;
			this.MainSplitContainer.TabIndex = 4;
			this.FullNameLabel.AutoSize = true;
			this.FullNameLabel.Location = new Point(3, 60);
			this.FullNameLabel.Name = "FullNameLabel";
			this.FullNameLabel.Size = new Size(57, 13);
			this.FullNameLabel.TabIndex = 8;
			this.FullNameLabel.Text = "Full Name:";
			this.FullNameTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.FullNameTextBox.Location = new Point(68, 57);
			this.FullNameTextBox.Name = "FullNameTextBox";
			this.FullNameTextBox.Size = new Size(390, 20);
			this.FullNameTextBox.TabIndex = 7;
			this.AddressTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.AddressTextBox.Location = new Point(68, 83);
			this.AddressTextBox.Multiline = true;
			this.AddressTextBox.Name = "AddressTextBox";
			this.AddressTextBox.Size = new Size(390, 114);
			this.AddressTextBox.TabIndex = 4;
			this.AddressLabel.AutoSize = true;
			this.AddressLabel.Location = new Point(3, 86);
			this.AddressLabel.Name = "AddressLabel";
			this.AddressLabel.Size = new Size(48, 13);
			this.AddressLabel.TabIndex = 3;
			this.AddressLabel.Text = "Address:";
			this.IdLabel.AutoSize = true;
			this.IdLabel.Location = new Point(3, 34);
			this.IdLabel.Name = "IdLabel";
			this.IdLabel.Size = new Size(21, 13);
			this.IdLabel.TabIndex = 2;
			this.IdLabel.Text = "ID:";
			this.SelectedCustomerLabel.AutoSize = true;
			this.SelectedCustomerLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.SelectedCustomerLabel.Location = new Point(3, 5);
			this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
			this.SelectedCustomerLabel.Size = new Size(113, 13);
			this.SelectedCustomerLabel.TabIndex = 1;
			this.SelectedCustomerLabel.Text = "Selected Customer";
			this.IdTextBox.Location = new Point(68, 31);
			this.IdTextBox.Name = "IdTextBox";
			this.IdTextBox.Size = new Size(122, 20);
			this.IdTextBox.TabIndex = 0;
			this.SecondarySplitContainer.Dock = DockStyle.Fill;
			this.SecondarySplitContainer.Location = new Point(0, 0);
			this.SecondarySplitContainer.Name = "SecondarySplitContainer";
			this.SecondarySplitContainer.Orientation = Orientation.Horizontal;
			this.SecondarySplitContainer.Panel1.Controls.Add(this.SelectedCustomerLabel);
			this.SecondarySplitContainer.Panel1.Controls.Add(this.FullNameLabel);
			this.SecondarySplitContainer.Panel1.Controls.Add(this.IdTextBox);
			this.SecondarySplitContainer.Panel1.Controls.Add(this.FullNameTextBox);
			this.SecondarySplitContainer.Panel1.Controls.Add(this.IdLabel);
			this.SecondarySplitContainer.Panel1.Controls.Add(this.AddressTextBox);
			this.SecondarySplitContainer.Panel1.Controls.Add(this.AddressLabel);
			this.SecondarySplitContainer.Panel1MinSize = 200;
			this.SecondarySplitContainer.Size = new Size(461, 533);
			this.SecondarySplitContainer.SplitterDistance = 200;
			this.SecondarySplitContainer.TabIndex = 9;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.MainSplitContainer);
			base.Name = "CustomersTab";
			base.Size = new Size(786, 533);
			this.ButtonsTableLayout.ResumeLayout(false);
			this.MainSplitContainer.Panel1.ResumeLayout(false);
			this.MainSplitContainer.Panel1.PerformLayout();
			this.MainSplitContainer.Panel2.ResumeLayout(false);
			((ISupportInitialize)this.MainSplitContainer).EndInit();
			this.MainSplitContainer.ResumeLayout(false);
			this.SecondarySplitContainer.Panel1.ResumeLayout(false);
			this.SecondarySplitContainer.Panel1.PerformLayout();
			((ISupportInitialize)this.SecondarySplitContainer).EndInit();
			this.SecondarySplitContainer.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private IContainer components;

		private Label CustomersLabel;

		private TableLayoutPanel ButtonsTableLayout;

		private Button AddButon;

		private Button RemoveButton;

		private ListBox CustomersListBox;

		private SplitContainer MainSplitContainer;

		private Label FullNameLabel;

		private TextBox FullNameTextBox;

		private TextBox AddressTextBox;

		private Label AddressLabel;

		private Label IdLabel;

		private Label SelectedCustomerLabel;

		private TextBox IdTextBox;

		private SplitContainer SecondarySplitContainer;
	}
}
