using Projeto08_Modulo03_Estruturas.Struct;

Endereco endereco = new Endereco()
{
    Rua = "Avenida Paulista, 1009",
    Bairro = "Cerqueira César",
    Cidade = "São Paulo",
    UF = "SP",
    CEP = "01311-919"
};

Console.WriteLine(endereco.ExibirEndereco());

Console.ReadKey();

