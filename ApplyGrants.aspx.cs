using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ApplyGrants : System.Web.UI.Page
{
    private decimal amount;
    private int result;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void Submit_Click(object sender, EventArgs e)
    {

        WCFClient.GrantServiceClient gc = new WCFClient.GrantServiceClient();
        decimal amount;

        WCFClient.GrantRequest gr = new WCFClient.GrantRequest();

        bool GrantRequestKey = decimal.TryParse(GrantAmountBox.Text, out amount);

        gr.PersonKey = (int)Session["userKey"];

        if (GrantRequestKey)
        {
            gr.GrantRequestAmount = amount;
            gr.GrantRequestDate = DateTime.Now;
            int? person = null;
            gr.PersonKey = person;

            Response.Redirect("GrantView.aspx");
        }

    }

}
      