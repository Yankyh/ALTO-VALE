﻿using ALTO_VALE.VIEW.MD_SISTEMA;
using ALTO_VALE.VIEW.PS_PESSOA;
using ALTO_VALE.VIEW.TR_TAREFA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTO_VALE.TN_TECNOLOGIA.Controles
{
    class ControleTelaMenu
    {


        public void ControleTela(String tela)
        {
            //Pessoa
            if (tela == "Pessoa")
            {
                GPessoa gPessoa = new GPessoa();
                gPessoa.ShowDialog();
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
            //Cep
            if (tela == "Cep")
            {
                GCep gCep = new GCep();
                gCep.ShowDialog();
            }
        }








    }
}