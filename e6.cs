using System;

namespace UD4_e6
{
    class e6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es el precio del producto?");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pagara en efectivo o targeta?");
            string metodoDePago = Console.ReadLine().ToLower();

       
            if (metodoDePago == "efectivo")
            {
                Console.WriteLine("Introduzca numero de cuenta");
                int numCuenta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Gracias por su compra");
            }
            else
            {
                Console.WriteLine("Gracias por su compra");
            }
        }
    }
}
