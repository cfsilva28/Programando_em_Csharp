/*
 * Quando não é sabido quantas vezes um determinado bloco de instruções deverá ser executado, utiliza-se o looop while
 * 
 */


int num = 1000;

while (num <= 5000)
{

    if (num == 3000)
    {

        num += 1000;

        continue; // Caso o valor acima na condição for verdadeiro o "continue" ignora as demais ações abaixo dele
                  // Fazendo a operação iniciar novamente da primeira etapa.
    }

    if (num == 5000)
    {
        break;
    }
    Console.WriteLine($"Número {num}");

    num += 1000;
}

Console.ReadKey();