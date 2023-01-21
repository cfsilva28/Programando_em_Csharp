/*
 * Classe Queue (Filas)
 * 
 * O primeiro a entrar é o primeiro a sair
 * 
 * Aplicações: fila de espera, transferência assíncrona de dados, agendamento de tempo de CPU, armazenamento de teclas
 * digitas no teclado, resposta a requisiçõe de serviços compartilhados, etc
 * 
 */

using System.Collections;

Queue fila = new Queue();

//Adiciona pacientes à fila
fila.Enqueue("João");
fila.Enqueue("Isabela");
fila.Enqueue("Maria");
fila.Enqueue("Ricardo");
fila.Enqueue("José");

//Exibe o próximo da fila
Console.WriteLine($"Próximo paciente da fila: {fila.Peek()}");

Console.WriteLine();

//Remove paciente da fila
Console.WriteLine($"Paciente atendido: {fila.Dequeue()}");

Console.WriteLine();

//Exibe o próximo da fila
Console.WriteLine($"Próximo paciente da fila: {fila.Peek()}");

Console.WriteLine();

//Exibe a fila de pacientes aguardando atendimento
Console.WriteLine("Pessoas aguardando atendimento");

Console.WriteLine();

foreach (var pessoa in fila)
{

    Console.WriteLine(pessoa);

}


Console.ReadKey();