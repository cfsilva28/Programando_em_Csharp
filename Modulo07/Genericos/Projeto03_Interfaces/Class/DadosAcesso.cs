using Projeto03_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_Interfaces.Class
{
    internal class DadosAcesso : IDadosAcesso<Cliente, int>
    {
        public Cliente Buscar(int codigo)
        {
            return default;
        }

        public bool incluir(Cliente cliente)
        {
            return default;
        }
    }
}
