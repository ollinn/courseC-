using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string? line;
            // reading a line from the console
            
            while ((line = Console.ReadLine()) != null)
            {
                // replace  inputed line , on y:
                line = line.Replace(",", "y:");
                line = "x" + line;
                // line output
                Console.WriteLine(line);
            }
            
        }
    }
}