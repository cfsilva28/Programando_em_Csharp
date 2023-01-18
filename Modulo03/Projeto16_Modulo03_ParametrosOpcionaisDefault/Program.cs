//Método com parâmetro opcional

using Projeto16_Modulo03_ParametrosOpcionaisDefault.Class;
//Método com parâmetro opcional
static string MostrarEstado(Estados estado = Estados.PR)
{

    return $"O estado informado foi {estado}";

}

//Método com parâmetros default
static double CalcularValor(double valor, double taxa = 0, double imposto = 0)
{

    double desc1 = valor * taxa / 100;
    double desc2 = valor * imposto / 100;
    double valorLiquido = valor - desc1 - desc2;

    return valorLiquido;

}

//Exibe resultados de métodos com parâmetro opcional
Console.WriteLine(MostrarEstado(Estados.MG));

Console.WriteLine();

Console.WriteLine(new string('-', 60));

Console.WriteLine();

double valor = 1000;

Console.WriteLine($"Valor sem desconto: {CalcularValor(valor)}");
Console.WriteLine($"Valor com desconto de taxa: {CalcularValor(taxa: 10, valor: valor)}");
Console.WriteLine($"Valor com desconto de imposto: {CalcularValor(imposto: 18, valor: valor)}");
Console.WriteLine($"Valor com desconto de taxa e impostos: {CalcularValor(imposto: 18, taxa: 10, valor: valor)}");

Console.ReadKey();