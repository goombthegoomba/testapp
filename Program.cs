using System;
using System.Reflection;

namespace Starter
{
    internal class Program
    {
        static int InputInt(string text)
        {
            while (true)
            {
                try
                {
                    Console.Write(text + " ");
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    continue;
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int num0 = InputInt("Input 1st number:");
                int num1 = InputInt("Input 2nd number:");

                if (num0 == num1)
                {
                    Console.WriteLine(num0 + " and " + num1 + " are equal.");
                }
                else
                {
                    Console.WriteLine(num0 + " and " + num1 + " are not equal.");
                }
            }
        }
    }
}