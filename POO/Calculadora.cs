using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Calculadora
    {
        public void Somar(int a, int b)
        {
            Console.WriteLine($"A soma {a} + {b} é {a + b}.");
        }
        public void Subtrair(int a, int b)
        {
            Console.WriteLine($"A subtração {a} - {b} é {a - b}.");
        }
        public void Multiplicar(int a, int b)
        {
            Console.WriteLine($"A multiplicação {a} * {b} é {a * b}.");
        }
        public static void Dividir(int a, int b)
        {
            Console.WriteLine($"A divisão {a} / {b} é {a / b}.");
        }
    }
}