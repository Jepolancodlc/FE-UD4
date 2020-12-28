using System;

namespace UD4_e2
{
    class e2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de una ciudad");
            string ciudad = Console.ReadLine();
            Console.WriteLine("Hola {0} bienvenido a {1}", nombre, ciudad);
          
        }
    }
}
