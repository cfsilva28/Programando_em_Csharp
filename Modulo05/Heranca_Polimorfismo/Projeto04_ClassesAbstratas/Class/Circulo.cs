using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_ClassesAbstratas.Class
{
    internal class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }
        public override double CalcularArea()
        {
            return Math.Round(Math.PI * Raio * Raio, 3);
        }
    }
}
