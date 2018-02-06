using ALTO_VALE.DAL;
using ALTO_VALE.VIEW.MD_SISTEMA;
using ALTO_VALE.VIEW.PS_PESSOA;
using ALTO_VALE.VIEW.TR_TAREFA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTO_VALE.TN_TECNOLOGIA.Controles
{
    class ControleTelaMenu
    {
        Connection connection = new Connection();
        public static int handleOrigem = 0;

        public void ControleTela(String tela)
        {
            connection.Conectar();

            //Pessoa
            if (tela == "Pessoa")
            {
                PSPessoaFormulario(handleOrigem);
            }
            if (tela == "Endereço")
            {
                IPessoaEndereco iPessaEndereco = new IPessoaEndereco();
                iPessaEndereco.ShowDialog();
            }
            if (tela == "Contato")
            {
                IPessoaContato iPessoaContato = new IPessoaContato();
                iPessoaContato.ShowDialog();
            }
            //Tarefa
            if (tela == "Tarefa")
            {
                GTarefa gTarefa = new GTarefa();
                gTarefa.ShowDialog();
            }
            if (tela == "Servidor de Email")
            {
                VIEW.TN_EMAIL.IServidorEmail servidor = new VIEW.TN_EMAIL.IServidorEmail(0);
                servidor.ShowDialog();
            }
            //Cep
            if (tela == "Cep")
            {
                GCep gCep = new GCep();
                gCep.ShowDialog();
            }
            connection.Desconectar();
        }


        //Controla as informações enviadas para as telas 
        //Pessoa
        private void PSPessoaFormulario(int handle)
        {
            //Envia para a outra tela o registro
            IPessoa.pessoaHandle = handle;
            IPessoa iPessoa = new IPessoa();
            iPessoa.ShowDialog();
        }





    }
}
