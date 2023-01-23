using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_MetodosGenericos.Class
{/*
  *
  * Declaração de um método generico
  * 
  */
    internal class Classe
    {
        public string MetodoGenerico<T>(T elemento)
        {
            return $"{elemento}";
        }
    }
}
