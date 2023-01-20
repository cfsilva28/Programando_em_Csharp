using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_Interfaces.Interfaces
{
    /*
     * Interfaces
     * 
     * Auxiliam na definição das classes 
     * 
     * São formadas pela declaração de um ou mais métodos
     * 
     * Quando implementada uma interface garante que seus métodos sejam implementados na classe
     * 
     * Os membros da interface são automaticamente públicos
     */
    internal interface IFigura
    {
        double CalcularArea();

        string Exibir();
    }
}
