using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALTO_VALE.VIEW.MD_SISTEMA;
using ALTO_VALE.VIEW.PS_PESSOA;
using ALTO_VALE.VIEW.TR_TAREFA;

namespace ALTO_VALE.TN_TECNOLOGIA.Controles
{
    class ControleTelasMenu
    {

        public static  void ControleTelas(String form)
        {
            //Pessoa
            if(form == "Pessoa")
            {
                GPessoa gPessoa = new GPessoa();
                gPessoa.ShowDialog();
            }
            //Endereço
            if (form == "Endereço")
            {
                IPessoaEndereco iPessoaEndereco = new IPessoaEndereco();
                iPessoaEndereco.ShowDialog();
            }
            //Contato
            if (form == "Contato")
            {
                IPessoaContato iPessoaContato = new IPessoaContato();
                iPessoaContato.ShowDialog();
            }
            //Tarefa
            if(form == "Tarefa")
            {
                GTarefa gTarefa = new GTarefa();
                gTarefa.ShowDialog();
            }
            //Cep
            if(form == "Cep")
            {
                GCep gCep = new GCep();
                gCep.ShowDialog();
            }


        }
    }
}
