/*
 * 
 * Arrays
 * 
 * Possuem tamanho fixo
 * 
 * Não pode aumentar ou diminuir o tamanho após a sua declaração
 */

//Array unidimensional

int[] numeros1 = { 0, 50, 100, 200, 250, 450, 500, 200 };


numeros1[7] = 1000;

int[] numeros2 = new int[8];

numeros2[0] = 0;
numeros2[1] = 100;
numeros2[2] = 200;
numeros2[3] = 300;
numeros2[4] = 400;
numeros2[5] = 500;

for (int i = 0; i < numeros1.Length; i++)
{
    Console.WriteLine($"{numeros1[i]}");
}

Console.WriteLine();




//Declaração de um array bidimensional

int[,] notas = { { 17, 22, 12, 44, 34 }, { 23, 33, 12, 31, 45 }, { 2, 45, 35, 1, 22 } };

int linhas = notas.GetLength(0);

int colunas = notas.GetLength(1);

Console.WriteLine();

Console.WriteLine("Valores do array bidimensional");

for (int i = 0; i < linhas; i++)
{
    for (int j = 0; j < colunas; j++)
    {
        Console.Write($" {notas[i, j]}");
    }
    Console.WriteLine("\n");
}

Console.ReadKey();