using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //button to go back to the home page
    protected void btnDone_Click(object sender, EventArgs e)
    {
        //redirect to the home page
        Response.Redirect("Default.aspx");
    }

    //add the game to shopping basket
    protected void btnAddtoCart_Click(object sender, EventArgs e)
    {
        //redirect to the shopping basket page
        Response.Redirect("Basket.aspx");
    }

    protected void btnReview_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReviewPage.aspx");
    }
}