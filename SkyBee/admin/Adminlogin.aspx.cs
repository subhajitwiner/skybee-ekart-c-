using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Web;
using System.Data;

public partial class Adminlogin : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Initial Catalog=skybee;User Id=root;password='' ");
    protected void Page_Load(object sender, EventArgs e)
    {
      

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = System.Data.CommandType.Text;
        cmd.CommandText = "select * from admin where mailid='"+TextBox1.Text+"'and apassword='"+TextBox2.Text+"'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        da.Fill(dt);
        foreach(DataRow dr in dt.Rows)
        {
            Response.Redirect("insert.aspx");
        }
        con.Close();

        Label1.Text = "Invalid username or Password";
    }

}