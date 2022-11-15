using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora.Calculadora
{
    public class Calculator
    {
        public void Somar(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(double x, double y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(double x, double y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }

        //função Math.Round = arredonda o número do cálculo conforme o número de casas paramentrizado
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($" Seno de {angulo}º é = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($" Coseno de {angulo}º é = {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($" Tangente de {angulo}º é = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz} ");
        }
    }
}

