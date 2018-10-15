using System;

namespace ExceptionHandling
{
    internal class Program
    {
        private static char GetFirstChar(string line)
        {
            if (string.IsNullOrEmpty(line))
                throw new ArgumentException("Can't be null or empty", nameof(line));

            return line[0];
        }

        private static void Main(string[] args)
        {
            while(true)
            {
                var inputLine = Console.ReadLine();
                try
                {
                    var firstChar = GetFirstChar(inputLine);
                    Console.WriteLine($"First character: '{firstChar}'");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Error: Line shuolde contains at list one symbol.");
                }
            }
        }
    }
}
