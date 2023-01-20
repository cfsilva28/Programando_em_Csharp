using Projeto01_Interfaces.Class;
using Projeto01_Interfaces.Interfaces;

IFigura retangulo = new Retangulo()
{
    Base = 30,
    Altura = 15
};

Console.WriteLine(retangulo.Exibir());

Console.ReadKey();

