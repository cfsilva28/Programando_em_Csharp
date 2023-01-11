using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto08_CoalescenciaNula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * O operador de coalescencia nula retornará o valor do operando da EDSQUERDA se não for NULL
             * 
             * Caso o contrário, ele retornará o valor da DIREITA
             * 
             */

            string nomeCurso = null;

            Console.WriteLine($"{nomeCurso ?? "Nome do curso não informado"}");

            Console.ReadKey();
        }
    }
}
