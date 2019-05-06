using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameGeekCustomerDataSet.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.gameGeekCustomerDataSet.tblCustomer);
            // TODO: This line of code loads data into the 'gameGeekCustomerDataSet.GetCustomerNo' table. You can move, or remove it, as needed.
            this.getCustomerNoTableAdapter.Fill(this.gameGeekCustomerDataSet.GetCustomerNo);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close This form
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //end the editing
            this.Validate();
            this.tblCustomerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gameGeekCustomerDataSet);
        }
    }
    }

