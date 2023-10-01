using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.ButtonsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AddButon = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SecondarySplitContainer = new System.Windows.Forms.SplitContainer();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ButtonsTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondarySplitContainer)).BeginInit();
            this.SecondarySplitContainer.Panel1.SuspendLayout();
            this.SecondarySplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(3, 5);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomersLabel.TabIndex = 1;
            this.CustomersLabel.Text = "Customers";
            // 
            // ButtonsTableLayout
            // 
            this.ButtonsTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsTableLayout.ColumnCount = 3;
            this.ButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayout.Controls.Add(this.AddButon, 0, 0);
            this.ButtonsTableLayout.Controls.Add(this.RemoveButton, 1, 0);
            this.ButtonsTableLayout.Location = new System.Drawing.Point(3, 489);
            this.ButtonsTableLayout.Name = "ButtonsTableLayout";
            this.ButtonsTableLayout.RowCount = 1;
            this.ButtonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayout.Size = new System.Drawing.Size(315, 41);
            this.ButtonsTableLayout.TabIndex = 2;
            // 
            // AddButon
            // 
            this.AddButon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButon.Location = new System.Drawing.Point(3, 3);
            this.AddButon.Name = "AddButon";
            this.AddButon.Size = new System.Drawing.Size(99, 35);
            this.AddButon.TabIndex = 0;
            this.AddButon.Text = "Add";
            this.AddButon.UseVisualStyleBackColor = true;
            this.AddButon.Click += new System.EventHandler(this.AddButon_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(108, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(99, 35);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.IntegralHeight = false;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 21);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(315, 465);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedValueChanged += new System.EventHandler(this.CustomersListBox_SelectedValueChanged);
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.CustomersLabel);
            this.MainSplitContainer.Panel1.Controls.Add(this.ButtonsTableLayout);
            this.MainSplitContainer.Panel1.Controls.Add(this.CustomersListBox);
            this.MainSplitContainer.Panel1MinSize = 200;
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.MainSplitContainer.Panel2.Controls.Add(this.SecondarySplitContainer);
            this.MainSplitContainer.Panel2MinSize = 200;
            this.MainSplitContainer.Size = new System.Drawing.Size(786, 533);
            this.MainSplitContainer.SplitterDistance = 321;
            this.MainSplitContainer.TabIndex = 4;
            // 
            // SecondarySplitContainer
            // 
            this.SecondarySplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondarySplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SecondarySplitContainer.Name = "SecondarySplitContainer";
            this.SecondarySplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SecondarySplitContainer.Panel1
            // 
            this.SecondarySplitContainer.Panel1.Controls.Add(this.SelectedCustomerLabel);
            this.SecondarySplitContainer.Panel1.Controls.Add(this.FullNameLabel);
            this.SecondarySplitContainer.Panel1.Controls.Add(this.IdTextBox);
            this.SecondarySplitContainer.Panel1.Controls.Add(this.FullNameTextBox);
            this.SecondarySplitContainer.Panel1.Controls.Add(this.IdLabel);
            this.SecondarySplitContainer.Panel1.Controls.Add(this.AddressTextBox);
            this.SecondarySplitContainer.Panel1.Controls.Add(this.AddressLabel);
            this.SecondarySplitContainer.Panel1MinSize = 200;
            this.SecondarySplitContainer.Size = new System.Drawing.Size(461, 533);
            this.SecondarySplitContainer.SplitterDistance = 200;
            this.SecondarySplitContainer.TabIndex = 9;
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(3, 5);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(113, 13);
            this.SelectedCustomerLabel.TabIndex = 1;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(3, 60);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 8;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.IdTextBox.Location = new System.Drawing.Point(68, 31);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(122, 20);
            this.IdTextBox.TabIndex = 0;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(68, 57);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(390, 20);
            this.FullNameTextBox.TabIndex = 7;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(3, 34);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 13);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "ID:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTextBox.Location = new System.Drawing.Point(68, 83);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(390, 114);
            this.AddressTextBox.TabIndex = 4;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(3, 86);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 3;
            this.AddressLabel.Text = "Address:";
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainSplitContainer);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(786, 533);
            this.ButtonsTableLayout.ResumeLayout(false);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel1.PerformLayout();
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.SecondarySplitContainer.Panel1.ResumeLayout(false);
            this.SecondarySplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondarySplitContainer)).EndInit();
            this.SecondarySplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayout;
        private System.Windows.Forms.Button AddButon;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.SplitContainer SecondarySplitContainer;
    }
}
