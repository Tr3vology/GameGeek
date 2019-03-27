using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class changepassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //button to confirm password change
    protected void btnChange_Click(object sender, EventArgs e)
    {
        lblError.Text = "Your password has been changed.";
        txtNewPW1.Text = "";
        txtNewPW2.Text = "";
        txtOldPW.Text = "";
    }

    //button to return to home page
    protected void btnDone_Click(object sender, EventArgs e)
    {
        //redirect to home page
        Response.Redirect("default.aspx");
    }
}