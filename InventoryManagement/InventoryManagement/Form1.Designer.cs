namespace InventoryManagement
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboPlatform = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cboPublisher = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboDeveloper = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.cboCategory = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cboRating = new System.Windows.Forms.ComboBox();
			this.dg1 = new System.Windows.Forms.DataGridView();
			this.cmdInsert = new System.Windows.Forms.Button();
			this.cmdUpdate = new System.Windows.Forms.Button();
			this.cmdDelete = new System.Windows.Forms.Button();
			this.cmdClear = new System.Windows.Forms.Button();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(53, 6);
			this.txtName.MaxLength = 32;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(177, 20);
			this.txtName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(262, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Platform";
			// 
			// cboPlatform
			// 
			this.cboPlatform.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cboPlatform.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboPlatform.FormattingEnabled = true;
			this.cboPlatform.Items.AddRange(new object[] {
            "A123445697502",
            "B1235897260245",
            "C2349857029876026"});
			this.cboPlatform.Location = new System.Drawing.Point(313, 5);
			this.cboPlatform.MaxLength = 16;
			this.cboPlatform.Name = "cboPlatform";
			this.cboPlatform.Size = new System.Drawing.Size(148, 21);
			this.cboPlatform.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(494, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Publisher";
			// 
			// cboPublisher
			// 
			this.cboPublisher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cboPublisher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboPublisher.FormattingEnabled = true;
			this.cboPublisher.Items.AddRange(new object[] {
            "pub A",
            "pub B",
            "pub C"});
			this.cboPublisher.Location = new System.Drawing.Point(550, 5);
			this.cboPublisher.MaxLength = 32;
			this.cboPublisher.Name = "cboPublisher";
			this.cboPublisher.Size = new System.Drawing.Size(141, 21);
			this.cboPublisher.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Developer";
			// 
			// cboDeveloper
			// 
			this.cboDeveloper.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cboDeveloper.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboDeveloper.FormattingEnabled = true;
			this.cboDeveloper.Items.AddRange(new object[] {
            "G",
            "H",
            "J"});
			this.cboDeveloper.Location = new System.Drawing.Point(74, 37);
			this.cboDeveloper.MaxLength = 32;
			this.cboDeveloper.Name = "cboDeveloper";
			this.cboDeveloper.Size = new System.Drawing.Size(121, 21);
			this.cboDeveloper.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(201, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Release Date";
			// 
			// dtpReleaseDate
			// 
			this.dtpReleaseDate.Location = new System.Drawing.Point(279, 37);
			this.dtpReleaseDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
			this.dtpReleaseDate.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
			this.dtpReleaseDate.Name = "dtpReleaseDate";
			this.dtpReleaseDate.Size = new System.Drawing.Size(138, 20);
			this.dtpReleaseDate.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(423, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Category";
			// 
			// cboCategory
			// 
			this.cboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Items.AddRange(new object[] {
            "G",
            "H",
            "J"});
			this.cboCategory.Location = new System.Drawing.Point(478, 36);
			this.cboCategory.MaxLength = 16;
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new System.Drawing.Size(121, 21);
			this.cboCategory.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(605, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Rating";
			// 
			// cboRating
			// 
			this.cboRating.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cboRating.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboRating.FormattingEnabled = true;
			this.cboRating.Items.AddRange(new object[] {
            "G",
            "H",
            "J"});
			this.cboRating.Location = new System.Drawing.Point(649, 36);
			this.cboRating.MaxLength = 2;
			this.cboRating.Name = "cboRating";
			this.cboRating.Size = new System.Drawing.Size(42, 21);
			this.cboRating.TabIndex = 13;
			// 
			// dg1
			// 
			this.dg1.AllowUserToAddRows = false;
			this.dg1.AllowUserToDeleteRows = false;
			this.dg1.AllowUserToResizeColumns = false;
			this.dg1.AllowUserToResizeRows = false;
			this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg1.Location = new System.Drawing.Point(15, 64);
			this.dg1.Name = "dg1";
			this.dg1.ReadOnly = true;
			this.dg1.Size = new System.Drawing.Size(676, 324);
			this.dg1.TabIndex = 14;
			// 
			// cmdInsert
			// 
			this.cmdInsert.Location = new System.Drawing.Point(478, 394);
			this.cmdInsert.Name = "cmdInsert";
			this.cmdInsert.Size = new System.Drawing.Size(88, 23);
			this.cmdInsert.TabIndex = 15;
			this.cmdInsert.Text = "Add New Item";
			this.cmdInsert.UseVisualStyleBackColor = true;
			this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
			// 
			// cmdUpdate
			// 
			this.cmdUpdate.Location = new System.Drawing.Point(579, 394);
			this.cmdUpdate.Name = "cmdUpdate";
			this.cmdUpdate.Size = new System.Drawing.Size(51, 23);
			this.cmdUpdate.TabIndex = 16;
			this.cmdUpdate.Text = "Update";
			this.cmdUpdate.UseVisualStyleBackColor = true;
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			// 
			// cmdDelete
			// 
			this.cmdDelete.Location = new System.Drawing.Point(643, 394);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new System.Drawing.Size(49, 23);
			this.cmdDelete.TabIndex = 17;
			this.cmdDelete.Text = "Delete";
			this.cmdDelete.UseVisualStyleBackColor = true;
			this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
			// 
			// cmdClear
			// 
			this.cmdClear.Location = new System.Drawing.Point(15, 394);
			this.cmdClear.Name = "cmdClear";
			this.cmdClear.Size = new System.Drawing.Size(118, 23);
			this.cmdClear.TabIndex = 18;
			this.cmdClear.Text = "Clear Fields";
			this.cmdClear.UseVisualStyleBackColor = true;
			this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(708, 423);
			this.Controls.Add(this.cmdClear);
			this.Controls.Add(this.cmdDelete);
			this.Controls.Add(this.cmdUpdate);
			this.Controls.Add(this.cmdInsert);
			this.Controls.Add(this.dg1);
			this.Controls.Add(this.cboRating);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cboCategory);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dtpReleaseDate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cboDeveloper);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cboPublisher);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cboPlatform);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Product Search";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboPlatform;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboPublisher;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboDeveloper;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpReleaseDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboCategory;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cboRating;
		private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdClear;
		private System.Windows.Forms.BindingSource bindingSource1;
	}
}

