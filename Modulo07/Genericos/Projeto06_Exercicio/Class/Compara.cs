using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06_Exercicio.Class
{
    internal class Compara
    {

        //Sobrecarga
        public bool ComparaValores(string s, int i)
        {
            return s.Equals(i);
        }

        public bool ComparaValores(int i, int j)
        {
            return i.Equals(j);
        }

        public bool ComparaValores(int i, double j)
        {
            return i.Equals((double)j);
        }
    }
}
