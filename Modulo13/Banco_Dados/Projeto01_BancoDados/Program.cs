//Menu

using Projeto01_BancoDados.Class.Categoria;
using Projeto01_BancoDados.Produto;

Console.WriteLine("Menu");

Console.WriteLine(new String('_', 60));

Console.WriteLine("0. Sair");
Console.WriteLine("1. Cadastrar Categoria");
Console.WriteLine("2. Listar Categoria");
Console.WriteLine("3. Atualizar Categoria");
Console.WriteLine("4. Remover Categoria");
Console.WriteLine("5. Cadastrar Produto");
Console.WriteLine("6. Listar Produtos");
Console.WriteLine("7. Atualizar  Produto");
Console.WriteLine("8. Remover Produto");

Console.WriteLine(new String('_', 60));

while (true)
{
    Console.WriteLine("Escolha uma opção: ");

    int opcao = Convert.ToInt32(Console.ReadLine());

    if (opcao == 0)
    {
        Console.WriteLine("Operação finalizada");
        return;
    }
    //Cadastrar Categoria
    if (opcao == 1)
    {
        Console.Write("Informe o nome da categoria: ");

        string categoria = Console.ReadLine();

        CategoriaRepositorio.CadastrarCategoria(categoria);

        continue;
    }

    //Lista Categorias
    if (opcao == 2)
    {
        CategoriaRepositorio.ListarCategorias();

        continue;
    }

    //Atualizar Categoria
    if (opcao == 3)
    {
        CategoriaRepositorio.AtualizarCategoria();

        continue;
    }

    //Remover Categoria
    if (opcao == 4)
    {
        CategoriaRepositorio.RemoverCategoria();
        continue;
    }

    //Cadastrar Produto
    if (opcao == 5)
    {
        Console.Write("Informe o código da categoria do produto ");

        int idCategoria = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o nome do produto: ");

        string descricaoProduto = Console.ReadLine();

        Console.Write("Informe o preço do produto: ");

        double preco = Convert.ToDouble(Console.ReadLine());

        ProdutoRepositorio.CadastrarProduto(new Produto(idCategoria, descricaoProduto, preco));

        continue;
    }

    //Listar Produtos
    if (opcao == 6)
    {
        ProdutoRepositorio.ListarProdutos();

        continue;
    }

    //Atualizar Produto
    if (opcao == 7)
    {
        Console.WriteLine("Informe o código do produto: ");

        int codigoProduto = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o código do categoria: ");

        int codigoCategoria = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o nome do produto: ");

        string descricaoProduto = Console.ReadLine();

        Console.Write("Informe o preço do produto: ");

        double precoProduto = Convert.ToDouble(Console.ReadLine());

        ProdutoRepositorio.AtualizarProduto(new Produto(codigoProduto, codigoCategoria, descricaoProduto, precoProduto));

        continue;
    }

    //Remover Produto
    if (opcao == 8)
    {
        Console.Write("Informe o código do produto: ");

        int codigo = Convert.ToInt32(Console.ReadLine());

        ProdutoRepositorio.RemoverProduto(codigo);

        continue;


    }



}