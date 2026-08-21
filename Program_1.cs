using System;

namespace StudentUtilityApp
{
    class StudentUtility
    {
        public static double CalculatePercentage(double obtainedMarks, double totalMarks)
        {
            return (obtainedMarks / totalMarks) * 100; 
        }

        public static string CalculateGrade(double percentage)
        {
            if (percentage >= 90)
                return "A+";
            else if (percentage >= 80)
                return "A";
            else if (percentage >= 70)
                return "B";
            else if (percentage >= 60)
                return "C";
            else if (percentage >= 50)
                return "D";
            else
                return "F";
        }

        public static double CalculateAttendancePercentage(int attendedDays, int totalDays)
        {
            return ((double)attendedDays / totalDays) * 100;
        }
    }

    class Que_1
    {
        static void Main()
        {
            double percentage = StudentUtility.CalculatePercentage(450, 500);
            string grade = StudentUtility.CalculateGrade(percentage);
            double attendance = StudentUtility.CalculateAttendancePercentage(85, 100);

            Console.WriteLine("Percentage: " + percentage + "%");
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Attendance: " + attendance + "%");
        }
    }
}
