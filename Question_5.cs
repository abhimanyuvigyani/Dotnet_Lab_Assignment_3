using System;

class Que_5
{
    static void Main()
    {
        Vehicle v = new Vehicle();

        v.Brand = "Toyota";
        v.Model = "Fortuner";
        v.Year = 2024;

        v.DisplayInfo();
        v.Start();
        v.Stop();
    }
}
