using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class ClassConnetDatabase
    {
        public string strcon = "Data Source=hp;Initial Catalog=cs31_2;User=sa;pwd =1234";
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public void connetDatabasecs31_2()
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
