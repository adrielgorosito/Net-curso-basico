using System;

namespace Proyecto_DatosPrimitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;
            double sueldo;
            bool casado;

            const double pi = 3.14; // constante
            dynamic contenido; // variable dinámica: puede adoptar cualquier tipo

            Console.WriteLine("Ingrese el nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad:");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo:");
            sueldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Está casado? Y/N");
            casado = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Nombre: " + nombre + " | Edad: " + edad + " | Sueldo: " + sueldo);
            Console.Write(" | Casado? ");
            Console.Write(casado ? "Si" : "No");
            Console.ReadKey();

            contenido = 10;
            contenido = "hola";
            contenido = 100.5;
        }
    }
}
