using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_OperadoresReduzidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Operadores Reduzidos
             * 
             *  += : soma igual
             *  -= : subtrai igual
             *  += : mutiplica igual
             *  /= : divide igual
             *  %= : módulo igual
             *  Os operadores *, / e % têm procedência sobre os operadores + e - 
             *  Para determinar a precedência de forma diferente da preexistente 
             *  é necessário usar parênteses
             */

            double c = 9;

            double d = 2;

            c += d;

            //Exibe o valor de c

            Console.WriteLine($"Soma entre 'c' e 'd': {c}");

            c = 9;
            d = 2;
            c -= d; // c= c -d

            //Exibir o valor de c
            Console.WriteLine($"Valor de c: {c}");

            c = 9;
            d = 2;

            c *= d; // c = c *d

            //Exibe valor de c
            Console.WriteLine($"Valor de c: {c}");

            c = 9;
            d = 2;

            c /= d; // c = c / d

            //Exibe o valor de c
            Console.WriteLine($"Valor de c : {c}");


            c = 9;
            d = 2;

            c %= d; // c = c % d

            //Exibe o valor de c
            Console.WriteLine($"Valor de c: {c}");
            Console.ReadKey();
        }
    }
}
