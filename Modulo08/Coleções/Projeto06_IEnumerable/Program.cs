/*
 * 
 * IEnumerable
 * 
 * Não permite alterações na coleção, ou seja, funciona apenas como leitura
 * 
 * Não fornece nenhuma informação sobre coleção
 * 
 * Não permite acesso aleatório às posições, ou seja, somente é possível percorrer a col~eção sequencialmente
 * 
 * Indicado para consultar dados a partir de coleção como List<T> e Array
 * 
 * 
 */

List<string> nomes = new List<string>()
{ "Andrea","Cesar","Diogo","Jonathan","Lincon","Lorran","Paulo","Pedro","Rafael","Obelix"};

IEnumerable<string> nomeIEnumerable = nomes;

foreach (var nome in nomeIEnumerable)
{
    Console.WriteLine(nome);
}