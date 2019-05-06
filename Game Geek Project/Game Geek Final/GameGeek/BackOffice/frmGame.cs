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
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameGeekProductDataSet.tblGame' table. You can move, or remove it, as needed.
            this.tblGameTableAdapter.Fill(this.gameGeekProductDataSet.tblGame);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create an instance of frmAddGame();
            frmAddGame Games = new frmGame();
            //display the add game form
            .Show();
            //invoke the addNewGame method (that I have created in frmAddGame)
            Games.AddNewGame();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close This form
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //create an instance of frmAddGame
            frmAddGame Watches = new frmAddGame();
            //declare a variable to store the game no from the list box
            int GameNo;
            //check to see if a record has been selected
            if (lstGame.SelectedIndex != -1)
            {
                //get the selected value from the list which should contain the primary key
                GameNo = Convert.ToInt32(lstGame.SelectedValue);

                Watches.Show();
                //invoke the findGameNo method (I created in frmAddGame)
                Watches.FindGame(GameNo);
            }
            else
            {
                MessageBox.Show("Please select a watch from the list", "watch List",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        private void lstGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable the edit button
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }
        private void frmGame_Activated(object sender, EventArgs e)
        {
            //load the data from the game table
            this.tblGameTableAdapter.Fill(this.gameGeekProductDataSet.tblGame);
            //disable the edit button
            btnEdit.Enabled = true;
            //disable the delete button 
            btnDelete.Enabled = true;
        }
    }
}