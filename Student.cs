
namespace StudentManagementSystem
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Course { get; set; } = "";

        private int age; //Private field --> Stores the actual integer value, Cannot be accessed directly from outside the class
        public int Age  //Public property --> Controls access to the value, Can be accessed from outside the class
        {
            get { return age; }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }


        public Student()
        {

        }

        //Student student = new Student(1, "Rahul", 21, "rahul@example.com", "C#"); we can create object like this.
        public Student(int studentId, string name, int age, string email, string course)
        {
            StudentId = studentId;
            Name = name;
            Age = age;
            Email = email;
            Course = course;
        }
    }
}

