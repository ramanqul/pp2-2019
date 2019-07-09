using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace SQLiteExplorer
{
    public class DatabaseHelper
    {


        private SQLiteConnection dbConnection;
        private string filePath;

        public DatabaseHelper(string filePath)
        {
            this.filePath = filePath;
        }



        private SQLiteConnection getConnection()
        {
            if (dbConnection == null)
            {
                dbConnection = new SQLiteConnection(string.Format("Data Source={0}", filePath));
                dbConnection.Open();
            }

            return dbConnection;
        }


        public DataTable ExecuteQueryAsDataTable(string query)
        {
            DataTable dt = new DataTable();

            SQLiteConnection conn = getConnection();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;

            SQLiteDataReader reader = cmd.ExecuteReader();

            int cnt = 0;

            while (reader.Read())
            {
                if (cnt == 0)
                {
                    for (var i = 0; i < reader.FieldCount; i++)
                    {
                        dt.Columns.Add(reader.GetName(i));

                    }
                    cnt++;
                }

                object[] row = new object[reader.FieldCount];
                reader.GetValues(row);
                dt.Rows.Add(row);
            }

            return dt;
        }
    }
}
