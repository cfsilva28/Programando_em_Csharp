/*
 * Método de saída: out
 * 
 * O método atribui valor ao parâmetro
 */

static void RetornaPI(out double valorPI)
{
    double pi = Math.PI;

    valorPI = pi;
}

double pi;

RetornaPI(out pi);

Console.WriteLine($"Valor de pi: {pi}");

Console.ReadKey();