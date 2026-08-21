using System;

sealed class AppConfig
{
    public static string ConnectionString = "Server=localhost;Database=CollegeDB;";
    public static string AppName = "GLA FriendsBook";
    public static string Version = "1.0";

    private AppConfig()
    {
    }

    public static void Display()
    {
        Console.WriteLine("App Name: " + AppName);
        Console.WriteLine("Version: " + Version);
        Console.WriteLine("Connection: " + ConnectionString);
    }
}

class Que_9
{
    static void Main()
    {
        AppConfig.Display();
    }
}
