using System;

namespace Proyecto_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Función 1: ");
            ingresoDatos();

            Console.WriteLine("\n\nFunción 2:\nIngrese dos números: ");

            Console.WriteLine("Suma: " + sum(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));

            Console.ReadKey();
        }

        // Primera función
        static void ingresoDatos()
        {
            string nombre;
            Console.WriteLine("Ingrese el nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Nombre: " + nombre);

        } 

        // Función con parámetro
        static int sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
