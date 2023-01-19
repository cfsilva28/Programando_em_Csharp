using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06_ClassesEstaticas.Clas
{
    /*
     * Classe Estática
     * 
     * São seladas (sealed), ou seja, não podem ser herdadas
     * 
     * Seu uso é indicado em situações às quais deseja-se evitar a associação de métodos a objetos específicos
     * 
     * Todos os métodos e propriedades de uma classe estática devem ser estáticos
     */

    internal static class DB
    {
        public static string? Endereco { get; }
        public static bool ConectDb()
        {
            //TODO: 
            return true;
        }
    }
}
