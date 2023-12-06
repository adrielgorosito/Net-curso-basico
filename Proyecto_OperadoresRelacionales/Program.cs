using System;

namespace Proyecto_OperadoresRelacionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 5;
            bool resultado;

            // Operadores relacionales:
            // >, <, ==, >=, <=, !=
            resultado = num1 > num2;
            resultado = num1 != num2;

            Console.WriteLine("Num1 es mayor a num2? " + (num1 > num2));

            // Operadores lógicos
            // &&, ||, !
            resultado = (num1 > num2) && (num1 == 0);
            resultado = !(num1 == num2);

            Console.ReadKey();
        }
    }
}
