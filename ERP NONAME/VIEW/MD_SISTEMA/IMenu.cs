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
        //Variaveis de configuração dos datagridviews que são padrão
        int SITUACAOWIDTH = 32;

        public Form1()
        {
            InitializeComponent();
            connection.Conectar();
            adicionarButton.Enabled = false;
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
                    adicionarButton.Enabled = true;
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

      // Esse método é responsável pelos key events, ( precisa dar override no processdialog pois o c# é bugado )
      /*  protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F11:
                    TN_TECNOLOGIA.EditorSQL.Tela editor = new TN_TECNOLOGIA.EditorSQL.Tela();
                    editor.ShowDialog();
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }*/

        //Controle do datagridview
     
        private void GerenciarMenuDataGridView(String tela)
        {
            telaSelecionada = tela;
            String query = "";
            menuDataGridView.DataSource = null;
            BindingSource Binding = new BindingSource();
            ControleTelaMenu controleTelaMenu = new ControleTelaMenu();

            //Pessoa
            if (tela == "Pessoa")
            {
                query = " SELECT A.HANDLE, B.IMAGEM SIT, A.RAZAOSOCIAL AS 'RAZÃO SOCIAL', A.APELIDO APELIDO, A.CPFCNPJ AS 'CPF/CNPJ', A.TELEFONE, C.CIDADE, D.SIGLA ESTADO, C.LOGRADOURO" +
                               " FROM PS_PESSOA A" +
                               " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS " +
                               " LEFT JOIN PS_PESSOAENDERECO C ON C.HANDLE = (SELECT MAX(HANDLE) FROM PS_PESSOAENDERECO WHERE PESSOA = A.HANDLE)" +
                               " LEFT JOIN MD_ESTADO D ON D.HANDLE = C.ESTADO";
                Binding.DataSource = connection.DataTable(query);
                menuDataGridView.DataSource = Binding;

                menuDataGridView.Columns[0].Visible = false;
                menuDataGridView.Columns[1].Width = SITUACAOWIDTH;
                menuDataGridView.Columns[2].Width = 300;
                menuDataGridView.Columns[3].Width = 300;
                menuDataGridView.Columns[4].Width = 150;
                menuDataGridView.Columns[5].Width = 130;
                menuDataGridView.Columns[8].Width = 230;
                menuDataGridView.AllowUserToResizeRows = false;
            }
            //Tarefa
            if (tela == "Tarefa")
            {
                query = " SELECT A.HANDLE, B.IMAGEM SIT, F.NOME SITUAÇÃO, E.NOME SEVERIDADE, G.NOME TIPO, A.PRAZO, A.ASSUNTO, C.LOGIN SOLICITANTE, D.LOGIN RESPONSAVEL, A.DATA " +
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
                menuDataGridView.Columns[1].Width = SITUACAOWIDTH;
                menuDataGridView.Columns[2].Width = 120;
                menuDataGridView.Columns[3].Width = 120;
                menuDataGridView.Columns[4].Width = 150;
                menuDataGridView.Columns[5].Width = 150;
                menuDataGridView.Columns[6].Width = 650;
                menuDataGridView.Columns[7].Width = 120;
                menuDataGridView.Columns[8].Width = 130;
                menuDataGridView.Columns[9].Width = 150;
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
                query = " SELECT A.HANDLE, B.IMAGEM SIT, A.CEP, A.PAIS, A.ESTADO, A.CIDADE, A.BAIRRO, A.LOGRADOURO" +
                               " FROM MD_CEP A" +
                               " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS";
                Binding.DataSource = connection.DataTable(query);
                menuDataGridView.DataSource = Binding;

                menuDataGridView.Columns[1].Width = SITUACAOWIDTH;
                menuDataGridView.Columns[2].Width = 150;
                menuDataGridView.Columns[3].Width = 150;
                menuDataGridView.Columns[4].Width = 150;
                menuDataGridView.Columns[5].Width = 200;
                menuDataGridView.Columns[7].Width = 300;
                menuDataGridView.Columns[0].Visible = false;
            }
          
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
        
        private void ContextOnRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripPadrao.Enabled = true;
                contextMenuStripPadrao.Visible = true;
            }
        }

        private void AdicionarButtonOnClick(object sender, EventArgs e)
        {
            ControleTelaMenu.handleOrigem = 0;
            ControleTelaMenu controleTelaMenu = new ControleTelaMenu();
            controleTelaMenu.ControleTela(telaSelecionada);
        }

        private void MenuFormActivated(object sender, EventArgs e)
        {
            GerenciarMenuDataGridView(telaSelecionada);
        }


        private void MenuFormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Desconectar();
        }
    }
}
