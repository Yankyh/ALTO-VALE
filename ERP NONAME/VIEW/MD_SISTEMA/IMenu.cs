using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ALTO_VALE.VIEW.MD_SISTEMA;
using ALTO_VALE.VIEW.PS_PESSOA;
using ALTO_VALE.VIEW.TR_TAREFA;

namespace ALTO_VALE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void enderecoButtonOnClick(object sender, EventArgs e)
        {
            IPessoaEndereco iPessoaEndereco = new IPessoaEndereco();
            iPessoaEndereco.ShowDialog();
        }

        private void pessoaButtonOnClick(object sender, EventArgs e)
        {
            GPessoa gPessoa = new GPessoa();
            gPessoa.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GCep gCep = new GCep();
            gCep.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TN_TECNOLOGIA.EditorSQL.Tela Tela = new TN_TECNOLOGIA.EditorSQL.Tela();
            Tela.ShowDialog();
        }

        private void tarefaButtonOnClick(object sender, EventArgs e)
        {
            GTarefa gTarefa = new GTarefa();
            gTarefa.ShowDialog();
        }
    }
}
