using System;

namespace Proyecto_Iteraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While
            int i = 1;

            while(i <= 5)
            {
                Console.WriteLine("While: " + i);
                i++;
            }

            i = 1;

            // Do while
            do
            {
                Console.WriteLine("Do while: " + i);
            } while (i <= 0);

            // For
            for (i = 11; i < 16; i++)
            {
                Console.WriteLine("For:" + i);
            }

            Console.ReadKey();
        }
    }
}
