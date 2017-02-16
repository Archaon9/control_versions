using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_Versions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, suma;

            Console.WriteLine("Entra primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entra primer numero");
            b = Convert.ToInt32(Console.ReadLine());

            suma = a + b;

            Console.WriteLine("La suma es: " + suma);
        }
    }
}
