
// using System;
//namespace StudentManagementSystem
//{

//    internal class Program
//    {
//       public  static void Main(String [] args)
//using MySql.Data.MySqlClient;

//{
//Student s1 = new Student();
//s1.Name = "sourabh";
//s1.StudentId = 101;
//s1.Course = "c#";
//s1.Email = "spgedekar9412@gmail.com";
//s1.Age = 24;


//Console.WriteLine("Student ID: " + s1.StudentId);
//Console.WriteLine("Name: " + s1.Name);
//Console.WriteLine("Age: " + s1.Age);
//Console.WriteLine("Email: " + s1.Email);
//Console.WriteLine("Course: " + s1.Course);


//        }
//    }
//}

//-----*-------*---------*-----------*-------------*

  // to check database connection
//    using System;
//    using MySql.Data.MySqlClient;

//namespace StudentManagementSystem
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Database database = new Database();

//            try
//            {
//                using (MySqlConnection connection =
//                       database.GetConnection())
//                {
//                    connection.Open();

//                    Console.WriteLine(
//                        "Database connected successfully!"
//                    );
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Connection failed.");
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//}
//   IGNORE UPPER CODE COMPLETELY
//-----*-------*---------*-----------*-------------*


using System;
using System.Xml.Linq;

namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If Console.ReadLine() returns a value → use it
            // If Console.ReadLine() returns null → use this --> "" instead
            //name store the student name, like wise age,course,email.
            Console.Write("Enter student id: ");
            int id  = Convert.ToInt32(Console.ReadLine() ?? "");
            Console.Write("Enter student name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Enter student age: ");
            int age = int.Parse(Console.ReadLine() ?? "0");   // int.Parse() or Convert.ToInt32() is a method that converts a string into an int.
            Console.Write("Enter student email: ");
            string email = Console.ReadLine() ?? "";
            Console.Write("Enter student course: ");
            string course = Console.ReadLine() ?? "";


            Student student = new Student(id, name, age, email, course);

            // Till this code , I save the data of student object, like:name,course,age,email.
            Console.Write(" student id: " + student.StudentId);
            Console.Write(" student name: " + student.Name);
            Console.Write(" student age: " + student.Age);
            Console.Write(" student email: " + student.Email);
            Console.Write(" student course: " + student.Course);

            StudentService service = new StudentService(); //service is the obj of the StudentService class
            // service.AddStudent(student);     //AddStudent() function  is call by the service object.



            service.UpdateStudent(student);



        }
    }
}
