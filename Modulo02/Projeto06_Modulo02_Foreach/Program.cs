/*
 *  Foreach
 *  
 *  Este loop é utilizado para percorrer coleções
 *  Ao ser executado, seu iterador percorrerá todos os elementos da coleção, permitindo o acesso
 *  às suas propriedades e métodos
 *  
 */

string[] lista = { "Brasil", "Alemanha", "México", "Chile", "Holanda", "Polônia", "Argentina", "França" };

foreach (var pais in lista)
{
    if (pais.Contains("n"))
    {
        Console.WriteLine($"Nome do país: {pais}");
    }

}

Console.ReadKey();