using System;

namespace Delegate
{

    class Program
    {
        delegate void LogDel(string text);
        static void Main(string[] args)
        {
            Log log = new Log();

            LogDel logDel = new LogDel(log.LogTextToSreen);

            Console.WriteLine("Please enter your name");

            var name = Console.ReadLine();

            logDel(name);

            Console.ReadKey();
        }

        static void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }
    }

    public class Log
    {
        public void LogTextToSreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }
    }
}
