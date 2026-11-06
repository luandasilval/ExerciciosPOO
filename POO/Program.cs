using POO;

//*Exercício 1
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Luanda";
pessoa1.Idade = 16;
pessoa1.Cidade = "São Bernardo do Campo";
pessoa1.Apresentar();

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Kessia";
pessoa2.Idade = 25;
pessoa2.Cidade = "São Caetano do sul";
pessoa2.Apresentar();

//* Exercício 2
Calculadora calculadora1 = new Calculadora();

calculadora1.Somar(10, 5);
calculadora1.Subtrair(10, 5);
calculadora1.Multiplicar(10, 5);
Calculadora.Dividir(10, 5);

//* Exercício 3
Veiculo veiculo1 = new Veiculo();
veiculo1.AlterarVelocidade(150);
