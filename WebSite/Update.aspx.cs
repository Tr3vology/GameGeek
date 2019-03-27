using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //button to confirm changes have been made
    protected void btnOk_Click(object sender, EventArgs e)
    {
        //redirect to admin home page
        Response.Redirect("AdminMain.aspx");
    }

    //button to cancel editing the game
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to admin home page
        Response.Redirect("AdminMain.aspx");
    }
}
