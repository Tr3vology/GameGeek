using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //button to go to update game
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //redirect to the update game page
        Response.Redirect("Update.aspx");
    }

    //button to go to add game
    protected void btnAddGame_Click(object sender, EventArgs e)
    {
        //redirect to the add game page
        Response.Redirect("Update.aspx");
    }

    //button to delete game
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //redirect to confirm deletion page
        Response.Redirect("Delete.aspx");
    }

    //button to search for a customer
    protected void btnSearchCustomer_Click(object sender, EventArgs e)
    {
        //redirect to the edit customer details page
        Response.Redirect("EditCustomerDetail.aspx");
    }

    //button to view order
    protected void btnViewOrder_Click(object sender, EventArgs e)
    {
        //redirect to the view ordeer page
        Response.Redirect("ChangeOrderStatus.aspx");
    }

    //button to log out of the admin system
    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        //redirect to the regular home page
        Response.Redirect("Default.aspx");
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {

    }
}