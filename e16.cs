using System;

namespace UD4_e16
{
    class e16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el precio del producto:");
            double precio  = Convert.ToDouble(Console.ReadLine());
            double IVA = (precio * 21 / 100);
            double total = precio + IVA;
            Console.WriteLine("El precio final, IVA incluido es: {0}", total);
        }
    }
}
