using Projeto02_Exercicio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Exercicio.Class
{
    internal class Log
    {
        private ILog ilog;

        //injeção de dependência
        public Log(ILog ilog)
        {
            this.ilog = ilog;
        }

        public void Registrar(string mensagem)
        {
            ilog.RegistroLog(mensagem);
        }
    }
}
