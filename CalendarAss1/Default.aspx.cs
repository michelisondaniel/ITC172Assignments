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
     
  

    protected void EventCalendar_SelectionChanged(object sender, EventArgs e)
    {
        EventLabel.Text = "";
        string[,] events = new string[6, 2];

        events[0, 0] = "Potluck at the Park";
        events[0, 1] = "4/20/2017";
        events[1, 0] = "Social Dance";
        events[1, 1] = "4/22/2017";
        events[2, 0] = "Team Baseball Game";
        events[2, 1] = "4/23/2017";
        events[3, 0] = "Drinking with your coworkers";
        events[3, 1] = "4/25/2017";
        events[4, 0] = "Going to the waterpark";
        events[4, 1] = "4/30/2017";
        events[5, 0] = "Social gathering";
        events[5, 1] = "4/30/2017";

        string dates = EventCalendar.SelectedDate.ToShortDateString();
        
        for (int i = 0; i < 6; i++)
        {
            if (dates.Equals(events[i, 1]))
            {
                EventLabel.Text += events[i, 0] + "<br/>";
            }
            
        }

        if (EventLabel.Text == "") EventLabel.Text = dates;
    }
}
