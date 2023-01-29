using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace lasaCollege
{
    internal class connection
    {
        public string strcon = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=lasaCollege;Integrated Security=True";
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public void lasaConnectionDatabase()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
            cn.ConnectionString = strcon;
            cn.Open();
        }
    }
}
