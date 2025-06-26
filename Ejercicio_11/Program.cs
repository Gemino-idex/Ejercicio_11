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
            //declaramos variables
            string x;
            //do es para repetir una acción pero se evalue al final en while
            do
            {
                Console.WriteLine("Ingrese su contraseña:");
                x = Console.ReadLine();
                //while va al final para verificar si la información es correcta no se vuelve a ejecutar
            } while (x != "1234");
            Console.WriteLine("Bienvenido de nuevo");

        }
    }
}
