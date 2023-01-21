/*
 * 
 * List<T> é uma coleção na qual pode-se definir o tipo de dado dos seus elementos
 * 
 */

//Instancia a lista
List<int> lista = new List<int> { 1, 2, 3, 4, 5 };

//Adiciona itens à lista
lista.Add(6);
lista.Add(7);
lista.Add(8);
lista.Add(9);
lista.Add(0);

//Ordena lista Ordem Descrescente
List<int> listaOrdenada = lista.OrderByDescending(x => x).ToList();

//Ordena lista Ordem Crescente
listaOrdenada = lista.OrderBy(x => x).ToList();

Console.WriteLine("Lista de inteiros");

Console.WriteLine();

foreach (var numero in listaOrdenada)
{

    Console.Write($" {numero} ");

}

Console.ReadKey();