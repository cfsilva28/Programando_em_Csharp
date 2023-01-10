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

            //Comentário em linha
            //Continuação do comentário

            /*
             * Comentário em bloco
             * Aula inaugural
             * Programando com C#
             * 
             */

            //Console é uma classe interna do C#
            //Write é um método que mostra uma mensagem na tela
            Console.WriteLine("Conceitos iniciais de C#");

            /*
             * Declaração de variáveis
             * 
             * C# é uma linguagem que diferencia letras maiúsculas de minúsculas
             * 
             * Exemplo letras maiúsculas e minúsculas: idadeAluno é diferente IdadeAluno
             * 
             * Padrão camelCase: primeira letra da palavra minúsculo e demais palavras iniciadas em maiúsculo
             * 
             * Exemplo camelCase: marcaCarroUsado = "Ford";
             * 
             */

            //Tipos de variáveis numéricas inteiras

            long distanciaSaturnoSol = 1427000000; //System.Int64: -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            int anosLuzDistancia = -2147483648; //System.Int32: –2.147.483.648 a 2.147.483.647

            uint valorNotaFiscal = 10000;  //System.UInt32: 0 a 4.294.967.295

            short idadeCidade = 510; //System.Int16: -32.768 a 32.767

            byte idadeAluno = 20; //System.Byte: 0 a 255

            sbyte valorReferência = 0; //-128 a 127

            //Tipos de variáveis numéricas de ponto flutuante

            double massaParticula = 0.000008987654; //Precisão: 15 dígitos

            float velocidadeParticula = 2.401234f; //Precisão: 7 dígitos

            decimal valorAcao = 32.56m; //Precisão: 28 dígitos. Muito utilizado em valores monetários

            //Tipos de variáveis textuais
            string nomeAluno = "Pedro Soares";

            string enderecoAluno = null;

            char generoPessoa = 'F';

            //Tipos de variáveis booleanas. Aceitam os valores TRUE e FALSE
            bool testeNivelamento = true;

            //Tipos anuláveis
            int? testeIntegridade = null;

            //Variáveis do tipo implícito
            var numeroSorteado = 10;
            var nomePessoaSorteada = "Jonathan Feitor";

            //Exibe valores em tela

            //O operador + é utilizado para concatenar (juntar) strings
            Console.WriteLine("Distância entre Saturno e o Sol: " + distanciaSaturnoSol + ".");

            //É possível concatenar utilizando interpolação ($)
            Console.WriteLine($"Teste de nivelamento: {testeNivelamento}.");

            Console.WriteLine("Texto: ");

            Console.Read();
        }
    }
}
