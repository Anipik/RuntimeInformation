using System;
using System.Runtime.InteropServices;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RuntimeInformation.OSDescription.Contains("Ubuntu", StringComparison.InvariantCultureIgnoreCase));
            Console.ReadLine();
        }
    }
}
