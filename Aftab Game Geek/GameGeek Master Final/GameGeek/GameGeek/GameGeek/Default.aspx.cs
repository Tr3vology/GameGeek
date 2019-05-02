using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MSWatchShop
{

    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //adding using to the top of the code mean we won't need to access classes like this..
            Class_Library.clsDataConnection MyDB = new Class_Library.clsDataConnection();
        }


        protected void btnPopulate_Click(object sender, EventArgs e)
        {
            //Call the display users function
            lblError.Text = DisplayUsers() + "found";

        }
        Int32 DisplayUsers()
        {
            //create and instance of the user collection
            clsUserCollection  MyUsers = new clsUserCollection();
            //find all users
            MyUsers.FindAllUsers();
            //set the data source of the list box
            lstUsers.DataSource = MyUsers.Users;
            //set the text to be displayed
            lstUsers.DataTextField = "FirstName";
            //set the primary key
            lstUsers.DataValueField = "UserNo";
            //bind the data
            lstUsers.DataBind();
            //return the count of records in the list 
            return MyUsers.Count;

        }
    }
}