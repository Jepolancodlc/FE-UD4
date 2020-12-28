using System;

namespace UD4_e11
{
    class e11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el primer digito:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el segundo digito:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("{0} es el mayor", num1);
            }
            else if (num1==num2)
            {
                Console.WriteLine("Los numeros son iguales");
            }
            else 
            {
                Console.WriteLine("{0} es el mayor", num2);
            }
        }
    }
}
