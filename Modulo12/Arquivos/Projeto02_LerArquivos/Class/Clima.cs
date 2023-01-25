using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Projeto02_LerArquivos.Class
{
    internal class Clima
    {
        public DateTime Data { get; set; }
        public string Cidade { get; set; } = String.Empty;

        public byte Temperatura { get; set; }
        public static string ObtemDadosTxt(string arquivoTxt)
        {
            return File.ReadAllText(arquivoTxt);
        }
        public static void ObtemDadosJson(string arquivoJson)
        {
            string jsonString = File.ReadAllText(arquivoJson);

            List<Clima>? clima = JsonSerializer.Deserialize<List<Clima>>(jsonString);

            foreach (var dado in clima)
            {
                Console.WriteLine($"Data: {dado.Data:d}. Cidade: {dado.Cidade}. Temperatura: {dado.Temperatura}");
            }
        }
    }
}
