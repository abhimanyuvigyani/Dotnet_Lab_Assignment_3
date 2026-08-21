using System;

abstract class Notification
{
    public abstract void SendNotification();
}

class EmailNotification : Notification
{
    public override void SendNotification()
    {
        Console.WriteLine("Email notification sent.");
    }
}

sealed class SpecialNotification : EmailNotification
{
    public void SendSpecialNotification()
    {
        Console.WriteLine("Special notification sent.");
    }
}

class Program
{
    static void Main()
    {
        EmailNotification email = new EmailNotification();
        email.SendNotification();

        SpecialNotification special = new SpecialNotification();
        special.SendNotification();
        special.SendSpecialNotification();
    }
}
