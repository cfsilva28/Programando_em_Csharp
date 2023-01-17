using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto13_Modulo03_MetodosExtensao.Class
{
    internal static class Metodos
    {
        /*
         * Ao se utilizar um método de extensão é possível ampliar uma classe ou uma estrutura já existente com métodos
         * estáticos adicionais
         */
        public static string RetirarAcentos(this string texto)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                texto = texto.Replace(comAcentos[i], semAcentos[i]);
            }
            return texto;
        }
    }
}
