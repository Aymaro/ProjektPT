using System;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Klient
{
    public class MySqlEngineKlient
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MySqlEngineKlient()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "aymaro.pl";
            //server = "178.19.104.18";
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
                if(connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
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
        //lista studentow
        public List<string>[] SelectStudentList()
        {
            string query = "SELECT UID, Imie, Nazwisko, Rok, Wydzial, Kierunek FROM studenci";

            //Create a list to store the result
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

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
                    list[0].Add(dataReader["UID"] + "");
                    list[1].Add(dataReader["Imie"] + "");
                    list[2].Add(dataReader["Nazwisko"] + "");
                    list[3].Add(dataReader["Rok"] + "");
                    list[4].Add(dataReader["Wydzial"] + "");
                    list[5].Add(dataReader["Kierunek"] + "");
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
        public void InsertStudent(string UID, string Imie, string Nazwisko)
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
        public void UptadeStudent(string UID, string Imie, string Nazwisko)
        {
            if (Imie == "")
                Imie = "Unknown";
            if (Nazwisko == "")
                Nazwisko = "Unknown";


            string query = String.Format("UPDATE studenci SET Imie='{0}', Nazwisko='{1}' WHERE UID= '{2}'", Imie, Nazwisko, UID);

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
        public void UptadeStudentWUID(string UID, string Imie, string Nazwisko, string wUID)
        {
            if (Imie == "")
                Imie = "Unknown";
            if (Nazwisko == "")
                Nazwisko = "Unknown";


            string query = String.Format("UPDATE studenci SET Imie='{0}', Nazwisko='{1}', UID='{3}' WHERE UID= '{2}'", Imie, Nazwisko, UID, wUID);

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
        public void DeleteStudent(string UID)
        {

            string query = String.Format("Delete FROM studenci WHERE UID= '{0}'", UID);

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
        public void UptadeStudentYear(string UID, string Rok, string Wydzial, string Kierunek)
        {
            
            string query = String.Format("UPDATE studenci SET Rok='{0}', Wydzial='{1}', Kierunek='{2}' WHERE UID='{3}'", Rok, Wydzial, Kierunek, UID);

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
        //lista rocznikow
        public List<string>[] SelectYearsList()
        {
            string query = "SELECT id, rok, wydzial, kierunek, liczba FROM roczniki";

            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

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
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["rok"] + "");
                    list[2].Add(dataReader["wydzial"] + "");
                    list[3].Add(dataReader["kierunek"] + "");
                    list[4].Add(dataReader["liczba"] + "");
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
        public void InsertYear(string Rok, string Wydzial, string Kierunek)
        {
            string query = String.Format("INSERT INTO roczniki (rok, wydzial, kierunek) VALUES ('{0}', '{1}', '{2}')", Rok, Wydzial, Kierunek);

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
        public void UptadeYear(string ID, string Rok, string Wydzial, string Kierunek)
        {
            string query = String.Format("UPDATE roczniki SET rok='{0}', wydzial='{1}', kierunek='{2}' WHERE id= '{3}'", Rok, Wydzial, Kierunek, ID);

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
        public void UptadeYearNumberOfStudents(string rok, string wydzial, string kierunek, int liczba)
        {
            string query = String.Format("UPDATE roczniki SET liczba='{3}' WHERE rok= '{0}' AND wydzial='{1} AND kierunek='{2}", rok, wydzial, kierunek, liczba);

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
        public void DeleteYear(string ID)
        {

            string query = String.Format("Delete FROM roczniki WHERE ID= '{0}'", ID);

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
        public void CreateYearTable(string name)
        {

            string query = String.Format("CREATE TABLE `aymaropl_pt`.`{0}` " +
                "(`UID` TEXT NOT NULL)" +
                "ENGINE = InnoDB; ", name);

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
        public void countStudents()
        {
            List<string>[] Lista = new List<string>[5];
            
            Lista = SelectYearsList();

            if (this.OpenConnection() == true)
            {
                for (int i = 0; i < Lista[0].Count; i++)
                {

                    string query = String.Format("SELECT COUNT(*) FROM studenci WHERE rok = '{0}' and wydzial = '{1}' and kierunek = '{2}'", Lista[1][i], Lista[2][i], Lista[3][i]);
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        Lista[4][i] = dataReader.GetString("COUNT(*)");
                    }
                    dataReader.Close();

                    query = String.Format("UPDATE roczniki Set liczba='{3}' WHERE rok = '{0}' and wydzial = '{1}' and kierunek = '{2}'", Lista[1][i], Lista[2][i], Lista[3][i], Lista[4][i]);
                    cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    //close Data Reader
                    

                }
                

                //close Connection
                this.CloseConnection();


            }
            
        }
        //log
        public List<string>[] SelectLog()
        {
            string query = "SELECT a.id,data,a.uid,rdr,b.Imie,b.Nazwisko FROM log a join studenci b on a.UID = b.UID";

            //Create a list to store the result
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
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
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["data"] + "");
                    list[2].Add(dataReader["uid"] + "");
                    list[3].Add(dataReader["rdr"] + "");
                    list[4].Add(dataReader["Imie"] + "");
                    list[5].Add(dataReader["Nazwisko"] + "");
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
        //lista przedmiotow
        public List<string>[] SelectSubjectList()
        {
            string query = "SELECT id_przedmiotu, Nazwa FROM przedmioty";

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();
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
                    list[0].Add(dataReader["id_przedmiotu"] + "");
                    list[1].Add(dataReader["Nazwa"] + "");
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
        //lista wykladowcow
        public List<string>[] SelectTeachersList()
        { 
            string query = "SELECT ID, Imie, Nazwisko, login, haslo FROM wykladowcy";
        

            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
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
                    list[0].Add(dataReader["ID"] + "");
                    list[1].Add(dataReader["Imie"] + "");
                    list[2].Add(dataReader["Nazwisko"] + "");
                    list[3].Add(dataReader["login"] + "");
                    list[4].Add(dataReader["haslo"] + "");
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
        public void InsertTeacher(string Imie, string Nazwisko, string Login, string Haslo)
        {

            string query = String.Format("INSERT INTO wykladowcy (Imie, Nazwisko, login, haslo) " +
                                            "VALUES ('{0}', '{1}', '{2}', '{3}')", Imie, Nazwisko, Login, MD5Hash(Haslo));

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
        public void UptadeTeacher(string ID, string Imie, string Nazwisko, string login, string haslo)
        {
            if (Imie == "")
                Imie = "Unknown";
            if (Nazwisko == "")
                Nazwisko = "Unknown";


            string query = String.Format("UPDATE wykladowcy SET Imie='{0}', Nazwisko='{1}', login='{2}', haslo='{3}'  WHERE ID= '{4}'", Imie, Nazwisko, login, haslo, ID);

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
        public void DeleteTeacher(string ID)
        {

            string query = String.Format("Delete FROM wykladowcy WHERE ID= '{0}'", ID);

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
        public void CreateTeacherTable(string name)
        {

            string query = String.Format("CREATE TABLE `aymaropl_pt`.`{0}` " +
                "(`data` DATE NOT NULL," +
                "`rokstudencki` VARCHAR(45)," +
                "`przedmiot` VARCHAR(45) NOT NULL," +
                "`start` TIME NOT NULL," +
                "`koniec` TIME NOT NULL," +
                "PRIMARY KEY(`data`))" +
                "ENGINE = InnoDB; ", name);

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
        //misc
        public bool CheckIfExist(string name)
        {

            string query = String.Format("SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = 'aymaropl_pt' AND table_name = '{0}'", name);
            bool result = false;
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    result = dataReader.GetBoolean(0);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                if (result == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            return false;
        }
        public void RenameTable(string table, string newName)
        {

            string query = String.Format("RENAME TABLE {0} TO {1};", table, newName);

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
        public List<string> LoginUser(string login, string password)
        {
            string query = String.Format("SELECT ID, Imie, Nazwisko FROM wykladowcy WHERE login = '{0}' and haslo = '{1}'", login, password);

            //Create a list to store the result
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
                    list.Add(dataReader["ID"] + "");
                    list.Add(dataReader["Imie"] + "");
                    list.Add(dataReader["Nazwisko"] + "");
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
        public string MD5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
       
    }
}
