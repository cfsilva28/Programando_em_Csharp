using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_Heranca.Class
{

    /*
     *Herança
     *Cada vendedor é um funcionário
     *
     *Nem todo funcionário é um vendedor
     *
     */
    //A classe Vendedor é Subclasse da classe funcionário
    internal class Vendedor : Funcionario
    {
        public decimal PercentualComissao { get; set; }

        public decimal SalarioFinal()
        {
            return Salario * (1 + PercentualComissao);
        }
    }
}
