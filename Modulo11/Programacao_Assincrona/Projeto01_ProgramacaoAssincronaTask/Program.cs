/*
 * Programação Assíncrona
 * 
 * Usa-se métodos assíncronos em operações que podem demorar para produzir um resultado (Consulta Bancos de Dados, Webservices etc)
 * 
 * Permite a execução do programa na thread principal enquanto um tarefa de longa duração é executada em uma thread independente
 * 
 * Thread: uma sequência de instruções que podem ser executadas simultaneamente com outras sequências de instruções
 * 
 * Retorno de métodos assíncronos: Task e também Task<T>
 * 
 * Task: usado em métodos assíncronos que não retorna um valor. É a promessa de execução de uma tarefa no futuro
 * 
 * Task<T>: usado em métodos assíncronos que retorna um valor
 * 
 * await: pausa a execução da thread atual até que o método assíncrono seja concluído
 * 
 */

class Program
{
    private static async Task Aguardar(int tempo)
    {
        Console.WriteLine("iniciando tempo de espera...");

        await Task.Delay(tempo);

        Console.WriteLine("Fim do tempo de espera.");

    }

    static async Task Main(string[] args)
    {
        Console.WriteLine("iniciando o programa, tecle algo para continuar...");

        Console.ReadLine();

        int tempo = 6000;

        await Aguardar(tempo);//milisegundos

        Console.WriteLine($"Passaram-se {tempo} milisegundos");

        Console.WriteLine("Fim do programa. ");

        Console.ReadKey();


    }


}

