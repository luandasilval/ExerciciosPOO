using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        public int Salario { get; private set; }
        public void AumentarSalario(int valor)
        {
            Salario += valor;
        }

        public void ConsultarSalario()
        {
            Console.WriteLine($"O salário de {Nome} é de R${Salario}.");
        }
    }
}