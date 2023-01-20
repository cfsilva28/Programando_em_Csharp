using Projeto02_Exercicio.Class;
using Projeto02_Exercicio.Interfaces;

ILog iLogDisco = new LogDisco("c:\\log\\log.txt");

Log logDisco = new Log(iLogDisco);

logDisco.Registrar("tentativa suspeita de acesso");

Console.ReadKey();