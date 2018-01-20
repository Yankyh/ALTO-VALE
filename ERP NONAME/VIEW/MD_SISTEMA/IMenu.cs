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

        id pessoaButtonOnClick(object sender, EventArgs e)
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

        private void TarefaDiretoOnClick(object sender, EventArgs e)
        {
            ITarefa iTarefa = new ITarefa();
            iTarefa.ShowDialog();
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

        private void JOHANN_Click(object sender, EventArgs e)
        {
            TN_TECNOLOGIA.EditorSQL.Tela Tela = new TN_TECNOLOGIA.EditorSQL.Tela();
            Tela.ShowDialog();
        }
    }
}
