namespace WebJob
{
    using System;
    using System.Threading;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting webjob...");

            Console.WriteLine("Shutting down webjob...");

            Thread.Sleep(3000);
        }
    }
}
