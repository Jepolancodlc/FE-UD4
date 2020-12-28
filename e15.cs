using System;

namespace UD4_e15
{
    class e15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num %2 == 0)
            {
                Console.WriteLine("El numero {0} es divisible entre 2", num);
            }
            else
            {
                Console.WriteLine("El numero {0} NO es divisible entre 2", num);
            }
        }
    }
}
