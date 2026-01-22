using System;

namespace tareasemana7estructuradedatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== MENÚ - ESTRUCTURA DE DATOS (PILAS) =====");
                Console.WriteLine("1) Verificar paréntesis balanceados");
                Console.WriteLine("2) Torres de Hanoi");
                Console.WriteLine("0) Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        ParentesisBalanceado.Ejecutar();
                        break;

                    case "2":
                        TorresDeHanoi.Ejecutar();
                        break;

                    case "0":
                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
