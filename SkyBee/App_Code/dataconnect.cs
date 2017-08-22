using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Web;
using MySql.Data.MySqlClient;
public class dataconnect
{
    MySqlConnection con;
    string errchk;
    public dataconnect()
    {
        con = new MySqlConnection();
        con.ConnectionString = "server=localhost;userid=root;database=skybee";
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Mail Id"></param>
    /// <param name="Phone Number"></param>
    /// <param name="Pan Number"></param>
    /// <returns></returns>
    public int userchk(string mail,string phone,string pan_no)
    {
        con.Open();
        MySqlCommand cmd;
        MySqlDataReader reader;
        string sql = "SELECT * FROM `user` WHERE mailid='"+mail+"' AND phone='"+phone+"' AND panno='"+pan_no+"'";
        cmd = new MySqlCommand(sql, con);
        int count = 0;
        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            count = count + 1;
        }
        con.Close();
        return count;
    }
    /// <summary>
    /// this a program for user sign up
    /// </summary>
    /// <param name="First name"></param>
    /// <param name="Last name"></param>
    /// <param name="Email id"></param>
    /// <param name="Date of birth"></param>
    /// <param name="Phone number"></param>
    /// <param name="Address"></param>
    /// <param name="Profile picture"></param>
    /// <param name="Pan number"></param>
    /// <param name="Password"></param>
    /// <returns>submit correctly</returns>
    public string signup(string fname,string lname,string mail,string dob,string phone,string addr,string profilepic, string panno,string password)
    {
        try
        {
            con.Open();
            MySqlCommand cmd1;
            MySqlDataReader reader1;
            string sql = "INSERT INTO `user` " +
            "(`fname`, `lstname`, `mailid`, `dob`, `phone`, `addr`, `proflpic`, `panno`, `password`)" +
            " VALUES ('" + fname + "', '" + lname + "', '" + mail + "', '" + dob + "', '" + phone + "', '" + addr +
            "', '" + profilepic + "', '" + panno + "', '" + password + "')";
            cmd1 = new MySqlCommand(sql, con);
            reader1 = cmd1.ExecuteReader();
            reader1.Read();
            con.Close();
            return "data inserted";
                
        }
        catch(Exception ex)
        {
            return ex.ToString();
        }
        
    }


  /// <summary>
  /// 
  /// </summary>
  /// <param name="Email Id"></param>
  /// <param name="Password"></param>
  /// <returns>
  /// <paramref result[0]="First Name"/>
  /// <paramref result[1]="Last Name"/>
  /// <paramref result[2]="Mail Id"/>
  /// <paramref result[3]="Profile Picture"/>
  /// </returns>
    public string [] login_use(string email,string password)
    {
        con.Open();
        MySqlCommand cmd3;
        MySqlDataReader reader3;
        string sql3 = "SELECT * FROM `user` WHERE mailid='"+email+"' AND password='"+password+"'";
        cmd3 = new MySqlCommand(sql3, con);
        reader3 = cmd3.ExecuteReader();
        string[] result = new string[4];
        if (reader3.Read())
        {
            result[0] = reader3.GetValue(0).ToString();
            result[1] = reader3.GetValue(1).ToString();
            result[2] = reader3.GetValue(2).ToString();
            result[3] = reader3.GetValue(6).ToString();
            con.Close();
            return result;
        }
        else
        {
            result[0] = "data not found";
            result[1] = "data not found";
            result[2] = "data not found";
            result[3] = "data not found";
            con.Close();
            return result;
        }
    }


    /// <summary>
    /// Place order for mobile
    /// </summary>
    /// <param name="mail_id"></param>
    /// <param name="product_name"></param>
    /// <param name="product_price"></param>
    /// <returns></returns>
    public string make_order(string mail_id,string product_name,int product_price)
    {
        try
        {
            con.Open();
            MySqlCommand cmd4;
            MySqlDataReader reader4;
            string sql4= "INSERT INTO `product_order`" +
                " (`order_id`, `mail_id`, `order_date`, `product_name`, `item_ordered`, `total_price`)" +
                " VALUES (NULL, '"+mail_id+"', CURRENT_DATE(), '"+product_name+"', '1', '"+product_price+"')";
            cmd4 = new MySqlCommand(sql4,con);
            reader4 = cmd4.ExecuteReader();
            reader4.Read();
            con.Close();
            con.Open();
            MySqlCommand cmd5;
            MySqlDataReader reader5;
            string sql5 = "UPDATE product SET tqty = tqty - 1 WHERE product.pname = '"+product_name+"'";
            cmd5 = new MySqlCommand(sql5, con);
            reader5 = cmd5.ExecuteReader();
            reader5.Read();
            con.Close();
            return "mobile ordered";
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }
    
}
