using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ALTO_VALE.VIEW.MD_SISTEMA;
using ALTO_VALE.VIEW.PS_PESSOA;
using ALTO_VALE.VIEW.TR_TAREFA;

namespace ALTO_VALE.TN_TECNOLOGIA.Controles
{
    class ControleDadosMenu
    {
        //String de campos separados por ponto e vírgula
        String query = "";

        public void GerenciarMenuDataGridView(String tela)
        {
            //Pessoa
            if (tela == "Pessoa")
            {
                query = "";
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
                VIEW.TN_EMAIL.IServidorEmail servidor = new VIEW.TN_EMAIL.IServidorEmail();
                servidor.ShowDialog();
            }
            //Cep
            if (tela == "Cep")
            {
                GCep gCep = new GCep();
                gCep.ShowDialog();
            }
        }



    }
}
