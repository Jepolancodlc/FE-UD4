using System;

namespace UD4_e5
{
    class e5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un dia de la semana:");
            string dia =  Console.ReadLine();

            switch (dia.ToLower())
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("{0} no es fin de semana", dia);
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("{0} es fin de semana", dia);
                    break;
                default:
                    Console.WriteLine("{0} no es un dia valido", dia);
                    break;
            }
        }
    }
}
