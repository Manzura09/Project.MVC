using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC.App.Models
{
    public class Datacomponent
    {
        static string CONNECTIONSTRING = "Data Source=RILPT190;Initial Catalog = BoutiqueShop; User ID = sa; Password=sa123";
        public List<BoutiqueModel> GetAllBoutique()
        {
            var list = new List<BoutiqueModel>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {

                try
                {
                    con.Open();
                    SqlCommand sqlCmd = con.CreateCommand();
                    sqlCmd.CommandText = "SELECT *FROM BoutiqueShop";
                    var reader = sqlCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var std = new BoutiqueModel();
                        std.ShopId = Convert.ToInt32(reader[0]);
                        std.ShopName = reader[1].ToString();
                        std.ShopAddress = reader[2].ToString();
                        std.DressStyle = reader[3].ToString();
                        std.DressCost = Convert.ToInt32(reader[4]);

                        list.Add(std);
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            return list;
        }
    }
}
public void AddNewDresses(BoutiqueShop)
{
    using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
    {
        var query = "Insert into BoutiqueShop values(@id,@name,@type,@dress,@price)";
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@id", ShopId);
        cmd.Parameters.AddWithValue("@name",ShopName);
        cmd.Parameters.AddWithValue("@address", ShopAddress);
        cmd.Parameters.AddWithValue("@style",DressStyle);
        cmd.Parameters.AddWithValue("@cost",DressCost);
        try
        {
            con.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            if (rowAffected == 0)
                throw new Exception("No Details Were Added");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }
}

public class BoutiqueShop
{
}