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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // create an instance of frmBox
            frmAddCustomer myCustomerForm = new frmAddCustomer();
            //display the form
            myCustomerForm.Show();
        }

        private void btnUpdateGame_Click(object sender, EventArgs e)
        {
            // create an instance of frmGame
            frmGame myGameForm = new frmGame();
            //display the form
            myGameForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // create an instance of frmBox
            frmAddCustomer myCustomerForm = new frmAddCustomer();
            //display the form
            myCustomerForm.Show();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            // create an instance of frmGame
            frmAddGame myGameForm = new frmAddGame();
            //display the form
            myGameForm.Show();
        }
    }
}
