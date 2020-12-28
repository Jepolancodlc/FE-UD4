using System;

namespace UD4_e22
{
    class e22
    {
        static void Main(string[] args)
        {
            string CONTRA = "pass";
            bool v = false;
            do
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("\nIntroduzca la contraseña:");
                    string inPass = Console.ReadLine();

                    if (inPass != CONTRA)
                    {
                        Console.WriteLine("Contraseña incorrecta");
                    }
                    else
                    {
                        i = 4;  //En caso de acertar, sale del bucle for antes de tiempo
                        Console.WriteLine("Contraseña correcta, Enorabuena!");
                        v = true; //En caso de acertar, sale del bucle while
                        
                    }

                    v = true;
                }
            } while (!v);
            
        }

        }
    }

