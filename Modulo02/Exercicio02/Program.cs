/*
 * Gerar Senha
 * 
 * A senha deve ter entre 4 e 10 dígitos
 * 
 * A quantidade de dígitos deve ser par
 * 
 */

Console.Write("Informe a quantidade de dígitos da senha: ");

int digitos;

try
{

    digitos = Convert.ToInt32(Console.ReadLine());

    if (digitos < 4 || digitos > 10 || digitos % 2 != 0)
    {

        Console.WriteLine("A quantidade de dígitos é inválida");

        Console.ReadKey();

        return;

    }

    string senha = "";

    var randomico = new Random();

    for (int i = 1; i <= digitos; i++)
    {

        int numero = randomico.Next(0, 9);

        senha += numero; //senha = senha + numero

    }

    Console.WriteLine($"Senha gerada: {senha}");

}
catch (Exception e)
{

    Console.WriteLine(e.Message);

}

Console.ReadKey();