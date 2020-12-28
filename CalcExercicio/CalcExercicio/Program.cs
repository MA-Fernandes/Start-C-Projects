using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            float v1, v2, res;
            char mult, continuar = 's';


            while (continuar == 's' || continuar == 'S'){
                Console.Clear();
                Console.WriteLine("########Calculadora Primitiva##########");
                Console.WriteLine("Digite dois valores");
                Console.Write("#1 Valor: ");
                v1 = float.Parse(Console.ReadLine());
                Console.Write("Qual Op deseja fazer??? (\"*\"--> Multiplicação | \"/\" --> Divisão | \"+\" --> Soma | \"-\" --> Subtração): ");
                mult = char.Parse(Console.ReadLine());
                Console.Write("#2 Valor: ");
                v2 = float.Parse(Console.ReadLine());
                if (mult == '/' && v2 == 0)
                {
                    while (v2 == 0)
                    {
                        Console.Write("#2 É invalido, digite outro: ");
                        v2 = float.Parse(Console.ReadLine());
                    }
                }
                if (mult == '*') res = v1 * v2;
                else if (mult == '/') res = v1 / v2;
                else if (mult == '+') res = v1 + v2;
                else res = v1 - v2;
                Console.WriteLine("O resultado é: " + res);
                Console.WriteLine("Deseja realizar mais calculos? (S --> continuar | N --> sair): ");
                continuar = char.Parse(Console.ReadLine());
            }
        }
    }
}
