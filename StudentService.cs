
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public class StudentService
    {
        private readonly Database database = new Database(); //object of Database class-database
        public void AddStudent(Student student)  //function AddStudent() takes student variable of Student type
        {

            //query is a variable of string type, store sql query like text 
            string query = @"INSERT INTO Students
                             (Name, Age, Email, Course)
                             VALUES
                             (@Name, @Age, @Email, @Course)";

            using (MySqlConnection connection = database.GetConnection())  
                //Creates a connection object using those settings
                // database.GetConnection return --> MySqlConnection object.
                // that object contains the information needed to connect to the MySQL database.
            {
                connection.Open(); //The actual database connection is established
                                  
                using (MySqlCommand command =             //sending the message
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@Age", student.Age);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@Course", student.Course);

                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Student added successfully!");
        }
    }
}
