using ATIVIDADE04AED;
using System;
using System.Globalization;

namespace ATIVIDADE04AED

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Digite o valor do lado A do triângulo: ");
            triangulo.LadoA = double.Parse(Console.ReadLine());
            if (triangulo.LadoA <= 0)
            {
                while(triangulo.LadoA <= 0) 
                {
                    Console.WriteLine("Valor inválido! Digite um novo valor maior do que 0:");
                    triangulo.LadoA = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Digite o valor do lado B do triângulo: ");
            triangulo.LadoB = double.Parse(Console.ReadLine());
            if(triangulo.LadoB <= 0)
            {
                while(triangulo.LadoB <= 0)
                {
                    Console.WriteLine("Valor inválido! Digite um novo valor maior do que 0: ");
                    triangulo.LadoB = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Digite o valor do lado C do triângulo: ");
            triangulo.LadoC = double.Parse(Console.ReadLine());
            if(triangulo.LadoC <= 0)
            {
                while(triangulo.LadoC <= 0)
                {
                    Console.WriteLine("Valor inválido!  Digite um novo valor maior do que 0: ");
                    triangulo.LadoC = double.Parse(Console.ReadLine());
                }
            }
            triangulo.imprimirDados();

        }
    }
}