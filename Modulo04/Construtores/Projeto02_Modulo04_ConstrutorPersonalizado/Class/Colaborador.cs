using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Modulo04_ConstrutorPersonalizado.Class
{
    internal class Colaborador
    {

        public string Nome { get; set; } = "Não informado";

        public string Cargo { get; set; } = "Não informado";

        public decimal Salario { get; set; } = 0;

        //Construtor Default
        public Colaborador() { }

        //Construtor Personalizado
        public Colaborador(string nome, string cargo, decimal salario)
        {

            Nome = nome;
            Cargo = cargo;
            Salario = salario;

        }

        public string DadosColaborador()
        {

            return $"Nome: {Nome}\nCargo: {Cargo}\nSalário: {Salario:c}";

        }

    }
}
