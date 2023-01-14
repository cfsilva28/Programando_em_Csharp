
using Projeto06_Modulo03_ReferenciaThis.Class;

Pessoa pessoa = new Pessoa();

pessoa.ObterDados("Lorran", 18, 'M');

Console.WriteLine($"Nome: {pessoa.Nome}");
Console.WriteLine($"Idade: {pessoa.Idade}");
Console.WriteLine($"Gênero: {pessoa.Genero}");

Console.ReadKey();