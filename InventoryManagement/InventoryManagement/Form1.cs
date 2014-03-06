using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace InventoryManagement
{
	public partial class Form1 : Form
	{
		private static readonly int COL_NAME = 0;
		private static readonly int COL_PLATFORM = 1;
		private static readonly int COL_PUBLISHER = 2;
		private static readonly int COL_DEVELOPER = 3;
		private static readonly int COL_CATEGORY = 4;
		private static readonly int COL_COST = 5;
		private static readonly int COL_AVAILABILITY = 6;
		private static readonly int COL_RELEASEDATE = 7;
		private static readonly int COL_RATING = 8;

        private SqlConnection conn=null;
        //private SqlCommand cmd=null; //CJ: Not needed?
		private SqlDataAdapter dAdapter = null;
		private DataSet mainDataSet = null;

		public Form1()
		{
			InitializeComponent();
		}

        private void Form1_Load(object sender,EventArgs e) {
			
			//CJ: Clear test values from controls
			cboCategory.Items.Clear();
			cboDeveloper.Items.Clear();
			cboPlatform.Items.Clear();
			cboPublisher.Items.Clear();
			cboRating.Items.Clear();
			
			updateFromDB();
			populateComboBoxes();
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


		private void updateFromDB()
		{
			try
			{
				//use helper method to get a connection obj
				SqlConnection conn = getConnection();
				conn.Open(); //open connection
				String sql = "SELECT * FROM [inventory]";
				dAdapter = new SqlDataAdapter(sql, conn);
				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dAdapter);
				mainDataSet = new DataSet();
				dAdapter.Fill(mainDataSet, "inventory");
				conn.Close();
				//bind
				bindingSource1.DataSource = mainDataSet;
				bindingSource1.DataMember = "inventory"; //specify the table
				dg1.DataSource = bindingSource1;

				dg1.Columns[2].Visible = false; //hide columns we don't want to see
				dg1.Columns[3].Visible = false;
				dg1.Columns[4].Visible = false;
				dg1.Columns[7].Visible = false;
				dg1.Columns[8].Visible = false;

				//FIXME: Format columns so all 4 fit in the control's space

				dg1.ClearSelection();
			}
			catch (SqlException ex)
			{
				if (conn != null) //if connected, but had exception
				{
					conn.Close(); //close connection
					MessageBox.Show(ex.Message,
						"Exception when trying to open SQL Connection",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
			}
		}

		/**
		 * Populate combo boxes with all distinct values from the database for the
		 * appropriate combo boxes.
		 */
		private void populateComboBoxes()
		{
			for (int i = 0; i < mainDataSet.Tables["inventory"].Rows.Count; i++)
			{
				DataRow row = mainDataSet.Tables["inventory"].Rows[i];
				if (!cboCategory.Items.Contains(row.ItemArray[COL_CATEGORY])) //if not already in the list
					cboCategory.Items.Add(row.ItemArray[COL_CATEGORY]);		  //add it to the list
				if (!cboDeveloper.Items.Contains(row.ItemArray[COL_DEVELOPER]))
					cboDeveloper.Items.Add(row.ItemArray[COL_DEVELOPER]);
				if (!cboPlatform.Items.Contains(row.ItemArray[COL_PLATFORM]))
					cboPlatform.Items.Add(row.ItemArray[COL_PLATFORM]);
				if (!cboPublisher.Items.Contains(row.ItemArray[COL_PUBLISHER]))
					cboPublisher.Items.Add(row.ItemArray[COL_PUBLISHER]);
				if (!cboRating.Items.Contains(row.ItemArray[COL_RATING]))
					cboRating.Items.Add(row.ItemArray[COL_RATING]);
			}
		}


		/**
		 * SqlConnection factory
		 * Always use this to get a connection to the DB so we can quickly change
		 * the connection method when we move from debug/dev to a full application.
		 */
		private SqlConnection getConnection()
		{
			//We need to do some string acrobatics here because the connection string expects an absolute path to the mdf file
			//TODO: Will need to change this when we do a release executable that isn't in /bin/Release or /bin/Debug
			String path = Regex.Replace(System.Environment.CurrentDirectory, "bin.*", "Database1.mdf");
			String connStr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + path + ";Integrated Security=True;User Instance=True";
			return new SqlConnection(connStr);
		}


	}
}
