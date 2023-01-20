/*
 * 
 * Do While executa todos os comandos pelo menos uma vez, mesmo quando a condição não é verdadeira
 * 
 */

int num = 8000;

do
{
    Console.WriteLine($"Número: {num}");

    num += 1000;

} while (num <= 12000);

Console.ReadKey();