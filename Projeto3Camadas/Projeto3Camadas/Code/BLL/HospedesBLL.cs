using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importação da camada de negócio e da camada de acesso a dados
using Projeto3Camadas.Code.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta
using Projeto3Camadas.Code.DAL;

namespace Projeto3Camadas.Code.BLL
{
    class HospedesBLL
    {

        //Objeto para acesso ao banco de dados
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "hospedes";


        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir (HospedesDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values('{medDto.cpf}','{medDto.nome}','{medDto.quarto}')";
            conexao.ExecutarComando(inserir);
        }
    }
}
