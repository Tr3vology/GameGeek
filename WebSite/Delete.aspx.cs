﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //button to confirm deletion
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //redirect to main admin page
        Response.Redirect("AdminMain.aspx");
    }

    //button to cancel deletion
    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to main admin page
        Response.Redirect("AdminMain.aspx");
    }
}