using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Modulo03_Propriedades.Class
{

    /*
     * Uma propriedade é um valor que a classe disponibiliza para leitura e gravação
     * 
     * get: leitura da propriedade
     * set: escrita da prpopriedade
     * 
     */

    internal class Automovel
    {

        //Campos
        private string? _corCarro;

        private decimal _valorCarro;

        private string? _placaCarro;

        //Propriedade
        public string? Modelo { get; set; }

        public string? Fabricante { get; set; }

        public short Ano { get; }

        public string Placa
        {

            get
            {

                return _placaCarro;

            }
            set
            {

                _placaCarro = value;

            }

        }

        public decimal Valor
        {

            get
            {

                return _valorCarro;

            }

        }

        public string Cor
        {

            set
            {

                _corCarro = value;

            }
        }

    }
}