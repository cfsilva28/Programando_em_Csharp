/*
 *  O loop for deve ser utilizado quando é sabido quantas vezes um bloco de instruções deve ser repetido.
 */

// 5 a 20 em ordem crescente

Console.WriteLine("Números de 5 a 20 em ordem crescente\n");

for (int a = 5; a <= 20; a++)
{
    Console.WriteLine($"Valor de 'a': {a}");
}

Console.WriteLine();

//5 a 20 em ordem decrescente

Console.WriteLine("Números de 5 a 20 em ordem decrescente\n");

for (int a = 20; a > 5; a--)
{
    Console.WriteLine($"Valor de 'a': {a}");
}

Console.ReadKey();