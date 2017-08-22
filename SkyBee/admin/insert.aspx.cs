using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class insert : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Initial Catalog=skybee;User Id=root;password='' ");

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
       FileUpload1.SaveAs(Server.MapPath("../product_pic") + "/" + FileUpload1.FileName);
          string path = "product_pic/" + FileUpload1.FileName;
  try
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into product " +
                "values('" + brandID.Text + "','" + productID.Text + "','" + productNAME.Text + "','" + path + "','" + productQUANTITY.Text + "','" + productRATE.Text + "') ";

            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Product added Successfully....";
        }
        catch(Exception ex)
        {
            Response.Write(ex);
        }
        


    }


    /// <summary>
    /// variable product id and product name 
    /// </summary>
    protected string[] product_id;
    protected string[] product_name;
    protected int total_product = 0;

    protected void Button2_Click(object sender, EventArgs e)
    {
        
        string brnd = DropDownList1.SelectedValue;
        try
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost;userid=root;database=skybee";
            connection.Open();
            MySqlCommand cmd2;
            MySqlDataReader reader2;
            string sql2 = "select count(pid) total_product from product where brandid='" + brnd + "' ";
            cmd2 = new MySqlCommand(sql2, connection);
            reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                total_product = int.Parse(reader2.GetString("total_product"));
            }
            connection.Close();
            connection.Open();
            
            product_id = new string[total_product];
            product_name = new string[total_product];
            string sql3 = "select pid,pname from product where brandid='" + brnd + "' ";
            MySqlCommand cmd3;
            MySqlDataReader reader3;
            cmd3 = new MySqlCommand(sql3, connection);
            reader3 = cmd3.ExecuteReader();
            for (int i=0; reader3.Read();i++)
            {
                product_id[i] = reader3.GetString("pid").ToString();
                product_name[i] = reader3.GetString("pname").ToString();
            }
            Response.Write("<table style='position:absolute; left: 443px; top: 100px; width: 300px;text-align:center; ' ");
            Response.Write("<tr><td><h4>PRODUCT ID</h4></td><td><h4>PRODUCT NAME</h4></td><br></tr>");
            for (int i = 0; i < total_product; i++)
            {
                Response.Write("<tr><td>"+product_id[i]+"</td><td>"+product_name[i]+"</td><br></tr>");
            }
                Response.Write("</table>");
        }
        catch (Exception ex)
        {
            Label2.Text = ex.ToString();
        }

    }
}