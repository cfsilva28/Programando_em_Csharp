using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_Modulo04_ConstrutorSobrecarregado.Class
{
    /*
     * Sobrecarga de construtores
     * 
     * Utilizado quando nem todas as propriedades de uma classe são requeridas
     * 
     */

    internal class Aluno
    {

        public string? Nome { get; set; }

        public int Idade { get; set; }

        public double Peso { get; set; }

        public double Altura { get; set; }

        //Construtor
        public Aluno(double peso, double altura)
        {

            Peso = peso;
            Altura = altura;

        }

        //Construtor Sobrecarregado
        public Aluno(string nome, double peso, double altura) : this(peso, altura)
        {

            Nome = nome;

        }

        //Construtor Sobrecarregado
        public Aluno(int idade, double peso, double altura) : this(peso, altura)
        {

            Idade = idade;

        }

        //Construtor Sobrecarregado
        public Aluno(string nome, int idade, double peso, double altura) : this(idade, peso, altura)
        {

            Nome = nome;

        }

        public string DadosAluno()
        {

            return $"Nome: {Nome}\nIdade: {Idade}\nPeso: {Peso}\nAltura: {Altura}";

        }

    }
}