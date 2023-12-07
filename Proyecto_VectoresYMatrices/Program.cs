using System;

namespace Proyecto_VectoresYMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vectorNombres = { "Victor", "Carlos", "Ana", "Luis", "Jorge" };

            Console.WriteLine("Nombre: " + vectorNombres[2]);

            Console.WriteLine("\nIteración con foreach:");
            foreach (string n in vectorNombres)
            {
                Console.WriteLine(n);
            }
            

            string[,] matrizAnimal = new string[3, 2];

            matrizAnimal[0, 0] = "Gato";
            matrizAnimal[0, 1] = "Perro";
            matrizAnimal[1, 0] = "Pájaro";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (matrizAnimal[i, j] != null)
                        Console.WriteLine("Fila: " + i + " | Animal: " + matrizAnimal[i, j]);
                    else
                        Console.WriteLine("Fila: " + i + " | ...");
                }
            }

            Console.ReadKey();
        }
    }
}
