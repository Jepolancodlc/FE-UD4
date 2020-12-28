using System;

namespace UD4_e3
{
    class e3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("¿Cuantos años tienes?");
            string años = Console.ReadLine();
            Console.WriteLine("Te llamas {0} y tienes {1}", nombre, años);
        }
    }
}
