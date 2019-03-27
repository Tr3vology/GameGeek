using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //button to go back to the home page
    protected void btnDone_Click(object sender, EventArgs e)
    {
        //redirect to home page
        Response.Redirect("default.aspx");
    }
    
    //button to confirm payment
    protected void btnPay_Click(object sender, EventArgs e)
    {
        //response message to say the payment has been confirmed
        lblPaid.Text = "The order has been paid, a confirmation email has been sent.";
    }
}