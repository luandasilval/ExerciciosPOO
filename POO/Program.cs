using POO;

//*Exercício 1
// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Luanda";
// pessoa1.Idade = 16;
// pessoa1.Cidade = "São Bernardo do Campo";
// pessoa1.Apresentar();

// Pessoa pessoa2 = new Pessoa();
// pessoa2.Nome = "Kessia";
// pessoa2.Idade = 25;
// pessoa2.Cidade = "São Caetano do sul";
// pessoa2.Apresentar();

//* Exercício 2
// Calculadora calculadora1 = new Calculadora();

// calculadora1.Somar(10, 5);
// calculadora1.Subtrair(10, 5);
// calculadora1.Multiplicar(10, 5);
// Calculadora.Dividir(10, 5);

//* Exercício 3
// Veiculo veiculo1 = new Veiculo();
// veiculo1.AlterarVelocidade(150);

//* Exercício 4

Funcionario funcionario1 = new Funcionario();
funcionario1.Nome = "Luanda";
funcionario1.Cargo = "Desenvolvedora";
funcionario1.AumentarSalario(5000);
funcionario1.ConsultarSalario();

funcionario1.Salario = 6000;
//! A propriedade ou o indexador "Funcionario.Salario" não pode ser usado neste contexto porque o acessador set é inacessível
// o código acima não compila, pois a propriedade Salario tem um set privado, ou seja, só pode ser alterada dentro da própria classe Funcionario. Pra alterar o salário, é necessario usar o método AumentarSalario.

