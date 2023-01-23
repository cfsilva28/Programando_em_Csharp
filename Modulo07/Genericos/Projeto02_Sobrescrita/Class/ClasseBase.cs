using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Sobrescrita.Class
{
    internal abstract class ClasseBase<T>
    {
        //Método virtual: poderá ser sobrescrito na subclasse
        //Tipo de retorno é T
        public virtual T? Metodo()
        {
            //Default: Depende do tipo de T
            return default;
        }

        //Método abstrato: não é implementado, apenas declarado. Deverá ser implementado na subclasse
        public abstract void Metodo2(T item);
    }
}
