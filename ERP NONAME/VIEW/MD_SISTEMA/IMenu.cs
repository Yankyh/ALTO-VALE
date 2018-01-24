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
using ALTO_VALE.DAL;
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
        Connection connection = new Connection();

        //Serve para saber qual datagridview esta selecionado
        String telaSelecionada = "";

        public Form1()
        {
            InitializeComponent();
            connection.Conectar();
            adicionarButton.Visible = false;
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
                    adicionarButton.Visible = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

            if (nodeSelecionado != "")
            {
                GerenciarMenuDataGridView(nodeSelecionado);
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
            //GTarefa gTarefa = new GTarefa();
            //gTarefa.ShowDialog();
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
            }
            else
            {
                menuTreeView.Visible = true;
            }
        }

        private void MenuFormDeactivate(object sender, EventArgs e)
        {
            menuButton.Location = new Point(1, 46);
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

        private void button2_Click(object sender, EventArgs e)
        {
            ControleTelaMenuAdicionar controleDadosMenu = new ControleTelaMenuAdicionar();
            // controleDadosMenu.GerenciarMenuDataGridView();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PADRONIZACAO.FormPadrao form = new PADRONIZACAO.FormPadrao();
            form.ShowDialog();
        }
        
        //Controle do datagridview
        private void GerenciarMenuDataGridView(String tela)
        {
            telaSelecionada = tela;
            String query = "";
            BindingSource Binding = new BindingSource();

            //Pessoa
            if (tela == "Pessoa")
            {
                menuDataGridView.AutoGenerateColumns = true;
                query = " SELECT A.HANDLE, B.NOME SITUAÇÃO, A.RAZAOSOCIAL AS 'RAZÃO SOCIAL', A.APELIDO, A.CPFCNPJ AS 'CPF/CNPJ', A.TELEFONE, C.CIDADE, D.SIGLA ESTADO, C.LOGRADOURO" +
                               " FROM PS_PESSOA A" +
                               " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS " +
                               " LEFT JOIN PS_PESSOAENDERECO C ON C.HANDLE = A.ENDERECO" +
                               " LEFT JOIN MD_ESTADO D ON D.HANDLE = C.ESTADO";
                Binding.DataSource = connection.DataTable(query);
                menuDataGridView.DataSource = Binding;

                menuDataGridView.Columns[0].Visible = false;
                menuDataGridView.Columns[1].Width = 150;
                menuDataGridView.Columns[2].Width = 300;
                menuDataGridView.Columns[3].Width = 300;
                menuDataGridView.Columns[4].Width = 150;
                menuDataGridView.Columns[5].Width = 130;
                menuDataGridView.Columns[8].Width = 230;
                menuDataGridView.AllowUserToResizeRows = false;
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
                query = " SELECT A.HANDLE, B.IMAGEM STA, F.NOME SITUAÇÃO, E.NOME SEVERIDADE, G.NOME TIPO, A.PRAZO, A.ASSUNTO, C.LOGIN SOLICITANTE, D.LOGIN RESPONSAVEL, A.DATA " +
                        " FROM TR_TAREFA A" +
                        " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                        " INNER JOIN PS_USUARIO C ON C.HANDLE = A.SOLICITANTE" +
                        " INNER JOIN PS_USUARIO D ON D.HANDLE = A.RESPONSAVEL" +
                        " INNER JOIN TR_TAREFASEVERIDADE E ON E.HANDLE = A.SEVERIDADE" +
                        " INNER JOIN TR_TAREFASITUACAO F ON F.HANDLE = A.SITUACAO" +
                        " INNER JOIN TR_TAREFATIPO G ON G.HANDLE = A.TIPO";
                       //  " WHERE A.STATUS IN (" + status + ")";
                Binding.DataSource = connection.DataTable(query);
                menuDataGridView.DataSource = Binding;

                menuDataGridView.Columns[0].Width = 0;
                menuDataGridView.Columns[0].Visible = false;
                menuDataGridView.Columns[1].Width = 50;
                menuDataGridView.Columns[2].Width = 120;
                menuDataGridView.Columns[3].Width = 120;
                menuDataGridView.Columns[4].Width = 150;
                menuDataGridView.Columns[5].Width = 150;
                menuDataGridView.Columns[6].Width = 850;
                menuDataGridView.Columns[7].Width = 120;
                menuDataGridView.Columns[8].Width = 130;
                menuDataGridView.Columns[9].Width = 150;

                menuDataGridView.AllowUserToResizeRows = false;
            }
            if (tela == "Servidor de Email")
            {
                VIEW.TN_EMAIL.IServidorEmail servidor = new VIEW.TN_EMAIL.IServidorEmail();
                servidor.ShowDialog();
            }
            //Cep
            if (tela == "Cep")
            {
                menuDataGridView.AutoGenerateColumns = true;
                query = " SELECT A.HANDLE, B.NOME, A.CEP, A.PAIS, A.ESTADO, A.CIDADE, A.BAIRRO, A.LOGRADOURO" +
                               " FROM MD_CEP A" +
                               " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS";
                Binding.DataSource = connection.DataTable(query);
                menuDataGridView.DataSource = Binding;

                menuDataGridView.Columns[1].Width = 150;
                menuDataGridView.Columns[2].Width = 150;
                menuDataGridView.Columns[3].Width = 150;
                menuDataGridView.Columns[4].Width = 150;
                menuDataGridView.Columns[5].Width = 200;
                menuDataGridView.Columns[7].Width = 300;
                menuDataGridView.Columns[0].Visible = false;
                menuDataGridView.AllowUserToResizeRows = false;
            }
        }

        private void MenuFormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Desconectar();
        }

        private int BuscarHandleDataGridView()
        {
           int handleRegistroSelecionado = 0;

            try
            {
                handleRegistroSelecionado = Convert.ToInt32(menuDataGridView.CurrentRow.Cells[0].Value);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return handleRegistroSelecionado;
        }
        private void MenuDataGridViewCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Passa um handle de origem para abrir o formulário
            ControleTelaMenu.handleOrigem = BuscarHandleDataGridView();
            ControleTelaMenu controleTelaMenu = new ControleTelaMenu();
            controleTelaMenu.ControleTela(telaSelecionada);
        }

        private void AdicionarButtonOnClick(object sender, EventArgs e)
        {
            ControleTelaMenuAdicionar controleTelaMenuAdicionar = new ControleTelaMenuAdicionar();
            controleTelaMenuAdicionar.ControleTelaAdicionar(telaSelecionada);
        }
    }
}
