using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Klient
{
    class MySqlEngineSerwer
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        
        public MySqlEngineSerwer()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "aymaro.pl";
            database = "aymaropl_pt";
            uid = "aymaropl_admin";
            password = "95^rvT_{T]7#";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public void Insert(string RDR, string UID, string Data)
        {
            string query = "INSERT INTO log (RDR, UID, Data) VALUES ('" + RDR + "', '" + UID + "', '"+ Data + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public void InsertUserUnknown(string UID)
        {
            InsertUser(UID, "Unknown", "Unknown");
        }
        public void InsertUser(string UID, string Imie, string Nazwisko)
        {
            if (Imie == "")
                Imie = "Unknown";
            if (Nazwisko == "")
                Nazwisko = "Unknown";

            string query = String.Format("INSERT INTO studenci (UID, Imie, Nazwisko) SELECT '{0}', '{1}', '{2}' FROM studenci WHERE NOT EXISTS (SELECT * FROM studenci WHERE UID='{0}') LIMIT 1 ;", UID, Imie, Nazwisko);

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public void UptadeUser(string UID, string Imie, string Nazwisko)
        {
            if (Imie == "")
                Imie = "Unknown";
            if (Nazwisko == "")
                Nazwisko = "Unknown";

        
            string query = String.Format("UPDATE studenci SET Imie='{0}', Nazwisko='{1}' WHERE UID= '{2}'", Imie,Nazwisko,UID);

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public List<string> SelectUID()
        {
            string query = "SELECT UID FROM studenci";
            List<string> list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["UID"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        public void checkInStudent(string UID, string fulldate, string hour,string date)
        {

            
            
            string query = String.Format("update obecnosc o set o.data = '{0}' where o.id = (select o.id from zajecia z where o.data='' and z.id = o.wyklad and o.uid = '{1}' and z.data='{2}' and z.poczatek < '{3}' and z.koniec > '{3}')", fulldate, UID, date, hour);

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
    }
}
