
using Projeto11_Modulo03_SobrecargaMetodos.Class;

Pessoa pessoa = new Pessoa();

pessoa.Nome = "Andrea";
pessoa.Idade = 25;

Console.WriteLine(pessoa.ExibirDados());

Console.WriteLine();

Console.WriteLine(new string ('-', 50));

Console.WriteLine(pessoa.ExibirDados("Aluna do Curso de C#"));
Console.ReadKey();