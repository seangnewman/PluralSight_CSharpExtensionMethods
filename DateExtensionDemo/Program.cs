using System;
using ExtensionMethods.Contracts;

namespace DateExtensionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Starting {DateTime.Now.ToUnixSeconds()}");
        }
    }
}
