using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a forma geométrica:(Quadrado, Retângulo, Trapézio, Losango): ");
            string forma = (Console.ReadLine());

            switch (forma)
            {
                case "Quadrado":
                    Console.Write("Você escolheu: Quadrado");
                    Console.ReadKey();
                    break;

                case "Retângulo":
                    Console.Write("Você escolheu: Retângulo");
                    Console.ReadKey();
                    break;

                case "Trapézio":
                    Console.Write("Você escolheu: Trapézio");
                    Console.ReadKey();
                    break;

                case "Losango":
                    Console.Write("Você escolheu: Losango");
                    Console.ReadKey();
                    break;

                default:
                    Console.Write("Opção inválida");
                    Console.ReadKey();
                    break;
            }
        }
    }
}