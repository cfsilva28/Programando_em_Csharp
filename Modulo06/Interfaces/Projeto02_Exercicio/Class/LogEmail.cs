using Projeto02_Exercicio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Exercicio.Class
{
    internal class LogEmail : ILog
    {
        private string email;

        public LogEmail(string email)
        {
            this.email = email;
        }
        public void RegistroLog(string mensagem)
        {
            Console.WriteLine("Log enviado por email");
        }
    }
}
