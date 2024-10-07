using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Lopes";
p1.Idade = 20;
p1.EnderecoPessoa = new Endereco()
{
  Longadouro = "Rua marques",
  CEP = "01934013",
  Numero = 1402,
  Cidade = "Sorocaba",
};

WriteLine("Fim");
