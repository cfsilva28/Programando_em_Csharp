using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double c = 9;
            double d = 2;

            double soma = c + d;

            double subtracao = c - d;

            double mutiplicacao = c * d;

            double divisao = c / d;

            double modulo = c % d;

            //Exibe uma soma
            Console.WriteLine($"Soma entre{c} e  {d}: {soma}");

            //Exibe uma subtração
            Console.WriteLine($"subtração entre{c} e {d}: {subtracao}");

            //Exibe uma mutiplicação
            Console.WriteLine($"mutiplicação entre{c} e {d}: {mutiplicacao}");

            //Exibe uma divisão
            Console.WriteLine($"divisão entre{c} e {d}: {divisao}");

            //Exibe um módulo
            Console.WriteLine($"Módulo entre{c} e {d}: {modulo}");

            Console.ReadKey();

        }
    }
}
