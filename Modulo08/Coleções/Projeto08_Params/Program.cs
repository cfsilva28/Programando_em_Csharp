static decimal CalcularMedia(params decimal[] numeros)
{
    decimal soma = 0;

    for (int i = 0; i < numeros.Length; i++)
    {
        soma += numeros[i]; // soma = soma + numeros[i]
    }

    return soma / numeros.Length;
}

Console.WriteLine($"Média: {CalcularMedia(1,2,3,4,5,6)}");

Console.ReadKey();