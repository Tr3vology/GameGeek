using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //button to go back to home page
    protected void btnDone_Click(object sender, EventArgs e)
    {
        //redirect back to home page
        Response.Redirect("default.aspx");
    }

    //button to update the details entered
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //tell the user that their details have been succesfuly updated
        lblUpdated.Text = "Account Details updated!";
    }

    protected void txtFName_TextChanged(object sender, EventArgs e)
    {

    }
}