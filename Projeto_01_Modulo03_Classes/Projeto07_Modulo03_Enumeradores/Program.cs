using Projeto07_Modulo03_Enumeradores.Enum;

Console.WriteLine("Todos os estados civis");

//Loop para ler todos os estados civis

foreach(EstadosCivis i in Enum.GetValues(typeof(EstadosCivis)))
{
    Console.WriteLine($"Estado Civil: {i}");
}
Console.WriteLine();

Console.WriteLine(new string('-', 50));

Console.WriteLine();


//Enum para string;

string casado = $"Estado civil: {EstadosCivis.Casado}";

Console.WriteLine(casado);
Console.ReadKey();