
using Projeto03_Polimorfismo.Class;

Produto produto = new Produto();

produto.Nome = "Notebook";
produto.Preco = 5000;


Console.WriteLine($"Produto\n\n{produto.ExibirDados()}");

Console.WriteLine();

Livro livro = new Livro();

livro.Nome = "Microsoft Visual C# Step by Step - 10th";
livro.Preco = 278.39m;
livro.NumeroPaginas = 796;

Console.WriteLine($"Livro\n\n{livro.ExibirDados()}");

Console.ReadKey();