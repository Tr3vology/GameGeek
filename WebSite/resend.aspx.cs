using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class resend : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //button to get password sent to typed email address
    protected void btnPassword_Click(object sender, EventArgs e)
    {
        //response message to confirm the password has been sent
        lblConfirm.Text = "Your password has been sent to your email address.";
    }

    //button to return to home page
    protected void btnDone_Click(object sender, EventArgs e)
    {
        //redirect to home page
        Response.Redirect("default.aspx");
    }
}