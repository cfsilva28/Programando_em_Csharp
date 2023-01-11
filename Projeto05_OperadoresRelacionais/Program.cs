using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05_OperadoresRelacionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Operadores Relacionais. O resultado será um valor booleano
             * 
             * == : igual a
             * != : diferente de
             *  < : menor que
             *  <= : menor ou igual a
             *   > : maior
             *   >= : maior ou igual a
             */

            int quantidadeCarros = 60;

            Console.WriteLine($"Quantidade de carros é igual a 60? {quantidadeCarros == 60}");
            Console.WriteLine($"Quantidade de carros é diferente que 60? {quantidadeCarros != 60}");
            Console.WriteLine($"Quantidade de carros é menor que 40? {quantidadeCarros < 40}");
            Console.WriteLine($"Quantidade de carros é menor ou igual a 70? {quantidadeCarros <= 70}");
            Console.WriteLine($"Quantidade de carros é maior que 80? {quantidadeCarros > 80}");
            Console.WriteLine($"Quantidade de carros é maior ou igual a 56? {quantidadeCarros >= 56}");
                
            Console.ReadKey();
        }
    }
}
