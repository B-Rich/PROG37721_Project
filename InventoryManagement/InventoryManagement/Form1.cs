using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagement
{
	public partial class Form1 : Form
	{
        private SqlConnection conn=null;
        private SqlCommand cmd=null;

		public Form1()
		{
			InitializeComponent();
		}

        private void Form1_Load(object sender,EventArgs e) {
            
        }

        private void cmdInsert_Click(object sender,EventArgs e) {
            Hide();
            Form2 edit=new Form2();
            edit.ShowDialog();
            Show();
        }

        private void cmdUpdate_Click(object sender,EventArgs e) {

        }

        private void cmdDelete_Click(object sender,EventArgs e) {

        }

        private void cmdClear_Click(object sender,EventArgs e) {
            clearText();
        }

        private void clearText() {
            txtName.Text="";
            cboPlatform.Text="";
            cboPublisher.Text="";
            cboDeveloper.Text="";
            cboCategory.Text="";
            cboRating.Text="";
            dtpReleaseDate.ResetText();
            txtName.Focus();
            dg1.ClearSelection();
        }

	}
}
