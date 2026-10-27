using System;


using MySql.Data.MySqlClient;  //namespace

namespace StudentManagementSystem
{
    public class Database
    {
        // private:accessible only within class || readonly:can't be reassign after initialization
        //string:dataType  || connectionString:variable to store string data
        private readonly string connectionString =    //connectionString:-Store Database connection settings as text
            "Server=localhost;Database=StudentDB;Uid=root;Pwd=211940@sourabh;";

        //MySqlConnection: return type of method GetConnection()
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);  //Creates a connection object using those settings
            //It returns a MySqlConnection object.
            //This object contains the information needed to connect to the MySQL database.
        }
    }
}
