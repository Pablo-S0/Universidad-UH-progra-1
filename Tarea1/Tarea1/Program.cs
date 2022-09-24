using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float aux = 0;
            float[] notas = new float [5];
            String[] nombres = new String[5];
            float[] notaM = new float [5];
            float acum = 0; //guarda promedio

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"introduzca nombre del estudiante {i+1}");
                nombres[i] = Console.ReadLine();

                Console.WriteLine($"introduzca la nota del estudiante {i+1}");
                notas[i] = Int32.Parse(Console.ReadLine());

                notaM[i] = notas[i];

                acum += notas[i];
            }
           
            acum /= notas.Length;
            Console.WriteLine($"El promedio de las 5 notas es de {acum}");
            Console.ReadKey();

            for (int i = 0; i < 5 - 1; i++) //orden de mayor a menor
            {
                for (int j = 0; j < 5 - 1; j++)
                {
                    if (notaM[j] < notaM[j+1])
                    {
                        aux = notaM[j];
                        notaM[j] = notaM[j+1];
                        notaM[j+1] = aux;

                    }   
                }
            }


            for (int i = 0; i < 5; i++) //revisa y muestra mensaje de nota mayor con nombre del estudiante
            {
                if (notaM[0] == notas[i])
                {
                    Console.WriteLine($"La nota mas alta es de {nombres[i]} con una nota de {notas[i]}");
                    Console.ReadKey();
                }
            }

            for (int i = 0; i < 5; i++) //revisa y muestra los estudiantes con nota mayor y menor al promedio
            {

                if (notas[i] == acum)
                {
                    Console.WriteLine($"{nombres[i]} posee la misma nota al promedio: {notas[i]}");
                    Console.ReadKey();
                }
                
                if (notas[i] > acum)
                {
                    Console.WriteLine($"{nombres[i]} posee una nota mayor al promedio: {notas[i]}");
                    Console.ReadKey();
                }

                if (notas[i] < acum)
                {
                    Console.WriteLine($"{nombres[i]} posee una nota menor al promedio: {notas[i]}");
                    Console.ReadKey();
                }

            }

        }
    }
}
