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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameGeekCustomerDataSet.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.gameGeekCustomerDataSet.tblCustomer);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create an instance of frmAddCustomer();
            frmAddCustomer Customers = new frmAddCustomer();
            //display the add game form
            Customers.Show();
            //invoke the addNewGame method (that I have created in frmAddCustomer)
            Customers.AddNewCustomer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //create an instance of frmAddGame
            frmAddCustomer Customers = new frmAddCustomer();
            //declare a variable to store the game no from the list box
            int CustomerNo;
            //check to see if a record has been selected
            if (lstCustomer.SelectedIndex != -1)
            {
                //get the selected value from the list which should contain the primary key
                CustomerNo = Convert.ToInt32(lstCustomer.SelectedValue);

                Customers.Show();
                //invoke the findGameNo method (I created in frmAddGame)
                Customers.FindCustomer(CustomerNo);
            }
            else
            {
                MessageBox.Show("Please select a customer from the list", "Customer List",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable the edit button
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Index;
            Index = lstCustomer.SelectedIndex;
            this.tblCustomerTableAdapter.Update(this.gameGeekCustomerDataSet);
            this.frmCustomer_Load(null, null);
            DialogResult Response;
            Response = MessageBox.Show("Are you sure that you want to delete this Customer?", "Delete Customer",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Response == DialogResult.Yes)
            {
                gameGeekCustomerDataSet.tblCustomer.Rows[Index].Delete();
                this.tblCustomerTableAdapter.Update(this.gameGeekCustomerDataSet);
            }
            else
            {
                gameGeekCustomerDataSet.tblCustomer.Rows[Index].CancelEdit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
