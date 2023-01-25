using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Projeto01_SalvarArquivos.Class
{
    internal class Clima
    {
        public DateTime Data { get; set; }
        public string? Cidade { get; set; }
        public byte Temperatura { get; set; }

        //IEnumerable Interface indicada para consultar dados de coleções comoList<T> e Array
        public static IEnumerable<string> ObtemDados(List<Clima> dados)
        {
            foreach (var dado in dados)
            {
                yield return $"Data: {dado.Data:d}. Cidade: {dado.Cidade}. Temperatura: {dado.Temperatura}\n";
            }
        }

        //Salvar Txt
        public static void SalvarTxt(string arquivoTxt, List<Clima> dados)
        {
            IEnumerable<string> ListaClima = ObtemDados(dados);

            foreach (var dado in ListaClima)
            {
                File.AppendAllText(arquivoTxt, dado);
            }
        }

        //Salvar Json
        public static void SalvarJson(string arquivoJson, List<Clima> dados)
        {
            string jsonString = JsonSerializer.Serialize(dados);

            File.AppendAllText(arquivoJson, jsonString);
        }
    }
}
