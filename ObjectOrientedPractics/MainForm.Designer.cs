namespace ObjectOrientedPractics
{
	public partial class MainForm : global::System.Windows.Forms.Form
	{
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
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ObjectOrientedPractics.MainForm));
			this.MainTabControl = new global::System.Windows.Forms.TabControl();
			this.ItemsTabPage = new global::System.Windows.Forms.TabPage();
			this.ItemsTab = new global::ObjectOrientedPractics.View.Tabs.ItemsTab();
			this.CustomersTabPage = new global::System.Windows.Forms.TabPage();
			this.CustomersTab = new global::ObjectOrientedPractics.View.Tabs.CustomersTab();
			this.MainTabControl.SuspendLayout();
			this.ItemsTabPage.SuspendLayout();
			this.CustomersTabPage.SuspendLayout();
			base.SuspendLayout();
			this.MainTabControl.Controls.Add(this.ItemsTabPage);
			this.MainTabControl.Controls.Add(this.CustomersTabPage);
			this.MainTabControl.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.MainTabControl.Location = new global::System.Drawing.Point(0, 0);
			this.MainTabControl.Name = "MainTabControl";
			this.MainTabControl.SelectedIndex = 0;
			this.MainTabControl.Size = new global::System.Drawing.Size(800, 450);
			this.MainTabControl.TabIndex = 0;
			this.ItemsTabPage.Controls.Add(this.ItemsTab);
			this.ItemsTabPage.Location = new global::System.Drawing.Point(4, 22);
			this.ItemsTabPage.Name = "ItemsTabPage";
			this.ItemsTabPage.Padding = new global::System.Windows.Forms.Padding(3);
			this.ItemsTabPage.Size = new global::System.Drawing.Size(792, 424);
			this.ItemsTabPage.TabIndex = 0;
			this.ItemsTabPage.Text = "Items";
			this.ItemsTabPage.UseVisualStyleBackColor = true;
			this.ItemsTab.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ItemsTab.Location = new global::System.Drawing.Point(3, 3);
			this.ItemsTab.Name = "ItemsTab";
			this.ItemsTab.Size = new global::System.Drawing.Size(786, 418);
			this.ItemsTab.TabIndex = 0;
			this.CustomersTabPage.Controls.Add(this.CustomersTab);
			this.CustomersTabPage.Location = new global::System.Drawing.Point(4, 22);
			this.CustomersTabPage.Name = "CustomersTabPage";
			this.CustomersTabPage.Padding = new global::System.Windows.Forms.Padding(3);
			this.CustomersTabPage.Size = new global::System.Drawing.Size(792, 424);
			this.CustomersTabPage.TabIndex = 1;
			this.CustomersTabPage.Text = "Customers";
			this.CustomersTabPage.UseVisualStyleBackColor = true;
			this.CustomersTab.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CustomersTab.Location = new global::System.Drawing.Point(3, 3);
			this.CustomersTab.Name = "CustomersTab";
			this.CustomersTab.Size = new global::System.Drawing.Size(786, 418);
			this.CustomersTab.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.MainTabControl);
			base.Name = "MainForm";
			this.Text = "Object Oriented Practics";
			this.MainTabControl.ResumeLayout(false);
			this.ItemsTabPage.ResumeLayout(false);
			this.CustomersTabPage.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.TabControl MainTabControl;

		private global::System.Windows.Forms.TabPage ItemsTabPage;

		private global::System.Windows.Forms.TabPage CustomersTabPage;

		private global::ObjectOrientedPractics.View.Tabs.ItemsTab ItemsTab;

		private global::ObjectOrientedPractics.View.Tabs.CustomersTab CustomersTab;
	}
}
