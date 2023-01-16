
using Projeto09_Modulo03_ModificarStatic.Class;

Automovel automovel = new Automovel();

Automovel.Fabricante = "VolksWagen";
Automovel.Modelo = "T-Cross";

Console.WriteLine(automovel.ExibirDados());

Console.ReadKey();