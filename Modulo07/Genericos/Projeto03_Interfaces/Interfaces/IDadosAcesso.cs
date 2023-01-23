using Projeto03_Interfaces.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_Interfaces.Interfaces
{
    internal interface IDadosAcesso<T, K>
    {
        Cliente Buscar(int codigo);

        bool incluir(Cliente cliente);
    }
}
