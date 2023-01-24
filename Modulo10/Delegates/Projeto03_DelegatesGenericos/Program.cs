internal class Program
{
    public delegate bool Buscar<T>(T item);

    private static void Main(string[] args)
    {
        Console.WriteLine("Delegates Genéricos");


        string[] paises = { "Brasil", "Portugal", "França", "Itália", "Estados Unidos" };

        Buscar<string> resultado = p => p.Contains("i");

        foreach (string pais in paises)
        {
            if (resultado(pais))
            {
                Console.WriteLine(pais);
            }
        }

        Console.ReadKey();
    }
}