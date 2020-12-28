using System;

namespace UD4_e19
{
    class e19
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i%2==0 && i%3==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
