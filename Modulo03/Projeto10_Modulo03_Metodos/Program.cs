/*
 * Métodos
 * 
 * Definem as ações dos objetos
 * 
 * Quando um método não retornar um valor, ele deve ser declarado como VOID.
 * 
 * Se um método retornar um valor, este será para a rotina que fez a chamada do método. Para isso o comando RETURN
 * deverá ser utilizado
 * 
 * modificador_acesso tipo NomeMetodo(parâmetros)
 * {
 *      instruções
 *      
 *      return valor;
 * }
 */

//Método que retorna um inteiro (int)

static int Multiplicar(int valor1, int valor2)
{
    return valor1 * valor2;
}

//Método sem retorno

static void Mensagem()
{
    Console.WriteLine("Multiplicação entre 2 números");

    Console.WriteLine();
}

Mensagem();

int valor1 = 10;
int valor2 = 15;

int resultado = Multiplicar(valor1, valor2);

Console.WriteLine($"Multiplicação entre {valor1} e {valor2}: {resultado}");

Console.ReadKey(); 