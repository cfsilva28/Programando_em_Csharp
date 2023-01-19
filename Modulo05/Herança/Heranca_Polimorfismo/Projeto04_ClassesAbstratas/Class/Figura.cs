using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_ClassesAbstratas.Class
{
    /*
     * Classes Abstratas
     * 
     * Não podem ser instanciadas, mas podem ser estendidas (herança)
     * 
     * AS SUBCLASSES deverão sobrescrever os métodos da superclasse
     * 
     * Métodos abstratos não possuem implementação e só podem ser declarados em classes abstratas
     */
    internal abstract class Figura
    {
        public abstract double CalcularArea();

        public string Exibir()
        {
            double area = this.CalcularArea();

            return $"Área da figura {GetType().Name}: {area}";
        }
    }
}
