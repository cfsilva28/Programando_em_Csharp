/*
 * Switch Case
 * 
 * Pode ser utilizado com expressões do tipo inteiro, char, sting, enumerados
 * 
 */

Console.Write($"Informe um valor: ");

int diaSemana = Convert.ToInt32(Console.ReadLine());

string resultado = string.Empty;

switch (diaSemana)
{
    case 1:

        resultado = "Domingo";
        break;

    case 2:

        resultado = "Segunda-Feira";
        break;

    case 3:

        resultado = "Terça-Feira";
        break;

    case 4:

        resultado = "Quarta-Feira";
        break;

    case 5:

        resultado = "Quinta-Feira";
        break;

    case 6:

        resultado = "Sexta-Feira";
        break;

    case 7:

        resultado = "Sábado";
        break;

    default:

        resultado = "Informe um valor entre 1 e 7";
        break;

}

Console.WriteLine($"Dia informado: {resultado}");

Console.WriteLine(new string('-', 50));

/*
 * 
 * Executar as mesmas instruções para mais de um valor
 */

string classificacaoDia = "";

switch (resultado)
{
    case "Segunda-Feira":
    case "Terça-Feira":
    case "Quarta-Feira":
    case "Quinta-Feira":
    case "Sexta-Feira":

        classificacaoDia = $"{resultado} é Dia ùtil";
        break;

    case "Sábado":
    case "Domingo":

        classificacaoDia = $"{resultado} é Fim de Semana";
        break;

    default:

        classificacaoDia = $"Não é possível determinar se o dia informado é Dia ùltil ou Fim de Semana";
        break;
}

Console.WriteLine(classificacaoDia);

Console.ReadKey();
