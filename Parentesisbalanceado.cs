using System;
using System.Collections.Generic;

namespace tareasemana7estructuradedatos
{
    internal class ParentesisBalanceado
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== VERIFICACIÓN DE PARÉNTESIS BALANCEADOS ===");
            Console.Write("Ingrese la expresión matemática: ");
            string expresion = Console.ReadLine() ?? "";

            if (EstaBalanceada(expresion))
                Console.WriteLine("Fórmula balanceada.");
            else
                Console.WriteLine("Fórmula NO balanceada.");
        }

        private static bool EstaBalanceada(string expresion)
        {
            Stack<char> pila = new Stack<char>();

            foreach (char c in expresion)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    pila.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (pila.Count == 0) return false;

                    char tope = pila.Pop();
                    if (!EsParCorrecto(tope, c)) return false;
                }
            }

            return pila.Count == 0;
        }

        private static bool EsParCorrecto(char apertura, char cierre)
        {
            return (apertura == '(' && cierre == ')')
                || (apertura == '{' && cierre == '}')
                || (apertura == '[' && cierre == ']');
        }
    }
}
