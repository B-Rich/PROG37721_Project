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
		public static readonly int COL_NAME = 0;
		public static readonly int COL_PLATFORM = 1;
		public static readonly int COL_PUBLISHER = 2;
		public static readonly int COL_DEVELOPER = 3;
		public static readonly int COL_CATEGORY = 4;
		public static readonly int COL_COST = 5;
		public static readonly int COL_AVAILABILITY = 6;
		public static readonly int COL_RELEASEDATE = 7;
		public static readonly int COL_RATING = 8;

		private SqlConnection conn = null;
		//private SqlCommand cmd=null; //CJ: Not needed?
		//CJ: Changed this to static
		private static SqlDataAdapter dAdapter = null;
		private static DataSet mainDataSet = null;
		private static DataView displayView = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cboMonth.ContextMenu = new ContextMenu();
			cboDay.ContextMenu = new ContextMenu();
			cboYear.ContextMenu = new ContextMenu();

			txtName.TextChanged += new EventHandler(updateViewFilter);
			cboPlatform.TextChanged += new EventHandler(updateViewFilter);
			cboPublisher.TextChanged += new EventHandler(updateViewFilter);
			cboDeveloper.TextChanged += new EventHandler(updateViewFilter);
			cboCategory.TextChanged += new EventHandler(updateViewFilter);
			//dtpReleaseDate.TextChanged+=new EventHandler(updateViewFilter);
			cboRating.TextChanged += new EventHandler(updateViewFilter);
			cboYear.TextChanged += new EventHandler(updateViewFilter);
			cboMonth.TextChanged += new EventHandler(updateViewFilter);
			cboDay.TextChanged += new EventHandler(updateViewFilter);
			cboYear.TextChanged += new EventHandler(cboYear_TextChanged);
			cboYear.TextChanged += new EventHandler(cboMonth_TextChanged);
			cboMonth.TextChanged += new EventHandler(cboMonth_TextChanged);
			cboYear.KeyPress += new KeyPressEventHandler(numberValidation);
			cboMonth.KeyPress += new KeyPressEventHandler(numberValidation);
			cboDay.KeyPress += new KeyPressEventHandler(numberValidation);

			//CJ: Clear test values from controls
			cboCategory.Items.Clear();
			cboDeveloper.Items.Clear();
			cboPlatform.Items.Clear();
			cboPublisher.Items.Clear();
			cboRating.Items.Clear();

			cboMonth.Enabled = false;
			cboDay.Enabled = false;

			//Populate date combo boxes
			for (int a = 1970; a <= 2020; a++)
				cboYear.Items.Add(a);
			for (int a = 1; a <= 12; a++)
				cboMonth.Items.Add(a);

			updateFromDB();
			populateComboBoxes();

			//set control state
			setControlState("search");
		}

		void numberValidation(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != 8)
				if (e.KeyChar < '0' || e.KeyChar > '9')
					e.Handled = true;
		}

		void cboMonth_TextChanged(object sender, EventArgs e)
		{
			if (cboMonth.Enabled == true)
			{
				int days = 0;
				if (cboYear.Text.Length > 0 &&
					cboMonth.Text.Length > 0)
				{
					int year = Convert.ToInt32(cboYear.Text);
					int month = Convert.ToInt32(cboMonth.Text);
					if (month > 0 && month < 13)
						days = DateTime.DaysInMonth(year, month);
				}

				cboDay.Items.Clear();

				if (cboMonth.Text.Length > 0)
					cboDay.Enabled = true;
				else
					cboDay.Enabled = false;

				for (int a = 1; a <= days; a++)
				{
					cboDay.Items.Add(a);
				}
			}
			else
				cboDay.Enabled = false;
		}

		void cboYear_TextChanged(object sender, EventArgs e)
		{
			if (cboYear.Text.Length > 0)
				cboMonth.Enabled = true;
			else
			{
				cboMonth.Enabled = false;
				cboDay.Enabled = false;
			}
		}

		private void updateViewFilter(object sender, EventArgs e)
		{
			string filter = "";

			if (txtName.Text.Length > 0)
			{
				if (filter.Length > 0)
					filter += " AND ";
				filter += "name LIKE '%" + formatString(txtName.Text) + "%'";
			}

			if (cboPlatform.Text.Length > 0)
			{
				if (filter.Length > 0)
					filter += " AND ";
				filter += "platform LIKE '%" + formatString(cboPlatform.Text) + "%'";
			}

			if (cboPublisher.Text.Length > 0)
			{
				if (filter.Length > 0)
					filter += " AND ";
				filter += "publisher LIKE '%" + formatString(cboPublisher.Text) + "%'";
			}

			if (cboDeveloper.Text.Length > 0)
			{
				if (filter.Length > 0)
					filter += " AND ";
				filter += "developer LIKE '%" + formatString(cboDeveloper.Text) + "%'";
			}

			if (cboCategory.Text.Length > 0)
			{
				if (filter.Length > 0)
					filter += " AND ";
				filter += "category LIKE '%" + formatString(cboCategory.Text) + "%'";
			}

			if (cboYear.Text.Length > 0)
			{
				if (filter.Length > 0)
					filter += " AND ";

				DateTime date;
				int year = Convert.ToInt32(cboYear.Text);
				int month = 1;
				int day = 1;
				int monthOffset = 12;
				if (cboMonth.Text.Length > 0)
				{
					month = Convert.ToInt32(cboMonth.Text);
					monthOffset = 1;
					if (cboDay.Text.Length > 0)
					{
						day = Convert.ToInt32(cboDay.Text);
						//monthOffset=0;
					}
				}
				if (month > 0 && month < 13 && day > 0 && day <= DateTime.DaysInMonth(year, month))
				{
					date = new DateTime(year, month, day);
				}
				else
				{
					date = new DateTime(1, 2, 1);
					monthOffset = -1;
				}
				if (cboDay.Text.Length == 0)
					filter += "releaseDate >= #" + date + "# AND releaseDate < #" + date.AddMonths(monthOffset) + "#";
				else
					filter += "releaseDate = #" + date + "#";
			}

			if (cboRating.Text.Length > 0)
			{
				if (filter.Length > 0)
					filter += " AND ";
				filter += "rating LIKE '%" + formatString(cboRating.Text) + "%'";
			}

			displayView.RowFilter = filter;
		}

		private string formatString(string format)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < format.Length; i++)
			{
				if (format[i] == '[' || format[i] == ']' || format[i] == '%' || format[i] == '^')
				{
					sb.Append("[" + format[i] + "]");
				}
				else if (format[i] == '\'')
				{
					sb.Append("''");
				}
				else
				{
					sb.Append(format[i]);
				}
			}
			return sb.ToString();
		}

		private void cmdInsert_Click(object sender, EventArgs e)
		{
			Hide();
			DataRow newRow = mainDataSet.Tables["inventory"].NewRow();
			Form2 edit = new Form2(newRow);
			if (edit.ShowDialog())
			{
				mainDataSet.Tables["inventory"].Rows.Add(newRow);
				updateToDB();
			}
			Show();
			dg1.ClearSelection();
            clearText();
            setControlState("search");
		}

		private void cmdUpdate_Click(object sender, EventArgs e)
		{
			if (dg1.SelectedRows.Count > 0)
			{
				Hide();
				DataGridViewCellCollection selectedCells = dg1.CurrentRow.Cells;
				DataRow[] rows = mainDataSet.Tables["inventory"].Select(
					"name='" + selectedCells["name"].Value.ToString() + "' AND " +
					"platform='" + selectedCells["platform"].Value.ToString() + "'"
				);
				if (rows.Length > 0)
				{
					Form2 edit = new Form2(rows[0]);
					if (edit.ShowDialog())
					{
						updateToDB();
					}
				}
				else
				{
					Console.WriteLine("ERROR: DataSet returned no rows that matched name=" + selectedCells["name"].Value.ToString() +
						" and platform=" + selectedCells["platform"].Value.ToString());
				}
				Show();
			}
			dg1.ClearSelection();
            clearText();
            setControlState("search");
		}

		private void cmdDelete_Click(object sender, EventArgs e)
		{
			int rowIndex = -1;
			if (MessageBox.Show("Are you sure you want to delete this record?",
			"Confirm record delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
			MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
			{
				rowIndex = dg1.CurrentRow.Index;
				for (int i = 0; i < mainDataSet.Tables["inventory"].Rows.Count; i++)
				{
					if (mainDataSet.Tables["inventory"].Rows[i].RowState != DataRowState.Deleted)
					{
						if (dg1.CurrentRow.Cells[0].Value.ToString().Equals(mainDataSet.Tables["inventory"].Rows[i][0].ToString()))
						{
							rowIndex = i;
						}
					}
				}

				mainDataSet.Tables["inventory"].Rows[rowIndex].Delete();
				updateToDB();
				dg1.ClearSelection();
			}
		}

		private void cmdClear_Click(object sender, EventArgs e)
		{
			clearText();
			setControlState("search");
		}

		private void clearText()
		{
			txtName.Text = "";
			cboPlatform.Text = "";
			cboPublisher.Text = "";
			cboDeveloper.Text = "";
			cboCategory.Text = "";
			cboRating.Text = "";
			//dtpReleaseDate.ResetText();
			cboYear.Text = "";
			cboMonth.Text = "";
			cboMonth.Enabled = false;
			cboDay.Text = "";
			cboDay.Enabled = false;
			txtName.Focus();
			dg1.ClearSelection();

		}


		private void updateFromDB()
		{
			try
			{
				//use helper method to get a connection obj
				conn = getConnection();
				conn.Open(); //open connection
				String sql = "SELECT * FROM [inventory]";
				dAdapter = new SqlDataAdapter(sql, conn);
				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dAdapter);
				mainDataSet = new DataSet();
				dAdapter.Fill(mainDataSet, "inventory");
				conn.Close();

				//Initialize DataView
				displayView = new DataView(mainDataSet.Tables["inventory"]);
				displayView.Sort = "name DESC";

				//bind
				bindingSource1.DataSource = displayView;
				//bindingSource1.DataSource = mainDataSet;
				//bindingSource1.DataMember = "inventory"; //specify the table
				dg1.DataSource = bindingSource1;

				dg1.Columns[COL_PUBLISHER].Visible = false; //hide columns we don't want to see
				dg1.Columns[COL_DEVELOPER].Visible = false;
				//dg1.Columns[COL_CATEGORY].Visible = false;
				//dg1.Columns[COL_RELEASEDATE].Visible = false;
				dg1.Columns[COL_RATING].Visible = false;

				//Make the column headers nice
				dg1.Columns[COL_NAME].HeaderText = "Name";
				dg1.Columns[COL_PLATFORM].HeaderText = "Platform";
				dg1.Columns[COL_CATEGORY].HeaderText = "Category";
				dg1.Columns[COL_RELEASEDATE].HeaderText = "Release Date";
				dg1.Columns[COL_COST].HeaderText = "Cost";
				dg1.Columns[COL_AVAILABILITY].HeaderText = "Stock";

				//Add extra width weight for the name column.
				dg1.Columns[COL_NAME].FillWeight = 200f;
				/*dg1.Columns[COL_CATEGORY].FillWeight = 100f;
				dg1.Columns[COL_RELEASEDATE].FillWeight = 100f;*/
				dg1.Columns[COL_COST].FillWeight = 60f;
				dg1.Columns[COL_AVAILABILITY].FillWeight = 60f;

				dg1.Columns[COL_COST].DefaultCellStyle.Format = "c";

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

		private void updateToDB()
		{
			try
			{
				conn.Open();
				dAdapter.Update(mainDataSet, "inventory");
				conn.Close();
			}
			catch (SqlException ex)
			{
				if (conn != null)
				{
					conn.Close();
				}
				MessageBox.Show(ex.Message,
					"Exception updated database",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		/**
		 * Populate combo boxes with all distinct values from the database for the
		 * appropriate combo boxes.
		 */
		private void populateComboBoxes()
		{
			populateComboBox(cboCategory, COL_CATEGORY);
			populateComboBox(cboDeveloper, COL_DEVELOPER);
			populateComboBox(cboPlatform, COL_PLATFORM);
			populateComboBox(cboPublisher, COL_PUBLISHER);
			populateComboBox(cboRating, COL_RATING);
		}

		public static void populateComboBox(ComboBox cb, int rowType)
		{
			for (int i = 0; i < mainDataSet.Tables["inventory"].Rows.Count; i++)
			{
				DataRow row = mainDataSet.Tables["inventory"].Rows[i];
				if (!cb.Items.Contains(row.ItemArray[rowType])) //if not already in the list
					cb.Items.Add(row.ItemArray[rowType]);		  //add it to the list

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
			//String path = Regex.Replace(System.Environment.CurrentDirectory, "bin.*", "Database1.mdf");
			//String connStr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + path + ";Integrated Security=True;User Instance=True";
			//CJ: Use |DataDirectory| to get the mdf's folder regardless of physical location
			String connStr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True";
			return new SqlConnection(connStr);
		}

		private void setControlState(string state)
		{
			if (state.Equals("search"))
			{
				cmdUpdate.Enabled = false;
				cmdDelete.Enabled = false;
			}
			else if (state.Equals("selected"))
			{
				cmdUpdate.Enabled = true;
				cmdDelete.Enabled = true;
			}
		}

		private void dg1_Click(object sender, EventArgs e)
		{
			setControlState("selected");
		}
	}
}
