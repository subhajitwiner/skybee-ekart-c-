using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Structure : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void button_click_login(object sender,EventArgs e)
    {
        dataconnect db = new dataconnect();
        string[] result = db.login_use(uid.Value, pass.Value);
        if (result[2] != uid.Value)
        {
            @out.Text = "user not in database";
        }
        else
        {
            Session["mail_id"] = result[2];
            Session["fname"] = result[0];
            Session["lname"] = result[1];
            Session["prof_pic"] = result[3];
            Response.Redirect("productlist.aspx");
        }
    }
    protected void button_click_signup(object sender, EventArgs e)
    {
        Response.Redirect("~/signup.aspx");
    }
}
