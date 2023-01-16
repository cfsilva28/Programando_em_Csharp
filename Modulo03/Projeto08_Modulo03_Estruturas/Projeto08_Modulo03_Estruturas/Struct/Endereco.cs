using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto08_Modulo03_Estruturas.Struct
{
    /*
     * Uma estrutura é um tipo valor
     * 
     * A instância de uma estrutura é chamada value e fica armazenada na memória stack
     * 
     * Comparando classe e estrutura:
     * 
     * Uma classe é um tipo referência. A instância de uma classe é chamada object e fica armazenada na memória heap
     * 
     * A classe permite herança e polimorfismo
     * Link:
     */
    internal struct Endereco
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string ExibirEndereco()
        {
            return $"Rua: {Rua}\nBairro: {Bairro}\nCidade: {Cidade}\nUF: {UF}\nCEP: {CEP}";
        }
    }
}
