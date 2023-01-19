using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_ClassesAbstratas.Class
{
    internal class Retangulo : Figura
    {

        public double Base { get; set; }
        public double Altura { get; set; }

        //Dubiedade entre os nomes das propriedades e os parâmetros do método deve ser resolvida com o operador this

        public Retangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
