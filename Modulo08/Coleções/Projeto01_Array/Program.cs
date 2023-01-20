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
Console.ReadKey();