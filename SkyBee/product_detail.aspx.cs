using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;

public partial class product_detail : System.Web.UI.Page
{
    protected string product_img;
    protected int product_quantity;
    protected string product_name;
    
    protected int product_price;

    protected void Page_Load(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = "server=localhost;userid=root;database=skybee";
        product_name = Request["but1"];
        try
        {
            string sql = "select * from `product` where pname='"+product_name+"'";
            con.Open();
            MySqlCommand cmd=new MySqlCommand(sql,con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                 product_img = reader.GetString("product_pic");
                 product_quantity = int.Parse(reader.GetString("tqty"));
                product_price = int.Parse(reader.GetString("pprice"));
                
            }
            con.Close();
            
        }
        catch(Exception ex)
        {
            Response.Write(ex);
        }
    }

    protected void bye_ServerClick(object sender, EventArgs e)
    {
        string mail_id = Session["mail_id"].ToString();
        dataconnect dt = new dataconnect();
        if (product_quantity > 0)
        {
            fidback.Text = dt.make_order(mail_id, product_name,product_price);
            
        }
        else
        {
            fidback.Text = "this item is out of stock";
        }
    }
}