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
using ALTO_VALE.TN_TECNOLOGIA;
using ALTO_VALE.TN_TECNOLOGIA.Controles;
//using ALTO_VALE.TN_TECNOLOGIA.Controles;
using ALTO_VALE.TN_TECNOLOGIA.EditorSQL;
using ALTO_VALE.VIEW.MD_SISTEMA;
using ALTO_VALE.VIEW.PS_PESSOA;
using ALTO_VALE.VIEW.TR_TAREFA;

namespace ALTO_VALE
{
    public partial class Form1 : Form
    {
        // ControleTelaMenu controleTelaMenu = new ControleTelaMenu();
        ControleTela controleTela = new ControleTela();
        public Form1()
        {
            InitializeComponent();
         
        }


        private void MenuTreeViewDoubleClick(object sender, EventArgs e)
        {
            String nodeSelecionado = "";
            try
            {
                if (menuTreeView.SelectedNode.IsExpanded == false)
                {
                    nodeSelecionado = menuTreeView.SelectedNode.Text;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

            if (nodeSelecionado != "")
            {
                ControleTelas(nodeSelecionado);
                menuTreeView.Visible = false;
            }

        }

        //Controle de tela
        public void ControleTelas(String form)
        {
            //Pessoa
            if (form == "Pessoa")
            {
                GPessoa gPessoa = new GPessoa();
                gPessoa.MdiParent = this;
                gPessoa.Show();
            }
            //Endereço
            if (form == "Endereço")
            {
                IPessoaEndereco iPessoaEndereco = new IPessoaEndereco();
                iPessoaEndereco.MdiParent = this;
                iPessoaEndereco.Show();
            }
            //Contato
            if (form == "Contato")
            {
                IPessoaContato iPessoaContato = new IPessoaContato();
                iPessoaContato.MdiParent = this;
                iPessoaContato.Show();
            }
            //Tarefa
            if (form == "Tarefa")
            {
                GTarefa gTarefa = new GTarefa();
                gTarefa.MdiParent = this;
                gTarefa.Show();
            }
            //Cep
            if (form == "Cep")
            {
                GCep gCep = new GCep();
                gCep.MdiParent = this;
                gCep.Show();
            }


        }
        private void AbrirEditor(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F11)
            {
                Tela tela = new Tela();
                tela.ShowDialog();
            }
        }

        private void MenuButtonOnClick(object sender, EventArgs e)
        {
            if (menuTreeView.Visible == true)
            {
                menuTreeView.Visible = false;
                menuButton.Location = new Point(1, 46);
            }
            else
            {
                menuTreeView.Visible = true;
                menuButton.Location = new Point(281, 55);
            }
           
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("s");
        }
    }
}
