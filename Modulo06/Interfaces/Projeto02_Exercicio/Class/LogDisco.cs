using Projeto02_Exercicio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Exercicio.Class
{
    internal class LogDisco : ILog
    {
        private string diretorio;

        public LogDisco(string diretorio)
        {
            this.diretorio = diretorio;
        }
        public void RegistroLog(string mensagem)
        {
            Console.WriteLine("Log salvo no disco");
        }
    }
}
