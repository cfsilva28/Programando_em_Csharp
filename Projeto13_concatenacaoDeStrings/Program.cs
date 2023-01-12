using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto13_concatenacaoDeStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome = "Julio ";
            string sobreNome =  "Cesar";

            string nomeCompleto = String.Concat(nome, sobreNome);



            Console.WriteLine($"Nome Completo: {nomeCompleto}");

            Console.ReadKey();
        }
    }
}
