using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            do
            {
                Console.WriteLine("Ingrese su contraseña:");
                x = Console.ReadLine();
            } while (x != "1234");
            Console.WriteLine("Bienvenido de nuevo");

        }
    }
}
