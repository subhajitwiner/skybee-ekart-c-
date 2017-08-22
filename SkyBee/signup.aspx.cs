using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class signup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void useuser_signup(object sender, EventArgs e)
    {
        string pass1 = password1.Value;
        string pass2 = password2.Value;
        if (pass1==pass2)
        {
            dataconnect db = new dataconnect();
            int count = db.userchk(email.Value,phone.Value,pan_no.Value);
            if (count == 0)
            {
                Response.Write(count);
                FileUpload1.SaveAs(Server.MapPath("profile_picture") + "/" +phone.Value+FileUpload1.FileName);
                string file_addr = "profile_picture/" +phone.Value+FileUpload1.FileName;
                string s = db.signup(fname.Value, lname.Value, email.Value, dob.Value, phone.Value, address.Value, file_addr, pan_no.Value, password1.Value);
                Response.Write("<script>alert('"+s+"')</script>");
                Response.Redirect("index.aspx");
            }
            else
            {
                Response.Write("<script>alert('account already exist')</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('Password not match')</script>");
        }

    }

}