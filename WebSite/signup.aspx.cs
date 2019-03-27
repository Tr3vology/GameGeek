using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class signup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
 
    //button to create an account with the entered details
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        //show a confirmation message
        lblInstructions.Text = "Your account has been created.";
        
    }

    //button to go back to hoe page
    protected void btnDone_Click(object sender, EventArgs e)
    {
        //redirect to home page
        Response.Redirect("Default.aspx");
    }

    //button to have generated password sent to email address
    protected void btnPassword_Click(object sender, EventArgs e)
    {
        
        txtPassword.Visible = true;
        lblPassword.Visible = true;
        btnCreate.Visible = true;
        txtEMail.Enabled = false;
        btnPassword.Visible = false;

        //show instructions on how to log in with the password that has been sent
        lblInstructions.Text = "Do not close this form! Your password has been sent to your email address - type it back into this form.";
    }
}