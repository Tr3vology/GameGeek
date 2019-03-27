using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //bool variable for logged in
    Boolean LoggedIn;

    // see if user is logged in
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            LoggedIn = (Boolean)Session["LoggedIn"];
        }
        catch
        {
            LoggedIn = false; ;
        }

        Login(LoggedIn);
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        Session["LoggedIn"] = LoggedIn;
    }

    //log the user into the system
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        if (LoginOK(txtUserName.Text, txtPassword.Text) == true)
        {
            LoggedIn = true;
            Login(LoggedIn);
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
        else
        //error message
        {
            lblError.Text = "You must enter a valid user name and password.";
        }
    }

    //make sure the text boxes are not blank to log in
    Boolean LoginOK(string UserName, string Password)
    {
        if (UserName != "" & Password != "")
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    void Login(Boolean State)
    {
       
        btnChange.Visible = State;
        btnBasket.Visible = State;
        btnLogout.Visible = State;
    }

    //button to go to next game
    protected void btnRight_Click(object sender, EventArgs e)
    {
        RotateImagesL();
    }

    //rotate the images right
    void RotateImagesL()
    {
        img1.ImageUrl = img2.ImageUrl;
        img2.ImageUrl = img3.ImageUrl;
        if (img3.ImageUrl.Contains("1.jpg"))
        {
            img3.ImageUrl = "2.jpg";
        }
        else if (img3.ImageUrl.Contains("2.jpg"))
        {
            img3.ImageUrl = "3.jpg";
        }
        else if (img3.ImageUrl.Contains("3.jpg"))
        {
            img3.ImageUrl = "4.jpg";
        }
        else if (img3.ImageUrl.Contains("4.jpg"))
        {
            img3.ImageUrl = "1.jpg";
        }
    }

    //button to go to the previous game
    protected void btnLeft_Click(object sender, EventArgs e)
    {
        RotateImagesR();
    }

    //rotate the images left
    void RotateImagesR()
    {
        img3.ImageUrl = img2.ImageUrl;
        img2.ImageUrl = img1.ImageUrl;
        if (img1.ImageUrl.Contains("1.jpg"))
        {
            img1.ImageUrl = "4.jpg";
        }
        else if (img1.ImageUrl.Contains("2.jpg"))
        {
            img1.ImageUrl = "1.jpg";
        }
        else if (img1.ImageUrl.Contains("3.jpg"))
        {
            img1.ImageUrl = "2.jpg";
        }
        else if (img1.ImageUrl.Contains("4.jpg"))
        {
            img1.ImageUrl = "3.jpg";
        }
    }

    //button to sign up to the system
    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        //redirect to sign up page
        Response.Redirect("signup.aspx");
    }

    //button to view cart
    protected void btnManageSwaps_Click(object sender, EventArgs e)
    {
        //redirect to Shopping Cart page
        Response.Redirect("ShoppingCart.aspx");
    }

    //button to see more details about a game
    protected void btnDetails_Click(object sender, EventArgs e)
    {
        //redirect to the game detail page
        Response.Redirect("GameDetail.aspx");
    }

    //button to resend password
    protected void btnResend_Click(object sender, EventArgs e)
    {
        //redirect tot he resend password page
        Response.Redirect("resend.aspx");
    }

    //button to change password
    protected void btnChange_Click(object sender, EventArgs e)
    {
        //rdirect to change password page
        Response.Redirect("changepassword.aspx");
    }

    //button to log out
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        //set value of logged in to false to log user out of the system
        LoggedIn = false;
        Login(LoggedIn);
    }

    //button to search for the typed game
    protected void btnSearch0_Click(object sender, EventArgs e)
    {
        //telll the user how many results are found
        lblResultsCount.Text = "Four items found";
    }

    //button to clear search
    protected void btnClear_Click(object sender, EventArgs e)
    {
        //resets the number of results found
        lblResultsCount.Text = "";
    }


    //button to go to checkout
    protected void btnCheckOut_Click(object sender, EventArgs e)
    {
        //go to checkout page
        Response.Redirect("Payment Page.aspx");
    }

    //button to view account details
    protected void btnAccDetails_Click(object sender, EventArgs e)
    {
        //redirect to account details page
        Response.Redirect("Account.aspx");
    }

    //button to ask for help
    protected void btnHelp_Click(object sender, EventArgs e)
    {
        //show instructions on how to browse games
        lblHelp.Text = "Use the arrows to browse our selection of games, or search for one in the textbox above. To order or see more details click on the details button.";
    }

    //button to contact us
    protected void btnContactUs_Click(object sender, EventArgs e)
    {
        //redirect to contact us page
        Response.Redirect("ContactUS.aspx");
    }

    //button to view shopping basket
    protected void btnBasket_Click(object sender, EventArgs e)
    {
        //redirect to the shopping basket page
        Response.Redirect("Basket.aspx");
    }

    //log into the admin side of the website
    protected void btnAdminLogIn_Click(object sender, EventArgs e)
    {
        //redirect to the admin login page
        Response.Redirect("AdminLogIn.aspx");
    }
}