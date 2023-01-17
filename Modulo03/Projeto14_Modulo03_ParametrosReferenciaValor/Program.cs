/*
 * Tipo-valor
 * 
 * Quando uma variável é declarada como um tipo-valor, o compilador gera o código que aloca um bloco de memória
 * grande o suficiente para conter o valor correspondente
 * 
 * Exemplo: int, float, double, char, bool
 * 
 */

/*
 * Tipo-Referência
 * 
 * Quando um objeto, de uma classe é instanciado, o compilador NÂO gera o código que aloca um bloco de memória grande 
 * o suficiente para armazenar um objeto; tudo o que ele faz é alocar uma pequena parte da memória que o possar armazenar
 * o endereço de outro bloco de memória que contém o objeto.
 * 
 * Um endereço especifica a localização de um item na memória.
 * 
 * A memória para o objeto só é alocada quando a palavra chave NEW é utilizada para criar o objeto.
 * 
 * Exemplos: classes, interfaces, delegates
 */

using Projeto14_Modulo03_ParametrosReferenciaValor.Class;

Console.WriteLine("Passagem de Prâmetro - Valor");

Console.WriteLine();

int i = 5;

Console.WriteLine($"Valor de i: {i}");

Passagem.Valor(i);

Console.WriteLine($"Valor de i: {i}");

Console.WriteLine();

Console.WriteLine(new string('-', 60));

Console.WriteLine();

Console.WriteLine("Passagem de Parâmetro - Palavra chave ref");

Console.WriteLine();

int j = 10;

Console.WriteLine($"Valor de j: {j}");

Passagem.Incremento(ref j);

Console.WriteLine($"Valor de j: {j}");

Console.ReadKey();