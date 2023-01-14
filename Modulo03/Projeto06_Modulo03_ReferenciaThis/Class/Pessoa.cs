using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06_Modulo03_ReferenciaThis.Class
{
    /*
     * Referência This
     * 
     * Quando os membros são acessados dentro da PRÓPRIA CLASSE, é através de uma referência, chamada THIS
     * que estes membros são referenciados
     * 
     */
    internal class Pessoa
    {
        public string Nome { get; set; }
        public byte Idade { get; set; }
        public char Genero { get; set; }


        public void ObterDados(string Nome, byte Idade, char Genero)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Genero = Genero;
        }

    }
}
