/*
 * Delegates Predefinidos
 * 
 * Predicate
 * 
 * Func
 */

Console.WriteLine("Delegates predefinidos");

static double Media(double x, double y, double z)
{
    return (x + y + z) / 3;
}
//Predicate

List<string> cidades = new List<string> { "São Paulo", "Madri", "Tókio", "Nova Iorque", "São Petersbugo" };

string? cidade = cidades.Find(p => p == "São Paulo");

Console.WriteLine($"Cidade selecionada: {cidade}");

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 9 };



//Exercitando expressão lambda
int numerosSelecionados = numeros.Count(p => p % 2 == 0 || p > 8);

Console.WriteLine($"Total de números selecionados: {numerosSelecionados}");

//Func

Func<double, double, double, double> mediaFunc;

mediaFunc = Media;

Console.WriteLine($"Média: {mediaFunc(3, 6, 9)}");

Console.ReadKey();