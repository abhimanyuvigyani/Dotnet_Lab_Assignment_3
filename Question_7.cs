using System;
using System.Collections.Generic;

class Repository<T>
{
    List<T> list = new List<T>();

    public void Add(T obj)
    {
        list.Add(obj);
    }

    public void Show()
    {
        foreach (T obj in list)
            Console.WriteLine(obj);
    }
}

class Student
{
    public string Name;

    public Student(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}

class Employee
{
    public string Name;

    public Employee(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return "Employee: " + Name;
    }
}

class Que_7
{
    static void Main()
    {
        Repository<Student> students = new Repository<Student>();
        students.Add(new Student("Kirti"));
        students.Add(new Student("Amit"));

        Repository<Employee> employees = new Repository<Employee>();
        employees.Add(new Employee("Kartik"));
        employees.Add(new Employee("Ravi"));

        Console.WriteLine("Students:");
        students.Show();

        Console.WriteLine("\nEmployees:");
        employees.Show();
    }
}
