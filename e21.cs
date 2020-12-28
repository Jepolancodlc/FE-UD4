using System;

namespace UD4_e21
{
    class e21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un dia de la semana:");
            string dia = Console.ReadLine();

            switch (dia.ToLower())
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                case "sabado":
                    Console.WriteLine("{0} es laborable", dia);
                    break;
                case "domingo":
                    Console.WriteLine("{0} no es laborable", dia);
                    break;
                default:
                    Console.WriteLine("{0} no es un dia valido", dia);
                    break;
            }
        }
    }
}
