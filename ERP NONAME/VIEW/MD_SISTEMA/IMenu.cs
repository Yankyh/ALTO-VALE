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
        
        public Form1()
        {
            InitializeComponent();
            menuButton.Location = new Point(1, 46);
            menuTreeView.Visible = false;

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
            }

        }


        private void ControleTelas(String tela)
        {
            ControleTelaMenu controleTelaMenu = new ControleTelaMenu();
            controleTelaMenu.ControleTela(tela);
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
                menuButton.Location = new Point(213, 55);
            }
        }

        private void MenuFormDeactivate(object sender, EventArgs e)
        {
            menuButton.Location = new Point(1,46);
            menuTreeView.Visible = false;
        }

        private void AbreEditorSql(object sender, KeyEventArgs e)
        {

        }

        private void ActiveOnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String nodeSelecionado = "";
                try
                {
                    if (menuTreeView.SelectedNode.IsExpanded == false)
                    {
                        nodeSelecionado = menuTreeView.SelectedNode.Text;
                    }
                }
                //
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                if (nodeSelecionado != "")
                {
                    ControleTelas(nodeSelecionado);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PADRONIZACAO.Form1 teste = new PADRONIZACAO.Form1();
            teste.ShowDialog();
        }
    }
}
