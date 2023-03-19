using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE04AED
{
    internal class Triangulo
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;


        public double LadoA
        {
            get
            {
                return ladoA;
            }
            set
            {
                ladoA = value;
            }
        }
        public double LadoB
        {
            get { return ladoB; }
            set { ladoB = value; }
        }

        public double LadoC
        {
            get { return ladoC; }
            set { ladoC = value; }
        }
        private string tipoTriangulo(double ladoA, double ladoB, double ladoC)
        {
            if (ladoA >= ladoB + ladoC)
            {
                return "NÃO FORMA TRIÂNGULO";
            }
            else if ((ladoA * ladoA) == (ladoB * ladoB) + (ladoC * ladoC))
            {
                return "TRINGULO RETANGULO";
            }
            else if ((ladoA * ladoA) > (ladoB * ladoB) + (ladoC * ladoC))
            {
                return "TRIÂNGULO OBTUSANGULO";
            }
            else if ((ladoA * ladoA) < ((ladoB * ladoB) + (ladoC * ladoC)))
            {
                return "TRIÂNGULO ACUTANGULO";
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                return "TRIÂNGULO EQUILATERO";
            }
            else
            {
                return "TRIÂNGULO ESCALENO";
            }
        }

        public void imprimirDados()
        {
            Console.WriteLine("TIPO DO TRIÂNGULO: " + tipoTriangulo(LadoA, LadoB, LadoC));
        }

    }
}
