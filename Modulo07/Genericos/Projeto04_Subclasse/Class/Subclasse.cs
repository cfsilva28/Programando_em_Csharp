using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_Subclasse.Class
{

    /*
     * Se, na subclasse, o tipo não for especificado na superclasse, durante o processo de herança, isso 
     * significa que a subclasse deve ser genérica
     *  
     * A sublcasse está repassando o parâmetro de tipo para a superclasse. Quando instanciada, a Sublcasse deverá
     * receber seu tipo adequadamente 
     */
    internal class Subclasse<T> : ClasseBase<decima>
    {
    }
}
