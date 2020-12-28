using System;

namespace UD4_e20
{
    class e20
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("Cuantas ventas hara?");
            int nVentas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nVentas; i++)
            {
                Console.WriteLine("El precio de la venta n* {0}", i +1);
                double precioVenta = Convert.ToDouble(Console.ReadLine());
                
                total = precioVenta + total;
            }
            Console.WriteLine("El total es igual {0}", total);

        }
    }
}
