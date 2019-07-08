using System;
using System.Data.SQLite;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {

            SQLiteConnection conn = new SQLiteConnection("Data Source=D:\\Code\\kbtu\\2019\\pp2-2019\\Projects\\Lecture11\\sqlite\\ex1.sqlite");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from users where name like '%az%'";

            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (var i = 0; i < reader.FieldCount; i++)
                {
                    string columnName = reader.GetName(i);
                    Object val;

                    if (columnName == "id")
                    {
                        val = reader.GetInt32(i);
                    } else
                    {
                        val = reader.GetString(i);
                    }

                    Console.WriteLine(" Column {0} = {1}", columnName, val);

                }

            }

        }
    }
}
