using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto07_OperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Operador Ternário
             * 
             * teste lógico ? resultado se verdadeiro : resultado se falso
             * 
             * teste lógico: qualquer expressão que possa ser avaliada como verdadeira ou falsa
             * 
             * resultado se verdadeiro: é o valor atribuído se o teste lógico for avaliado como verdadeiro
             * 
             * resultado se falso: é o valor atribuído se o teste lógico for avaliado como falso
             * 
             */

            int quantidadeVendas = 510;
            string avaliacao = quantidadeVendas % 2 == 0 ? "par" : "ímpar";
            Console.WriteLine($"A quantidade de vendas {quantidadeVendas} é {avaliacao} ");

            Console.ReadKey();
        }
    }
}
