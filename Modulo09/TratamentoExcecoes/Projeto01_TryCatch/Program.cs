/*
 * Try: executa se não houver exeção
 * 
 * Catch: captura qualquer exeção encontrada no bloco try
 * 
 * Finally: sempre executado ao final do bloco
 * 
 */

try
{
    Console.WriteLine("informe o numerador: ");

    double numerador = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Informe do denominador: ");

    double denominador = Convert.ToDouble(Console.ReadLine());

    double resultado = numerador / denominador;

    Console.WriteLine($"{numerador} / {denominador}: {resultado}\n\n");
}
catch (Exception e)
{
    //mensagem personalizada
    Console.WriteLine("Erro personalizado: Erro ao realizar a operação\n\n");

    //mensagem com os detalhes do erro
    Console.WriteLine($"Detalhes ténicos: {e.Message}");
}

finally
{
    //é executado independentemente de ter ocorrido uma exeção ou não

    Console.WriteLine("Operação finalizada!");
}

Console.WriteLine("Fim do programa!");
Console.ReadKey();