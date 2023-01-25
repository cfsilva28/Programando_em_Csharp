/*
 * Programação Assíncrona
 * 
 * Task<T>: retorna dados de um método assíncrono (int, double, bool, coleção, classe, etc)
 * 
 */

class Program
{

    static async Task<int> ListarNomes()
    {
        var nomes = new List<string> { "Sofia", "Maria", "Pedro", "José" };
        int total = 0;

        foreach (var nome in nomes)
        {
            await Task.Delay(1000);

            if (nome.Contains("a"))
            {
                total++;
            }
        }
        return total;
    }
    static async Task Main(string[] args)
    {
        Console.WriteLine("Método assíncrono que retorna um valor inteiro");

        Console.WriteLine();

        int total = await ListarNomes();

        Console.WriteLine($"Total de nomes que contém a letra 'a' {total}");

        Console.ReadKey();
    }
}