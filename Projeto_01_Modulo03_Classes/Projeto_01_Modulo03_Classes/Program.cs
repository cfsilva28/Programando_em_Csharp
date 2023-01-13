using Projeto01_Modulo03_Classes.Class;

Automovel carro = new Automovel();

Console.WriteLine("Primeiro Carro");

carro.Ano = 2021;
carro.Cor = "Branco";
carro.Fabricante = "Honda";
carro.Modelo = "Civic";
carro.Placa = "ABC1D23";

Console.WriteLine($"Fabricante: {carro.Fabricante}");
Console.WriteLine($"Modelo: {carro.Modelo}");
Console.WriteLine($"Placa: {carro.Placa}");
Console.WriteLine($"Cor: {carro.Cor}");
Console.WriteLine($"Cor: {carro.Ano}");

Console.WriteLine(new String('-', 60));

Console.WriteLine();

Console.WriteLine("Segundo Carro\n");

Automovel carro2 = new Automovel
{
    Ano = 2022,
    Cor = "Prata",
    Modelo = "Corolla",
    Placa = "FGH5X65"
};

Console.WriteLine($"Fabricante: {carro2.Fabricante}");
Console.WriteLine($"Modelo: {carro2.Modelo}");
Console.WriteLine($"Placa: {carro2.Placa}");
Console.WriteLine($"Cor: {carro2.Cor}");
Console.WriteLine($"Cor: {carro2.Ano}");

Console.ReadKey();