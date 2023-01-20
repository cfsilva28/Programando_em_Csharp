using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Exercicio.Interfaces
{
    /*
     * Interfaces
     * 
     * Permitem desenvolver sistemas com baixo acoplamento e mais flexível a mudanças. Se houver alterações
     * será necessário apenas mudar a implementação 
     * 
     * Ao usar interfaces, o desenvolvedor não precisa se preocupar como ela será implementada
     * 
     * Permite que o código se torne mais felixível, possibilitando trocar a implementação de um componente por outro
     * 
     * O código gerado é mais fácil de manter e estender, visto que exite uma separação de responsabilidades ente
     * os componentes do sistema e as regras de negócio
     * 
     * Facilita a realização de testes unitários
     * 
     */

    internal interface ILog
    {
        void RegistroLog(string mensagem);
    }
}
