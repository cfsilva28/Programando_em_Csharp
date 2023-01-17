using Projeto12_modulo03_MetodosEstaticos.Class;


string texto = "São cabeçalhos, rodapés, construções de gráficos";

string textoSemAcentos = Metodos.RetirarAcentos(texto);

Console.WriteLine(textoSemAcentos);

Console.ReadKey();