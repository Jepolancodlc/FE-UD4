using System;

namespace UD4_e14
{
    class e14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el radio");
            double radio = Convert.ToDouble(Console.ReadLine());
            double total = Math.Pow(radio, 2) * Math.PI;


            Console.WriteLine("El area del circulo es de {0}", total);
        }
    }
}
