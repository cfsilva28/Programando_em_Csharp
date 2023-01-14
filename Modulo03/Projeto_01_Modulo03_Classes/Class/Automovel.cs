using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_Modulo03_Classes.Class
{

    /*
     * Clasee é um modelo que representa um conjunto de elementos (pessoas, objetos, etc) com características comuns
     * 
     * A classe é um abstração de um possível elemento
     */

    /*
     * Tipos de modificadores
     * 
     * public: o acesso é livre quando esse modificador é utilizado
     * 
     * private: é a visibilidade definida para métodos e campos da própria classe
     * 
     * protected: apenas a classe que contém modificadore e os tipos derivados dessa classe possuem acesso
     * 
     * internal: limita o acesso apenas ao assembly atual
     * 
     * protected internal: o acesso é limitado ao assembly atual e aos tipos derivados da classe que contém o modificador
     * 
     * 
     */

    /*
     * 
     * Valores padrão dos atributos (membros, campos)de uma classe
     * 
     * int: 0
     * boolean: false
     * string: null 
     *     
     */

    /*
     * Atríbutos
     * 
     * Características específicas de um objeto
     * 
     * Para poder definir e controlar todas características que os objetos podem ter, a classe as armazena em propriedades
     */


    internal class Automovel
    {
        public string Fabricante;
        public string Modelo;
        public string Placa;
        public string Cor;
        public short Ano;
    }
}
