using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Modulo05_OperadorBase.Class
{
    /*
     * This: aponta para a própria classe
     * Base: aponta para a superclasse
     */
    internal class Modelo : Fabricante
    {
        public new string? Nome = "Renegade Longitude";

        public string ExibeDados()
        {
            return $"Fabricante: {base.Nome}\nModelo: {this.Nome}";
        }
    }
}
