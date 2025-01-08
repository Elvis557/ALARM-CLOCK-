using System;
using System.Threading;

class AlarmClock {
    static void Main() {
        Console.Write("Set alarm time (hh:mm:ss): ");
        string alarmTime = Console.ReadLine();
        
        while (true) {
            if (DateTime.Now.ToString("HH:mm:ss") == alarmTime) {
                Console.WriteLine("ALARM! Wake up!");
                break;
            }
            Thread.Sleep(1000);
        }
    }
}
