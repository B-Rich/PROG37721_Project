using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagement {
    public partial class Form2:Form {
        bool needsUpdate = false;
        DataRow data;

        public Form2() {
            InitializeComponent();
        }

        public Form2(DataRow row)
        {
            InitializeComponent();
            data = row;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtName.Text = data["name"].ToString();
            txtAvailability.Text = data["availability"].ToString();
            txtCost.Text = data["cost"].ToString();

            cboPlatform.Text = data["platform"].ToString();
            cboPublisher.Text = data["publisher"].ToString();
            cboDeveloper.Text = data["developer"].ToString();
            cboRating.Text = data["rating"].ToString();
            cboCategory.Text = data["category"].ToString();

            if (data["releaseDate"] != DBNull.Value)
            {
                dtpReleaseDate.Value = (DateTime)data["releaseDate"];
            }

            //List Rating Combobox
            listRatings();
        }

        private void cmdCancel_Click(object sender,EventArgs e) {
            Dispose();
        }

        private void cmdSave_Click(object sender,EventArgs e) {
            //Insert or update record and check for empty field
            if (isEmptyField() != true)
            {
                data["name"] = txtName.Text;
                data["availability"] = Convert.ToInt32(txtAvailability.Text);
                data["cost"] = Convert.ToDouble(txtCost.Text);

                data["platform"] = cboPlatform.Text;
                data["publisher"] = cboPublisher.Text;
                data["developer"] = cboDeveloper.Text;
                data["rating"] = cboRating.Text;
                data["category"] = cboCategory.Text;

                data["releaseDate"] = dtpReleaseDate.Value.Date;

                needsUpdate = true;
                Dispose();
            }
        }

        public bool ShowDialog()
        {
            base.ShowDialog();
            return needsUpdate;
        }

        private void listRatings()
        {
            cboRating.Items.Clear();
            cboRating.DropDownStyle = ComboBoxStyle.DropDownList;
            string [] ratings = {"E", "EC", "E10+", "T", "M", "AO", "RP"};
            for (int i = 0; i < ratings.Count(); i++)
            {
                cboRating.Items.Add(ratings[i]);
            }
        }

        private bool isEmptyField()
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Name Field Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (cboPlatform.Text.Equals(""))
            {
                MessageBox.Show("Platform Field Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPlatform.Focus();
            }
            else if (cboPublisher.Text.Equals(""))
            {
                MessageBox.Show("Publisher Field Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPublisher.Focus();
            }
            else if (cboDeveloper.Text.Equals(""))
            {
                MessageBox.Show("Developer Field Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDeveloper.Focus();
            }
            else if (cboRating.Text.Equals(""))
            {
                MessageBox.Show("Rating Field Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboRating.Focus();
            }
            else if (cboCategory.Text.Equals(""))
            {
                MessageBox.Show("Category Field Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategory.Focus();
            }
            else if (txtAvailability.Text.Equals(""))
            {
                MessageBox.Show("Availability Field Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAvailability.Focus();
            }
            else if (txtCost.Text.Equals(""))
            {
                MessageBox.Show("Cost Field Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCost.Focus();
            }
            return true;
        }
    }
}
