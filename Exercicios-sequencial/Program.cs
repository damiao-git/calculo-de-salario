using System;
using System.Globalization;

namespace Exercicios_sequencial
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine("digite o valor do salario: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Deseja Receber vale transporte? (S = Sim / N + Não)");
            char vale = char.Parse(Console.ReadLine());

            if (vale == 'S' || vale == 's')
                {
                liquidoPassagem(salario);
                }
            else
                {
                liquidoSemPassagem(salario);
                }

            }

        static void liquidoPassagem(double salario)
            {
            double descInss =  salario * 0.08;
            Console.WriteLine("INSS " + descInss);
            double descPassagem = salario * 0.06;
            Console.WriteLine("Passagem " + descPassagem);
            double valPassagem = 115.50;
            double insalubridade = 220;

            salario = salario - descInss - descPassagem + valPassagem + insalubridade;
            Console.WriteLine(salario);
            }
        static void liquidoSemPassagem(double salario)
            {
            double descInss = salario - salario * 0.08;
            double insalubridade = salario + 220;

            salario = salario - descInss + insalubridade;
            Console.WriteLine(salario);
            }
        }
    }
