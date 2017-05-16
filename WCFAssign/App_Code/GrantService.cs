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

    //public List<GrantReview> GetGrantReviews(int grantkey)
    //{
    //    var grts = from g in db.GrantReviews
    //               from gr in db.People
    //               where g.GrantRequestKey==grantkey
    //               select g;


    //}

    

    public int Login(string user, string password)
    {
        int key = 0;
        int result = db.usp_Login(user, password);
        if (result != -1)
        {
            var userKey = (from k in db.People
                          where k.PersonEmail.Equals(user)
                          select k.PersonKey).FirstOrDefault();
            key = (int)userKey;
        }

        return key;
    }

    public bool NewGrant(GrantRequest r)
    {
        bool result = true;
        try
        {

            GrantReview grantrev = new GrantReview();
            grantrev.GrantRequest = r;
            grantrev.GrantRequestStatus = "Pending";
            grantrev.GrantReviewDate = DateTime.Now;

            db.GrantRequests.Add(r);
            db.GrantReviews.Add(grantrev);
            db.SaveChanges();
        }
        catch (Exception ex)
        {
            result = false;
        }
        return result;
    }

    public bool RegisterPerson(PersonInfo pi)
    {
        bool result = true;
        int reg = db.usp_Register(pi.lastname,
            pi.firstname, pi.email, pi.password, pi.ApartmentNumber, 
            pi.Street, pi.City, pi.State, 
            pi.Zipcode, pi.HomePhone, pi.WorkPhone);

        return result;
    }

}
