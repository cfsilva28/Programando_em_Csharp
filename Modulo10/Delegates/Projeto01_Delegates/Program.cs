using System;

namespace Projeto01_Delegates
{
    /*
    * Delegates
    * 
    * Fazem referências a métodos ou operações
    *   
    */

    /*
    * Expressão Lambda
    *
    *Sintaxe
    * (parâmetros) => resultado. Leia-se: uma lista de parâmetros produz o resultado esperado
    * 
    */
    internal class Program
    {



        public delegate double Calcular(double x, double y);

        public delegate void Mensagem(string texto);


        static void Main(string[] args)
        {
            //Declaração de um delegate
            Calcular multiplicacao = new Calcular((x, y) => x * y);

            double resultado = multiplicacao(10, 5);

            Console.WriteLine($"Resultado da multiplicação: { resultado}");


            Console.ReadKey();
        }
    }
}
