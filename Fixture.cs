using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Digiball
{
    internal class Fixture
    {
        public List<string> teamlist = new List<string>();

        public Fixture()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd;

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Db"].ToString();
            cmd = new("SELECT TOP 10 * FROM Teams ORDER BY NEWID() ", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    teamlist.Add(dr["TeamName"].ToString());
                }
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
