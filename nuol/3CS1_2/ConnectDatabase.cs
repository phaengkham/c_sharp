using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassConnectDatabase;

namespace _3CS1_2
{
    class ConnectDatabase
    {
        public string strcon = @"Data Source=DESKTOP-HPV6EF6;Initial Catalog=CS1_2;Integrated Security=True";
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public void ConnectDatabase3CS1_2()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            conn.ConnectionString = strcon;
            conn.Open();
        }
    }
}
