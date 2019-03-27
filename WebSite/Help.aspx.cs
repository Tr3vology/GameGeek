using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class swapmanager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnWishList_Click(object sender, EventArgs e)
    {
        Response.Redirect("wishlistmanager.aspx");
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session["LoggedIn"] = false;
        Response.Redirect("default.aspx");
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Response.Redirect("deleteswap.aspx");
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("aswap.aspx");
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("aswap.aspx");
    }
    protected void btnDone_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }

    protected void btnContactUs_Click(object sender, EventArgs e)
    {
        Response.Redirect("ContactUs.aspx");
    }
}