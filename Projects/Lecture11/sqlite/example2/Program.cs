using System;
using System.Data.SQLite;

namespace example2
{
    class Program
    {

        private static SQLiteConnection dbConnection;


        private static SQLiteConnection getConnection()
        {
            if (dbConnection == null)
            {
                dbConnection = new SQLiteConnection("Data Source=D:\\Code\\kbtu\\2019\\pp2-2019\\Projects\\Lecture11\\sqlite\\ex1.sqlite");
                dbConnection.Open();
            }

            return dbConnection;
        }

        private static void insertData()
        {
            Console.WriteLine("Enter user id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter user name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter user email:");
            string email = Console.ReadLine();

            SQLiteConnection conn = getConnection();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                string.Format("INSERT INTO USERS VALUES({0}, '{1}', '{2}')", id, name, email);


            int recordsNum = cmd.ExecuteNonQuery();

            if (recordsNum > 0)
            {
                Console.WriteLine("Data was inserted!");
            }


        }

        private static void updateData()
        {
            Console.WriteLine("Which user id you want to update?");
            int userId = int.Parse(Console.ReadLine());

            Console.WriteLine("Which column you want to update?");
            string columnName = Console.ReadLine();

            Console.WriteLine("Enter new value?");
            string newValue = Console.ReadLine();

            SQLiteConnection conn = getConnection();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("UPDATE users set {0}='{1}' where id={2}", columnName, newValue, userId);

            int recordsUpdated = cmd.ExecuteNonQuery();

            if (recordsUpdated > 0)
            {
                Console.WriteLine("Data was updated successfully!");
            }

        }

        private static void selectData()
        {
            SQLiteConnection conn = getConnection();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from users";

            SQLiteDataReader reader = cmd.ExecuteReader();

            int cnt = 0;

            while (reader.Read())
            {
                if (cnt == 0)
                {
                    for (var i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write("{0} ", reader.GetName(i));
                    }

                    Console.WriteLine();

                    cnt++;
                }


                for (var i = 0; i < reader.FieldCount; i++)
                {
                    string columnName = reader.GetName(i);
                    Object val;

                    if (columnName == "id")
                    {
                        val = reader.GetInt32(i);
                    }
                    else
                    {
                        val = reader.GetString(i);
                    }

                    Console.Write("{0} ", val);

                }

                Console.WriteLine();

            }
        }

            private static void deleteData()
        {
            Console.WriteLine("Which user id you want to delete?");
            int userId = int.Parse(Console.ReadLine());

            SQLiteConnection conn = getConnection();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("DELETE FROM users where id={0}", userId);

            int recordsDeleted = cmd.ExecuteNonQuery();

            if (recordsDeleted > 0)
            {
                Console.WriteLine("{0} records were delete successfully!", recordsDeleted);
            }

        }

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Insert data into users");
                Console.WriteLine("2. Update data from users");
                Console.WriteLine("3. Delete data from users");
                Console.WriteLine("4. View users");
                Console.WriteLine("0. Quit");

                int cmd = int.Parse(Console.ReadLine());

                if (cmd == 1)
                {
                    insertData();
                }
                else if (cmd == 2)
                {
                    updateData();
                }
                else if (cmd == 3)
                {
                    deleteData();
                } else if (cmd == 4)
                {
                    selectData();     
                } else
                {
                    break;
                }

            }


        }
    }
}
