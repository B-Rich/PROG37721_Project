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
        bool isExisting = false, needsUpdate = false;
        DataRow data;

        public Form2() {
            InitializeComponent();
        }

        public Form2(DataRow row)
        {
            InitializeComponent();
            isExisting = true;
            data = row;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cmdCancel_Click(object sender,EventArgs e) {
            Dispose();
        }

        private void cmdSave_Click(object sender,EventArgs e) {
            //Insert or update record

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
