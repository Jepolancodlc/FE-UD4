using System;

namespace UD4_e23
{
    class e23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el primer digito:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el signo de la operacion [+] [-] [*] [/] [^] [%]:");
            string signo = Console.ReadLine();
            Console.WriteLine("Escriba el segundo digito:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double total = 0;

            switch (signo)
            {
                case "+":   total = num1 + num2;
                    break;
                case "-":   total = num1 - num2;
                    break;
                case "*":   total = num1 * num2;
                      break;
                case "/":   total = num1 / num2;
                    break;
                case "^":   total = Math.Pow(num1, num2);
                    break;
                case "%":   total = num1 % num2;
                    break;
                default:
                    break;

            }
            Console.WriteLine("El total de {0} {1} {2} es {3}", num1, signo, num2, total);
        }
    }
}
