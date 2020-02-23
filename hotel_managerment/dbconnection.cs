using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace hotel_managerment
{

    class dbconnection
    {
        private OleDbConnection connect = new OleDbConnection();
        private OleDbCommand command = new OleDbCommand();
        public dbconnection(String server = @"VANCHHAI\CHHAISERVER", String dbname = "hotel_management", String username = "chhai", String password = "123")
        {
            string cnn = "Provider=SQLOLEDB;Data source=" + server + ";Initial Catalog=" + dbname + ";User id=" + username + ";password=" + password;
            connect.ConnectionString = cnn;

        }
        public bool execute(String sql)
        {
            try
            {
                connect.Close();
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();

                }
                command.Connection = connect;
                command.CommandText = sql;
                command.ExecuteNonQuery();
                connect.Close();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool Isexist(String sql)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();

                }
                command.Connection = connect;
                command.CommandText = sql;
                var count = command.ExecuteScalar();
                connect.Close();
                if (int.Parse(count.ToString()) >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public DataTable Select(String sql)
        {
            OleDbDataAdapter myData = new OleDbDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            myData.Fill(dt);
            connect.Close();
            return dt;
        }

        public OleDbDataReader GetData(string sql)
        {
            connect.Close();
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            command.Connection = connect;
            command.CommandText = sql;
            //var data = command.ExecuteReader();
            //if (data.HasRows)

            //return data;
            //return null;
            return command.ExecuteReader();
        }
    }
}
