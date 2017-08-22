using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;

public partial class productlist : System.Web.UI.Page
{
    protected string[] brand_id;
    protected string[] product_id;
    protected string[] product_name;
    protected string[] product_picture;
    protected string[] total_quantity;
    protected string[] product_rate;
    protected int total_product;
    protected void Page_Load(object sender, EventArgs e)
    {

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = "server=localhost;userid=root;database=skybee";

        try
        {
            con.Open();
            MySqlCommand cmd;
            MySqlDataReader reader;
            string sql = "SELECT COUNT(pname) total_product FROM `product` ";
            cmd = new MySqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                total_product = int.Parse(reader.GetString("total_product"));

                brand_id = new string[total_product];
                product_id = new string[total_product];
                product_name = new string[total_product];
                product_picture = new string[total_product];
                total_quantity = new string[total_product];
                product_rate = new string[total_product];

                con.Close();
                Response.Write(total_product);
            }
            else
            {
                Response.Write("error occur");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
        try
        {
            con.Open();
            MySqlCommand cmd1;
            MySqlDataReader reader1;
            string sql1 = "SELECT * FROM `product` ";
            cmd1 = new MySqlCommand(sql1, con);
            reader1 = cmd1.ExecuteReader();
            for (int i = 0; reader1.Read(); i++)
            {
                brand_id[i] = reader1.GetString("brandid").ToString();
                product_id[i] = reader1.GetString("pid").ToString();
                product_name[i] = reader1.GetString("pname").ToString();
                product_picture[i] = reader1.GetString("product_pic").ToString();
                total_quantity[i] = reader1.GetString("tqty").ToString();
                product_rate[i] = reader1.GetString("pprice").ToString();
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
    }


    protected void bye_product(object sender, EventArgs e)
    {
        
    }
}