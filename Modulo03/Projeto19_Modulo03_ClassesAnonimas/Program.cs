/*
 * Classes Anônimas
 * 
 * Uma classe anônima é uma classe que não tem nome
 * 
 * Utilizada em expressões de consultas
 * 
 * As classes anônimas só podem conter campos públicos e todos esses campos precisam ser inicializados,
 * não podem ser estáticos e não pode conter nenhum método
 */
//Objeto de uma classe anônima
var objetoAnonimo = new { Nome = "Cesar", Idade = 29, Genero = 'F' };

var outroObjetoAnonimo = new { Nome = "Ferreira", Idade = 16, Genero = 'M' };

objetoAnonimo = outroObjetoAnonimo;

Console.WriteLine($"Nome: {objetoAnonimo.Nome}\nIdade: {objetoAnonimo.Idade}\nGênero: {objetoAnonimo.Genero}");

Console.ReadKey();