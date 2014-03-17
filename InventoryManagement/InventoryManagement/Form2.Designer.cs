namespace InventoryManagement {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components=null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cboRating = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDeveloper = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPlatform = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAvailability = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cboRating.Location = new System.Drawing.Point(685, 114);
            this.cboRating.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboRating.MaxLength = 2;
            this.cboRating.Name = "cboRating";
            this.cboRating.Size = new System.Drawing.Size(80, 33);
            this.cboRating.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Rating";
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
            this.cboCategory.Location = new System.Drawing.Point(180, 171);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboCategory.MaxLength = 16;
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(272, 33);
            this.cboCategory.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Category";
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReleaseDate.Location = new System.Drawing.Point(180, 121);
            this.dtpReleaseDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpReleaseDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpReleaseDate.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(272, 31);
            this.dtpReleaseDate.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Release Date";
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
            this.cboDeveloper.Location = new System.Drawing.Point(685, 61);
            this.cboDeveloper.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboDeveloper.MaxLength = 32;
            this.cboDeveloper.Name = "cboDeveloper";
            this.cboDeveloper.Size = new System.Drawing.Size(292, 33);
            this.cboDeveloper.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Developer";
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
            this.cboPublisher.Location = new System.Drawing.Point(180, 61);
            this.cboPublisher.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboPublisher.MaxLength = 32;
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(272, 33);
            this.cboPublisher.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Publisher";
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
            this.cboPlatform.Location = new System.Drawing.Point(685, 10);
            this.cboPlatform.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboPlatform.MaxLength = 16;
            this.cboPlatform.Name = "cboPlatform";
            this.cboPlatform.Size = new System.Drawing.Size(292, 33);
            this.cboPlatform.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Platform";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 11);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtName.MaxLength = 32;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(351, 31);
            this.txtName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 229);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(180, 222);
            this.txtCost.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCost.MaxLength = 8;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(160, 31);
            this.txtCost.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(563, 171);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Availability";
            // 
            // txtAvailability
            // 
            this.txtAvailability.Location = new System.Drawing.Point(685, 165);
            this.txtAvailability.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAvailability.MaxLength = 4;
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.Size = new System.Drawing.Size(196, 31);
            this.txtAvailability.TabIndex = 29;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(685, 314);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(149, 44);
            this.cmdSave.TabIndex = 32;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(851, 314);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(149, 44);
            this.cmdCancel.TabIndex = 33;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 379);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.txtAvailability);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label8);
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
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form2";
            this.Text = "Edit Record";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRating;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDeveloper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPublisher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPlatform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAvailability;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;

    }
}