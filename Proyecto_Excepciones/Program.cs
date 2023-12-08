using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu edad: ");
            try 
            { 
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Tu edad es: " + edad);
            } catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            } finally
            {
                Console.ReadKey();
            }
        }
    }
}
