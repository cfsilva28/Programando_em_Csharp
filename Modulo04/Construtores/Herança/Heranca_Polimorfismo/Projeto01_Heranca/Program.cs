using Projeto01_Heranca.Class;

Vendedor vendedor = new Vendedor();

vendedor.Nome = "João";
vendedor.Cargo = "Departamento Masculino";
vendedor.Salario = 3500;
vendedor.PercentualComissao = 0.15m;

Console.WriteLine($"Nome do Vendedor: {vendedor.Nome}\nSalário: {vendedor.SalarioFinal()}");

Console.ReadKey();