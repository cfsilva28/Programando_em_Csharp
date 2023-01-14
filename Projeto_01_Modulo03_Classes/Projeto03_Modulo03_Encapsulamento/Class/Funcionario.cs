using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_Modulo03_Encapsulamento.Class
{
    /*
         * O encapsulamento é um mecanismo que permite ocultar os detalhes da implementação interna de uma classe
         * restringindo o acesso aos seus campos (atributos) e métodos
         * 
         * 
         */
    internal class Funcionario
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private decimal _salario;

        public decimal Salario
        {
            get { return _salario; }

            set { _salario = value; }
        }

        public decimal Irpf
        {
            get { return Salario * 0.1m; }
        }
    }
}
