/*
 *  ArrayList
 *  
 * É um array de objetos que tem seus próprios métodos
 * 
 * Inserir
 * Adicionar
 * Procurar
 * Ordernar
 * 
 */

using System.Collections;

ArrayList lista = new ArrayList();

//Adiciona elementos na lista

lista.Add("Notebook");
lista.Add("Monitor");
lista.Add("Câmera");
lista.Add("Teclado");
lista.Add("Mouse");
lista.Add("Mesa");
lista.Add("Cadeira");

Console.WriteLine("Itens adicionados na lista");

Console.WriteLine();

for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}

Console.WriteLine();

//Insere novo item na lista na posição indicada
lista.Insert(0, "Ar-Condicionado");

Console.WriteLine("Item inserido na lista (posição 0)");

Console.WriteLine();

for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}

Console.WriteLine();

//Remove um item da lista

lista.Remove("Ar-Condicionado");

Console.WriteLine("Item Removido da Lista (Ar-Condicionado)");

for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}

Console.WriteLine();

//Obtem o índice (posição) de um elemento. O primeiro elemento possui indice 0. Retornará -1, caso o elemento não exista na lista
Console.WriteLine($"Índice do elemento Teclado: {lista.IndexOf("Teclado")}");

Console.WriteLine();

//Ordena lista
lista.Sort();

Console.WriteLine("Lista Ordenada");

Console.WriteLine();

for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}


Console.ReadKey();