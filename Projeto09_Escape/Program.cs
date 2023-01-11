using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto09_Escape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * \n: próxima linha
             * \": caractere aspas duplas
             * \': caractere aspas simples
             * \\: caractere barra invertida
             * 
             */

            Console.WriteLine("Curso de CSharp\nImpacta.");

            Console.WriteLine("Curso de \"ASP.NET\" - IMPACTA.");

            Console.WriteLine("Curso de CSharp\\ASP.NET - IMPACTA.");

            string produto = "Notebook";

            decimal preco = 7500.95m;

            Console.WriteLine($"Produto: {produto}.\nPreço: {preco}.");

            Console.ReadKey();
        }
    }
}
