using System;
using System.Reflection.Metadata.Ecma335;

namespace RangoDeCalificación
{
    class Program
    {
        static void Main()
        {
            /*Hacer el programa con varios metodos y que los metedos interactuen entre si.
             *Solicita la calificación de cada asignatura.
             *Sacar el rango de calificación total.
             
             *90-100: Excelente
             *80-89: Bueno
             *70-79: Regular
             *0-69: Insuficeinte
             */

            Console.WriteLine("Rango de calificaión");
            Console.WriteLine("");

            int userInput = GetNumericInput();

            ProcessUserInput(userInput);

            Console.WriteLine("");
            Console.WriteLine("Precione la tecla 'esc' para salir");
            while (true)
            {
                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        } 

        static int GetNumericInput()
        {
            //int number;
            while (true)
            {
                Console.WriteLine("Ingresa las calificaciónes obtenidas en tus asignaturas");
                Console.WriteLine("Historia:"); int h = int.Parse(Console.ReadLine());

                Console.WriteLine("Matematicas:"); int m = int.Parse(Console.ReadLine());

                Console.WriteLine("Formación Civica y Etica:"); int f = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingles"); int i = int.Parse(Console.ReadLine());

                Console.WriteLine("Educación Fisica y Etica"); int ef = int.Parse(Console.ReadLine());

                Console.WriteLine("Geografia"); int g = int.Parse(Console.ReadLine());

                Console.WriteLine("Español"); int e = int.Parse(Console.ReadLine());

                int result = (h + m + f + i + ef + g + e) / 8;

                return result;
                //Console.WriteLine(" Favor de esceribir el promedio que se te acaba de dar:"); string input = Console.ReadLine();

                /*if (int.TryParse(input, out number))
                {
                    return number;
                }*/
            }
        }

        static void ProcessUserInput(int result)
        {
            Console.WriteLine($"Tu promedio es de: {result}");

            if (result > 9 && result < 10)
            {
                Console.WriteLine("Tu promedio final es excelente.");
            }
            else if (result > 8 && result < 8.9)
            {
                Console.WriteLine("Tu promedio final es bueno.");
            }
            else if (result > 70 && result < 7.9)
            {
                Console.WriteLine("Tu promedio final es regular.");
            }
            else if (result > 6 && result < 6.9)
            {
                Console.WriteLine("Tu pormedio final es insuficiente");
            }
            else
            {
                Console.WriteLine("Vales vrga");
            }
        }
    }
}