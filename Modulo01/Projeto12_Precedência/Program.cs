using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto12_Precedência
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Precedência Padrão: multiplicação, divisão e modulo são resolvidos antes da adição e subtração
             * 
             * 
             */

            int a = 2 * 5 + 1;

            Console.WriteLine($"Valor da variável a: {a}");

            /*
             * Alteração da Precedência Padrão: utiliza-se parênteses
             * 
             */
            int b = 2 * (5 + 1);

            Console.WriteLine($"Valor da variável b: {b}");

            /*
             * Precedência envolvendo multiplicação e divisão
             * 
             * O conjunto à esquerda é resolvido primeiro
             * 
             * 
            */

            double c = 4.0 * 2.0 / 6.0;

            Console.WriteLine($"Valor da variável 'c': {c}");

            double d = 4.0 / 2.0 * 6.0;

            Console.WriteLine($"Valor da variável 'd': {d}");



            Console.ReadKey();
        }
    }
}
