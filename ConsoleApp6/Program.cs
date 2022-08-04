using System;
using System.Diagnostics;
EventLog eventLog = new EventLog();

eventLog.Source = "NewSource";
class MySample
{

    EventLog eventLog = new EventLog();

    eventLog.Source ="NewSource";
    public static void Main()
    {
        EventLog[] remoteEventLogs;

        remoteEventLogs = EventLog.GetEventLogs("myServer");

        Console.WriteLine("Number of logs on computer: " + remoteEventLogs.Length);

        foreach (EventLog log in remoteEventLogs)
        {
            Console.WriteLine("Log: " + log.Log);
        }
    }
}