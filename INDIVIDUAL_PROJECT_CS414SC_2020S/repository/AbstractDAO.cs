using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.repository
{
    class AbstractDAO
    {

        SqlConnection conn;

        public AbstractDAO()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\My Project VS 2019\INDIVIDUAL_PROJECT_CS414SC_2020S\INDIVIDUAL_PROJECT_CS414SC_2020S\QLNS.mdf;Integrated Security=True";
            conn = new SqlConnection(connectionString);
        }

        public void open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public DataTable queryForList(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            open();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            close();
            return dt;
        }

        public int executeUpdate(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            open();
            int k = cmd.ExecuteNonQuery();
            close();
            return k;
        }

        public object scalar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            open();
            object k = cmd.ExecuteScalar();
            close();
            return k;
        }


    }
}
