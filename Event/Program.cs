using System;
 class Event
{
    public delegate void info();

    public static event info events;
    static  void Main()
    {
        events += ShowMessage;
        events?.Invoke();

    }
    static void ShowMessage()
    {
        Console.WriteLine("Event Is Triggered");
            }
}