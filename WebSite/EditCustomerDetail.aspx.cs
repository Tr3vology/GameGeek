using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditCustomerDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //button to confirm change
    protected void Button1_Click(object sender, EventArgs e)
    {
        //redirect to admin main page
        Response.Redirect("AdminMain.aspx");
    }

    //button to search for a customer id
    protected void btnSearch_Click(object sender, EventArgs e)
    {

    }
}