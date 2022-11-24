using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte délku strany a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte délku strany b");
            int b = int.Parse(Console.ReadLine());
            double c = a * a + b * b;
            c = Math.Sqrt(c);
            Console.WriteLine("Délka přepony pravoúhlého trojúhelníku je {0}", c);
            Console.ReadLine();
        }
    }
}