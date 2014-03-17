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

            //Console.WriteLine("release date: " + data["releaseDate"].GetType());
            //dtpReleaseDate.Value = (DateTime)data["releaseDate"];
        }

        private void cmdCancel_Click(object sender,EventArgs e) {
            Dispose();
        }

        private void cmdSave_Click(object sender,EventArgs e) {
            //Insert or update record

            data["name"] = txtName.Text;
            data["availability"] = Convert.ToInt32(txtAvailability.Text);
            data["cost"] = Convert.ToDouble(txtCost.Text);

            data["platform"] = cboPlatform.Text;
            data["publisher"] = cboPublisher.Text;
            data["developer"] = cboDeveloper.Text;
            data["rating"] = cboRating.Text;
            data["category"] = cboCategory.Text;

            data["releaseDate"] = dtpReleaseDate.Value;

            needsUpdate = true;
            Dispose();
        }

        public bool ShowDialog()
        {
            base.ShowDialog();
            return needsUpdate;
        }
    }
}
