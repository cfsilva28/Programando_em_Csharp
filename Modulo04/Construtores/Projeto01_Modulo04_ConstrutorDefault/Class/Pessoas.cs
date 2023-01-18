using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_Modulo04_ConstrutorDefault.Class
{
    /*/
     * Construtores
     * 
     * Um construtor é um método executado automaticamente toda vez que instanciamos uma classe através do operador new
     * 
     * Toda classe tem um construtor default
     * 
     * Não retorna valor
     */
    internal class Pessoas
    {
        public string Nome { get; set; } = "Não informado";
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public string DadosPessoa()
        {
            return $"Nome: {Nome}\nIdade: {Idade}\nPeso: {Peso}\n: {Altura}";
        }
    }
}
