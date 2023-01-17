using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto11_Modulo03_SobrecargaMetodos.Class
{

    /*
     * Sobrecarga de Métodos
     * 
     * É a possibilidade de fazer com que uma mesma operação seja executada de formas diferentes
     * 
     * Quando tem-se implementações de MESMO NOME, mas com NÚMERO DIFERENTE DE PARÂMETROS ou
     * PARÂMETROS DE TIPOS DIFERENTES, pode-se SOBRECARREGAR um método
     */
    internal class Pessoa
    {
        public string? Nome { get; set; }

        public byte Idade { get; set; }

        public string ExibirDados()
        {
            return $"Nome: {Nome}\nIdade: {Idade} anos";
        }

        public string ExibirDados(string observacao)
        {
            return $"Nome: {Nome}\nIdade: {Idade} anos\nObservacao: {observacao}";
        }
    }
}
