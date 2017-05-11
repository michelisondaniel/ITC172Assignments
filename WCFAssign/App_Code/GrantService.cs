using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GrantService" in code, svc and config file together.
public class GrantService : IGrantService
{
    Community_AssistEntities db = new Community_AssistEntities();
    public List<GrantRequest> GetGrants()
    {
        var GrantReq = from g in db.GrantRequests
                       select g;

        List<GrantRequest> grants = new List<GrantRequest>();

        foreach(var gr in GrantReq)
            // loop through the request to write each field to the grant request
        {
            GrantRequest grants1 = new GrantRequest();
            grants1.GrantRequestDate = gr.GrantRequestDate;
            grants1.GrantRequestAmount = gr.GrantRequestAmount;
            grants1.PersonKey = gr.PersonKey;
            grants1.GrantTypeKey = gr.GrantTypeKey;

            grants.Add(grants1);
        }
        return grants;
    }
}
