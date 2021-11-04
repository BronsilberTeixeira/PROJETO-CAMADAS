using System;
using System.Windows.Forms;

//Importação da camada de negócio
using Projeto3Camadas.Code.BLL; 
using Projeto3Camadas.Code.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta

namespace Projeto3Camadas.Ui
{
    public partial class frmCadastroHospedes : Form
    {

        //Criação dos objetos que acessam a camada de negócio
        HospedesBLL medbll = new HospedesBLL();
        HospedesDTO meddto = new HospedesDTO();

        public frmCadastroHospedes()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.cpf = int.Parse(txtCpf.Text);
            meddto.nome = txtNome.Text;
            meddto.quarto = txtQuarto.Text;

            //Envio do dto preenchido para o método inserir
            medbll.Inserir(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Cadastrado com sucesso!", "Hospede", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Limpeza dos componentes
            txtCpf.Clear();
            txtNome.Clear();
            txtQuarto.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

    }
}
