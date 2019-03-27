using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ContactUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //button to return to home page
    protected void btnHome_Click(object sender, EventArgs e)
    {
        //redirect to home page
        Response.Redirect("Default.aspx");
    }
}