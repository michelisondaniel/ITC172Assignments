using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitRegButton_Click(object sender, EventArgs e)
    {
        //string userName = RegUserName.Text;
        string lastName = RegLastName.Text;
        string firstName = RegFirstName.Text;
        string email = RegEmail.Text;
        string password = ConfirmPassword.Text;

        WCFClient.GrantServiceClient sc = new WCFClient.GrantServiceClient();
        WCFClient.PersonInfo req = new WCFClient.PersonInfo();
        req.lastname = lastName;
        req.firstname = firstName;
        req.email = email;
        req.password = password;

        bool result = sc.RegisterPerson(req);
        if (result)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Something went terribly wrong...";
        }


    }
}