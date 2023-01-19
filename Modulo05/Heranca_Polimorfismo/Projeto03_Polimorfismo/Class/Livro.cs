using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_Polimorfismo.Class
{
    internal class Livro : Produto
    {
        public short NumeroPaginas { get; set; }

        public override string ExibirDados()
        {
            return $"{base.ExibirDados()}\nNúmero de Páginas: {this.NumeroPaginas}";
        }
    }
}
