using System;
using System.Threading;

public class Client
{
    private Random _random = new Random();

    private void ReadServerCount()
    {
        var count = Server.GetCount();
        Console.WriteLine("Client " + Thread.CurrentThread.Name + " read server count: " + count);
    }

    private void AddToServerCount(int value)
    {
        Server.AddToCount(value);
        Console.WriteLine("Client " + Thread.CurrentThread.Name + " added " + value + " to server count.");
    }

    public void Run()
    {
        Thread.Sleep(_random.Next(100, 1000));
        var isRead = _random.Next(0, 2) == 0;
        if (isRead)
        {
            ReadServerCount();
        }
        else
        {
            int value = 1;
            AddToServerCount(value);
        }
    }
}