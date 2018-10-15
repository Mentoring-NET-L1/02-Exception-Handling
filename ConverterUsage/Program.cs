namespace Converter.Console
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                try
                {
                    var convertedValue = inputLine.ToInt32();
                    Console.WriteLine($"convertedValue: '{convertedValue}'");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Error: String can't be empty.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: String has invalid format.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: String too long to convert it to Int32.");
                }
            }
        }
    }
}
