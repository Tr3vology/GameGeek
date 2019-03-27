using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Shopping_Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //button to return to home page
    protected void btnDone_Click(object sender, EventArgs e)
    {
        //redirect to home page
        Response.Redirect("Default.aspx");
    }

        
    
    //button to check out
    protected void btnCheckOut_Click(object sender, EventArgs e)
    {
        //redirect to payment page
        Response.Redirect("Payment Page.aspx");
    }

    //button to remove the item from the basket
    protected void btnRemove_Click(object sender, EventArgs e)
    {
        lblSampleGameName.Text = "";
        lblSampleGamePrice.Text = "";
        lblSamplegameQ.Text = "";
        lblSampleTotal.Text = "£00.00";
    }
}