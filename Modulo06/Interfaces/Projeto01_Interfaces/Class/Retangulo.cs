using Projeto01_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_Interfaces.Class
{

    //Retângulo IMPLEMENTA IFigura
    internal class Retangulo : IFigura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double CalcularArea()
        {
            return Base * Altura;
        }

        public string Exibir()
        {
            return $"Área do Retângulo: {CalcularArea()}";
        }
    }
}
