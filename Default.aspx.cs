using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        WCFClient.GrantServiceClient sc = new WCFClient.GrantServiceClient();

        int result = sc.Login(UserBox.Text, PasswordBox.Text);

        if (result != 0)
        {
            Session["userKey"] = result;
            Response.Redirect("ApplyGrants.aspx");

        }
        else
        {
            ResultLabel.Text = "Invalid log in";
        
        }
        
    }
}