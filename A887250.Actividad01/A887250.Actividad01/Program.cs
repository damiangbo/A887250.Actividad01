using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A887250.Actividad01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            Console.ReadKey();

            string texto;
            do
            {
                Console.WriteLine("Ingrese algun texto");
                texto = Console.ReadLine();
                Console.WriteLine("Usted ingresó: " + texto);

            } while (texto != "fin");


        }
}
}
