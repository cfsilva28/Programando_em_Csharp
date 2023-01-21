/*
 * IEnumerable
 * 
 * Não permite alterações na coleção, ou seja, funciona apenas como leitura
 * 
 * Não fornece nenhuma informação sobre a coleção
 * 
 * Não permite acesso aleatório às posições, ou seja, somente é possível percorrer a coleção sequencialmente
 * 
 * Indicado para consultar dados a partir de coleções como List<T> e Array
 * 
 */

List<string> nomes = new List<string>()
{ "Andrea", "Cesar", "Diogo", "Jonathan", "Lincoln", "Lorran", "Paulo", "Pedro", "Rafael", "Obelix"};

IEnumerable<string> nomesIEnumerable = nomes;

foreach (var nome in nomesIEnumerable)
{

    Console.WriteLine(nome);

}

Console.ReadKey();