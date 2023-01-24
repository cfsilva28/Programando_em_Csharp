using Projeto06_Exercicio.Class;

int i = 10;
int j = 10;
string s = "10";

//Usando sobrecarga

Console.WriteLine("Exemplo usando sobrecarga");

Console.WriteLine();

Compara compara = new Compara();

Console.WriteLine($"Os valores {s} ({s.GetType()}) e {i} ({i.GetType()}) são iguais: {compara.ComparaValores(s, i)}");

Console.WriteLine();

Console.WriteLine(new String('_', 60));

Console.WriteLine();

Console.WriteLine("Exemplo usando método genérico");

Console.WriteLine();

var comparaGenerico = new ComparaGenerico<string, int>();

Console.WriteLine($"Os valores {s} {s.GetType()} e {i} {i.GetType()} são iguais: {comparaGenerico.ComparaValores(s,i)}");

Console.ReadKey();