using System;

class University
{
    public class Department
    {
        public string DepartmentName;
        public string HODName;
        public int FacultyMembers;

        public Department(string departmentName, string hodName, int facultyMembers)
        {
            DepartmentName = departmentName;
            HODName = hodName;
            FacultyMembers = facultyMembers;
        }

        public void Display()
        {
            Console.WriteLine("Department: " + DepartmentName);
            Console.WriteLine("HOD: " + HODName);
            Console.WriteLine("Faculty Members: " + FacultyMembers);
        }
    }
}

class Que_8
{
    static void Main()
    {
        University.Department d = new University.Department(
            "Computer Science",
            "Rohit Agrawal",
            25
        );

        d.Display();
    }
}
