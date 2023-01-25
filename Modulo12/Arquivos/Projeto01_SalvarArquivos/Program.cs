using Projeto01_SalvarArquivos.Class;

string diretorioArquivos = "c:\\curso-csharp\\aula-arquivos\\";

string arquivoTxt = "c:\\curso-csharp\\aula-arquivos\\clima.txt";

string arquivoJson = "c:\\curso-csharp\\aula-arquivos\\clima.json";

//Salvar arquivos

List<Clima> listaClima = new List<Clima>
{
    new Clima(){Data=new DateTime(2023,01,22).Date, Cidade = "SAO PAULO", Temperatura = 25},
    new Clima(){Data=new DateTime(2023,01,22).Date, Cidade = "CAMPINAS", Temperatura = 26},
    new Clima(){Data=new DateTime(2023,01,22).Date, Cidade = "GUARULHOS", Temperatura = 27},
    new Clima(){Data=new DateTime(2023,01,22).Date, Cidade = "UBERLANDIA", Temperatura = 30},
};

if (Directory.Exists(diretorioArquivos) == false)
{
    Directory.CreateDirectory(diretorioArquivos);
}

try
{
    Clima.SalvarTxt(arquivoTxt, listaClima);
    Clima.SalvarJson(arquivoJson, listaClima);
    Console.WriteLine("Arquivos salvos com sucesso: ");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}