using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05_Modulo03_PropriedadesImpricitas.Class
{
    /*
     * 
     * Propriedades Implícitas
     * 
     * Se não houver nenhuma necessidade de validação para uma propriedade em particular,
     * pode-se defini-la como implícita. Neste caso, não há necessidade de definir atributos private
     */
    internal class Pessoas
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
    }
}
