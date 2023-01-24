using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06_Exercicio.Class
{
    internal class ComparaGenerico<T,V>
    {
        public bool ComparaValores(T t, V v)
        {
            return t.Equals(v);
        }
    }
}
