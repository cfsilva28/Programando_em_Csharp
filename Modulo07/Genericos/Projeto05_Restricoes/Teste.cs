/*
 * Restrições ao uso dos genéricos
 * 
 * where T: class
 * whete T: struct
 * whete T: notnull
 * whete T: new();
 * whete T: <nome da classe>
 * whete T: <nome da interface>
 * 
 */

using Projeto05_Restricoes.Class;

internal class Teste : Teste<string>
{
}