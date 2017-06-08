using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GrantView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
            Response.Redirect("Default.aspx");

        PopulateGrants();
    }

    protected void PopulateGrants()
    {
        WCFClient.GrantServiceClient grsc = new WCFClient.GrantServiceClient();

        int key = (int)Session["userKey"];
        WCFClient.GrantRequest[] grants = grsc.GetGrants(key);

        GrantGrid.DataSource = grants;
        GrantGrid.DataBind();       
    }
}
