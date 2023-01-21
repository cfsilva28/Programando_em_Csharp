/*
 * Classe Stack
 * 
 * Permite a inclusão de elementos usando o conceito de pilha: o último a entrar é o primeiro a sair
 * 
 * Não é possível acessar os elementos pelo índice (posição) onde estão armazenados
 * 
 * Aplicações: implementação de funções recursivas, mecanismo de fazer e refazer em aplicação,
 * avaliação de expressões em calculadoras especializadas, avaliação de expressões em geral
 * 
 */

/*
 * Exemplo de entrega. A primeira entrega deve estar no topo da pilha para facilitar o manuseio e otimizar a rota
 * 
 */

using System.Collections;

Stack pilha = new Stack();

//Adicionando itens à pilha
pilha.Push("Entrega 5");
pilha.Push("Entrega 4");
pilha.Push("Entrega 3");
pilha.Push("Entrega 2");
pilha.Push("Entrega 1");

//Exibe o primeiro item da pilha
Console.WriteLine($"Próxima Entrega: {pilha.Peek()}");

Console.WriteLine();

//Remove o próximo item da pilha
Console.WriteLine($"Entrega realizada: {pilha.Pop()}");

Console.WriteLine();

//Exibe o primeiro item da pilha
Console.WriteLine($"Próxima Entrega: {pilha.Peek()}");

Console.WriteLine();

//Exibe todas as entregas

Console.WriteLine($"Entregas as serem realizadas");

Console.WriteLine();

foreach (var entrega in pilha)
{

    Console.WriteLine(entrega);

}

Console.ReadKey();