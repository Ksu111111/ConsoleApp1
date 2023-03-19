using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void NewFeature(string name)
        {
            Console.WriteLine($"Привет, {name}, ты лошара)");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            NewFeature(name);
            Console.WriteLine("Ля ля ля");
        }
    }
}
