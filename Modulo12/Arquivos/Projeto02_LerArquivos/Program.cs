using Projeto02_LerArquivos.Class;

string arquivoTxt = "c:\\curso-csharp\\aula-arquivos\\clima.txt";

string arquivoJson = "c:\\curso-csharp\\aula-arquivos\\clima.json";

try
{
    string texto = Clima.ObtemDadosTxt(arquivoTxt);

    Console.WriteLine("Dados lidos do arquivo txt");

    Console.WriteLine();

    Console.WriteLine(texto);

    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("Dados lidos do arquivo txt");

    Console.WriteLine();

    Clima.ObtemDadosJson(arquivoJson);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadKey();