﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DonationsList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] != null)
        {
            Community_AssistEntities db = new Community_AssistEntities();
            int key = (int)Session["userKey"];
            var don = (from d in db.Donations
                       where d.PersonKey == key
                       select d).ToList();
            DonationGrid.DataSource = don;
            DonationGrid.DataBind();

        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
}