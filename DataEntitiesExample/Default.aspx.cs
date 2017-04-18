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
        int key = 0; //default key
        BookReviewDbEntities1 db = new BookReviewDbEntities1();
        int success = db.usp_ReviewerLogin(UserTextBox.Text, PasswordTextBox.Text);
        if(success != -1)
        {
            var uKey = (from k in db.Reviewers
                        where k.ReviewerUserName.Equals(UserTextBox.Text)
                        select k.ReviewerKey).FirstOrDefault();

            key = (int)uKey;
            Session["userKey"] = key; //Session is a cookie for a users interactions during that visit to the webpage but is stored server side
            ResultLabel.Text = "Welcome" + key.ToString(); 

        }
        else
        {
            ResultLabel.Text = "Invalid Login";
        }
    }
}