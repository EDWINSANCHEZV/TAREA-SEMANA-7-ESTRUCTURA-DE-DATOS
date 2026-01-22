using System;
using System.Collections.Generic;

namespace tareasemana7estructuradedatos
{
    internal class TorresDeHanoi
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== TORRES DE HANOI CON PILAS ===");
            Console.Write("Ingrese el número de discos: ");

            if (!int.TryParse(Console.ReadLine(), out int discos) || discos <= 0)
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            Stack<int> origen = new Stack<int>();
            Stack<int> auxiliar = new Stack<int>();
            Stack<int> destino = new Stack<int>();

            for (int i = discos; i >= 1; i--)
                origen.Push(i);

            Console.WriteLine("\nMovimientos:\n");
            ResolverHanoi(discos, origen, destino, auxiliar,
                          "Origen", "Destino", "Auxiliar");
        }

        static void ResolverHanoi(int n,
                                  Stack<int> origen,
                                  Stack<int> destino,
                                  Stack<int> auxiliar,
                                  string nombreOrigen,
                                  string nombreDestino,
                                  string nombreAuxiliar)
        {
            if (n == 1)
            {
                int disco = origen.Pop();
                destino.Push(disco);
                Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
                return;
            }

            ResolverHanoi(n - 1, origen, auxiliar, destino,
                          nombreOrigen, nombreAuxiliar, nombreDestino);

            int discoActual = origen.Pop();
            destino.Push(discoActual);
            Console.WriteLine($"Mover disco {discoActual} de {nombreOrigen} a {nombreDestino}");

            ResolverHanoi(n - 1, auxiliar, destino, origen,
                          nombreAuxiliar, nombreDestino, nombreOrigen);
        }
    }
}
