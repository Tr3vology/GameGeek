using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangeOrderStatus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //button to confirm the change
    protected void btnChange_Click(object sender, EventArgs e)
    {
        //redirect to the main admin page
        Response.Redirect("AdminMain.aspx");
    }

    //button to search for the typed game
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}