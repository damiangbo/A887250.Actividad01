using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
     
            Console.WriteLine(nombre.ToUpper());
            Console.ReadKey();
        }
}
}
