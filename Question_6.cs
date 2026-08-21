using System;

//record Student(int RollNumber, string Name, string Course, int Semester);

class Program6
{
    record Student(int RollNumber, string Name, string Course, int Semester);
    static void Main()
    {
        Student s1 = new Student(102, "Kartik", "MCA", 2);
        Student s2 = new Student(101, "Kartik", "MCA", 2);

        Console.WriteLine("Student 1: " + s1);
        Console.WriteLine("Student 2: " + s2);

        if (s1 == s2)
            Console.WriteLine("Both students are equal.");
        else
            Console.WriteLine("Both students are not equal.");
    }
}
