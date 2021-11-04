using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class HospedesDTO
    {
        //Properiedades privadas
        private int _cpf;
        private string _nome;
        private string _quarto;

        //Métodos de encapsulamento (CTRL+R,E)
        public int cpf { get => _cpf; set => _cpf = value; }
        public string nome { get => _nome; set => _nome = value; }
        public string quarto { get => _quarto; set => _quarto = value; }
    }
}
