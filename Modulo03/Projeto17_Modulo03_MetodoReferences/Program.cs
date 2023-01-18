
static double Calcular(double valor) => valor * 0.10;

static void Mensagem() => Console.WriteLine("Method References.");

Mensagem();

Console.WriteLine();

double valor = 1000;

Console.WriteLine($"10% de {valor}: {Calcular(valor)}");

Console.ReadKey();