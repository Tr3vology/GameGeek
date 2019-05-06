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
    public partial class frmAddGame : Form
    {
        public frmAddGame()
        {
            InitializeComponent();
        }

        private void frmAddGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameGeekProductDataSet.tblGame' table. You can move, or remove it, as needed.
            this.tblGameTableAdapter.Fill(this.gameGeekProductDataSet.tblGame);
            // TODO: This line of code loads data into the 'gameGeekProductDataSet.GetGameNo' table. You can move, or remove it, as needed.
            this.getGameNoTableAdapter.Fill(this.gameGeekProductDataSet.GetGameNo);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //end the editing
            this.Validate();
            this.tblGameBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gameGeekProductDataSet);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //private void method to select image the folder
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "JPG|*.jpg|PNG|*.png";
            if (o.ShowDialog() == DialogResult.OK)
            {
                imagePathTextBox.Text = o.FileName;
                pictureBox1.Image = new Bitmap(o.FileName);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close This form
            this.Close();
        }
    }
}