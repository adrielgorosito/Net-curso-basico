using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            // Criminal lo siguiente
            if (edad >= 0 && edad <= 3) Console.WriteLine("Bebé.");
            else if (edad >= 4 && edad <= 9) Console.WriteLine("Niño");
            else if (edad >= 4 && edad <= 13) Console.WriteLine("Preadolescente.");
            else if (edad >= 14 && edad <= 18) Console.WriteLine("Adolescente.");
            else if (edad >= 19 && edad <= 28) Console.WriteLine("Joven");
            else if (edad >= 29 && edad <= 59) Console.WriteLine("Adulto");
            else if (edad >= 60) Console.WriteLine("Persona mayor");
            else Console.WriteLine("Error de edad");

            Console.WriteLine("\nIngrese el día en número: ");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2: 
                    Console.WriteLine("Lunes");
                    break;
                case 3:
                    Console.WriteLine("Martes");
                    break;
                default:
                    Console.WriteLine("Entre miércoles y sábado");
                    break;
            }

            Console.ReadKey();
        }
    }
}
