using System;

delegate void Message(string message);

class AS4
{
    static void SendEmail(string message)
    {
        Console.WriteLine("Email: " + message);
    }

    static void SendSMS(string message)
    {
        Console.WriteLine("SMS: " + message);
    }

    static void Main()
    {
        Message m = null;

        m += SendEmail;
        m += SendSMS;

        Console.WriteLine("After adding delegates:");
        m("Welcome!");
        m -= SendSMS;

        Console.WriteLine("\nAfter removing SMS delegate:");
       m("Hello Again!");
    }
}