using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto11_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Type Casting Implícito - Conversão de tipo automático
             * 
             * Converte um TIPO MENOR para um TIPO MAIOR
             */

            int temperatura = 7;

            double temperaturaAtualizada = temperatura;

            /*
             * Type Casting Explícito - Converção de tipo MANUAL
             * 
             * Converte um TIPO MAIOR para um TIPO MENOR
             */

            double valorNotaFiscal = 150.75;

            //valorNotaFiscalAtualizada = 150
            int valorNotaFiscalAtualizada = (int)valorNotaFiscal; //cast explícito (manuel).

            /*
             * Métodos para CONVERSÃO EXPLICÍTA
             * 
             * 
             */

            int numeroInteiro = 50;
            double numeroDecimal = 0.15;
            bool valorLogico = true;

            Console.WriteLine($"Converte int em string: {Convert.ToString(numeroInteiro)}");
            Console.WriteLine($"Converte int em double: {Convert.ToString(numeroInteiro)}");
            Console.WriteLine($"Converte double em int: {Convert.ToInt32(numeroDecimal)}");
            Console.WriteLine($"Converte bool em string: {Convert.ToString(valorLogico)}");

            Console.ReadKey();
        }
    }
}
