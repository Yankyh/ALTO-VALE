using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ALTO_VALE.DAL;
using ALTO_VALE.VIEW.MD_SISTEMA;

namespace ALTO_VALE.VIEW.TR_TAREFA
{
    public partial class ITarefa : Form
    {
        //Variaveis
        String data = "", prazo = "", assunto = "", solicitacao = "";
        int solicitante = 0, tipo = 0, situacao = 0, severidade = 0, responsavel = 0;

        //Bindings
        BindingSource Binding = new BindingSource();
        BindingSource Binding1 = new BindingSource();
        //Variaveis static
        public static int handleTarefa = 0;

        //Conexão com o banco
        Connection connection = new Connection();
        public ITarefa()
        {
            InitializeComponent();
            //abre a conexão
            connection.Conectar();

            if (handleTarefa != 0)
            {
                PreencherFormulario();
            }
            ControleDeStatus();
        }

        //Preenche formulario
        private void PreencherFormulario()
        {
            //Preencher os combo box
            PreencherComboBoxResponsavel();
            PreencherComboBoxSeveridade();
            PreencherComboBoxSituacao();
            PreencherComboBoxSolicitante();
            PreencherComboBoxTipo();
            PreencherAnexoDataGridView();
            PreencherDocumentacaoDataGridView();

            String query = " SELECT A.DATA, A.PRAZO, B.LOGIN SOLICITANTE, C.LOGIN RESPONSAVEL, D.NOME SEVERIDADE, E.NOME SITUACAO, F.NOME TIPO, A.ASSUNTO, A.SOLICITACAO" +
                           " FROM TR_TAREFA A" +
                           " INNER JOIN PS_USUARIO B ON B.HANDLE = A.SOLICITANTE" +
                           " INNER JOIN PS_USUARIO C ON C.HANDLE = A.RESPONSAVEL" +
                           " INNER JOIN TR_TAREFASEVERIDADE D ON D.HANDLE = A.SEVERIDADE" +
                           " INNER JOIN TR_TAREFASITUACAO E ON E.HANDLE = A.SITUACAO" +
                           " INNER JOIN TR_TAREFATIPO F ON F.HANDLE = A.TIPO" +
                           " WHERE A.HANDLE = " + handleTarefa;
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                solicitanteComboBox.SelectedItem = reader["SOLICITANTE"];
                tipoComboBox.SelectedItem = reader["TIPO"];
                situacaoComboBox.SelectedItem = reader["SITUACAO"];
                severidadeComboBox.SelectedItem = reader["SEVERIDADE"];
                dataTextBox.Text = (reader["DATA"]).ToString();
                prazoTextBox.Text = reader["PRAZO"].ToString();
                assuntoTextBox.Text = reader["ASSUNTO"].ToString();
                solicitacaoTextBox.Text = reader["SOLICITACAO"].ToString();
                responsavelComboBox.SelectedItem = reader["RESPONSAVEL"];
            }
            reader.Close();
            //preenche o número
            numeroTextBox.Text = handleTarefa.ToString();

        }
        private void tarefaFormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Desconectar();
            handleTarefa = 0;
        }

        private void gravarButtonOnClick(object sender, EventArgs e)
        {
            AlterarRegistro("Gravar");
        }

        //Metodo de alteração
        private void AlterarRegistro(String acao)
        {
            if (ValidarCamposObrigatorios() == true)
            {
                solicitante = BuscarHandleSolicitante();
                tipo = BuscarHandleTipo();
                situacao = BuscarHandleSituacao();
                severidade = BuscarHandleSeveridade();
                prazo = BuscarPrazoSeveridade(severidadeComboBox.SelectedItem.ToString());
                assunto = assuntoTextBox.Text;
                solicitacao = solicitacaoTextBox.Text;
                data = dataTextBox.Text;
                responsavel = BuscarHandleResponsavel();

                if (acao == "Gravar")
                {
                    String query = " INSERT INTO TR_TAREFA" +
                                  " (STATUS, SOLICITANTE, TIPO, SITUACAO, SEVERIDADE, DATA, PRAZO, ASSUNTO, SOLICITACAO, RESPONSAVEL)" +
                                  " VALUES" +
                                  " (" +
                                  " 2," +
                                  " " + solicitante + "," +
                                  " " + tipo + "," +
                                  " " + situacao + "," +
                                  " " + severidade + "," +
                                  " GETDATE()," +
                                  " " + prazo + "," +
                                  " '" + assunto + "'," +
                                  " '" + solicitacao + "'," +
                                  " " + responsavel + "" +
                                  ")";
                    connection.Inserir(query);
                    //Buscar handle inserido
                    String query1 = " SELECT MAX(HANDLE) HANDLE" +
                                   " FROM TR_TAREFA" +
                                   " WHERE " +
                                   " STATUS = 2" +
                                   " AND SOLICITANTE = " + solicitante +
                                   " AND TIPO = " + tipo +
                                   " AND SITUACAO = " + situacao +
                                   " AND SEVERIDADE = " + severidade +
                                   " AND ASSUNTO = '" + assunto + "'" +
                                   " AND SOLICITACAO = '" + solicitacao + "'" +
                                   " AND RESPONSAVEL = " + responsavel;
                    SqlDataReader reader = connection.Pesquisa(query1);
                    while (reader.Read())
                    {
                        handleTarefa = Convert.ToInt32(reader["HANDLE"]);
                    }
                    reader.Close();
                    numeroTextBox.Text = handleTarefa.ToString();
                }
                else
                {
                    if (acao == "Liberar")
                    {
                        if (BuscarHandleStatus() == 2)
                        {
                            String query = " UPDATE TR_TAREFA" +
                                                              " SET " +
                                                              " STATUS = 3" +
                                                              ", SOLICITANTE = " + solicitante +
                                                              ", TIPO = " + tipo +
                                                              ", SITUACAO = " + situacao +
                                                              ", SEVERIDADE = " + severidade +
                                                              ", ASSUNTO = '" + assunto + "'" +
                                                              ", SOLICITACAO = '" + solicitacao + "'" +
                                                              ", RESPONSAVEL = " + responsavel +
                                                              "  WHERE HANDLE = " + handleTarefa;
                            connection.Inserir(query);
                        }
                        else
                        {
                            MessageBox.Show("O registro deve estar na situação aguardando modificações para que possa ser liberado.");
                        }
                    }
                    else
                    {
                        if (acao == "Voltar")
                        {
                            if (BuscarHandleStatus() == 3)
                            {
                                String query = " UPDATE TR_TAREFA" +
                                               " SET STATUS = 2" +
                                               " WHERE HANDLE = " + handleTarefa;
                                connection.Inserir(query);
                            }
                            else
                            {
                                MessageBox.Show("O registro deve estar na situação liberado para que possa ser voltado.");
                            }
                        }
                        else
                        {
                            if (acao == "Cancelar")
                            {
                                if (BuscarHandleStatus() == 2)
                                {
                                    String query = " UPDATE TR_TAREFA" +
                                                   " SET STATUS = 4" +
                                                   " WHERE HANDLE = " + handleTarefa;
                                    connection.Inserir(query);
                                }
                                else
                                {
                                    MessageBox.Show("O registro deve estar na situação aguardando modificações para que possa ser cancelado.");
                                }
                            }
                            else
                            {
                                if (acao == "Encerrar")
                                {
                                    if (BuscarHandleStatus() == 3)
                                    {
                                        String query = " UPDATE TR_TAREFA" +
                                                       " SET STATUS = 5" +
                                                       " WHERE HANDLE = " + handleTarefa;
                                        connection.Inserir(query);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O registro deve estar na situação ativo para que possa ser encerrado.");
                                    }
                                }
                            }
                        }
                    }
                }
                ControleDeStatus();
            }
        }
        //Busca o tempo para o prazo
        private String BuscarPrazoSeveridade(String severidade)
        {
            String prazo = "";
            if (severidade == "Crítica")
            {
                prazo = "DATEADD(HOUR, 3, GETDATE ())";
            }
            else
            {
                if (severidade == "Urgente")
                {
                    prazo = "GETDATE () + 1";
                }
                else
                {
                    if (severidade == "Alta")
                    {
                        prazo = "GETDATE () + 3";
                    }
                    else
                    {
                        if (severidade == "Normal")
                        {
                            prazo = "GETDATE () + 7";
                        }
                        else
                        {
                            if (severidade == "Baixa")
                            {
                                prazo = "GETDATE () + 14";
                            }
                        }
                    }
                }
            }
            return prazo;
        }
        //Buscar handles
        private int BuscarHandleSolicitante()
        {
            int handleSolicitante = 0;
            String query = " SELECT A.HANDLE" +
                           " FROM PS_USUARIO A" +
                           " WHERE A.LOGIN = '" + solicitanteComboBox.SelectedItem.ToString() + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                handleSolicitante = Convert.ToInt32(reader["HANDLE"]);
            }
            reader.Close();
            return handleSolicitante;
        }
        private int BuscarHandleResponsavel()
        {
            int handleResponsavel = 0;
            String query = " SELECT A.HANDLE" +
                           " FROM PS_USUARIO A" +
                           " WHERE A.LOGIN = '" + responsavelComboBox.SelectedItem.ToString() + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                handleResponsavel = Convert.ToInt32(reader["HANDLE"]);
            }
            reader.Close();
            return handleResponsavel;
        }
        private int BuscarHandleTipo()
        {
            int handleTipo = 0;
            String query = " SELECT A.HANDLE" +
                           " FROM TR_TAREFATIPO A" +
                           " WHERE A.NOME = '" + tipoComboBox.SelectedItem.ToString() + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                handleTipo = Convert.ToInt32(reader["HANDLE"]);
            }
            reader.Close();
            return handleTipo;
        }

        private int BuscarHandleSeveridade()
        {
            int handleSeveridade = 0;
            String query = " SELECT A.HANDLE" +
                           " FROM TR_TAREFASEVERIDADE A" +
                           " WHERE A.NOME = '" + severidadeComboBox.SelectedItem.ToString() + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                handleSeveridade = Convert.ToInt32(reader["HANDLE"]);
            }
            reader.Close();
            return handleSeveridade;
        }

        private int BuscarHandleSituacao()
        {
            int handleSituacao = 0;
            String query = " SELECT A.HANDLE" +
                           " FROM TR_TAREFASITUACAO A" +
                           " WHERE A.NOME = '" + situacaoComboBox.SelectedItem.ToString() + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                handleSituacao = Convert.ToInt32(reader["HANDLE"]);
            }
            reader.Close();
            return handleSituacao;
        }


        //Preencher combo box
        private void PreencherComboBoxSolicitante()
        {
            //Limpa a combo box
            solicitanteComboBox.Items.Clear();
            String query = " SELECT A.LOGIN" +
                           " FROM PS_USUARIO A" +
                           " WHERE A.STATUS = 3";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                solicitanteComboBox.Items.Add((reader["LOGIN"].ToString()));
            }
            reader.Close();
        }
        private void PreencherComboBoxResponsavel()
        {
            //Limpa a combo box
            responsavelComboBox.Items.Clear();
            String query = " SELECT A.LOGIN" +
                           " FROM PS_USUARIO A" +
                           " WHERE A.STATUS = 3";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                responsavelComboBox.Items.Add((reader["LOGIN"].ToString()));
            }
            reader.Close();
        }
        private void PreencherComboBoxTipo()
        {
            //Limpa a combo box
            tipoComboBox.Items.Clear();
            String query = " SELECT A.NOME" +
                           " FROM TR_TAREFATIPO A";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                tipoComboBox.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();
        }
        private void PreencherComboBoxSeveridade()
        {
            //Limpa a combo box
            severidadeComboBox.Items.Clear();
            String query = " SELECT A.NOME" +
                           " FROM TR_TAREFASEVERIDADE A" +
                           " ORDER BY A.PRIORIDADE ASC";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                severidadeComboBox.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();
        }
        private void PreencherComboBoxSituacao()
        {
            //Limpa a combo box
            situacaoComboBox.Items.Clear();
            String query = " SELECT A.NOME" +
                           " FROM TR_TAREFASITUACAO A";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                situacaoComboBox.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();
        }
        private void PreencherAnexoDataGridView()
        {
            String query = " SELECT A.HANDLE, A.DESCRICAO DESCRIÇÃO, A.NOMEARQUIVO NOME, A.CAMINHO" +
                           " FROM MD_ANEXO A" +
                           " INNER JOIN TR_TAREFA B ON B.HANDLE = A.HANDLEORIGEM" +
                           " WHERE B.HANDLE = " + handleTarefa +
                           " AND A.TABELAORIGEM = 1";
            anexoDataGridView.AutoGenerateColumns = true;
            Binding.DataSource = connection.DataTable(query);
            anexoDataGridView.DataSource = Binding;
            anexoDataGridView.Columns[0].Width = 0;
            anexoDataGridView.Columns[0].Visible = false;
            anexoDataGridView.Columns[1].Width = 200;
            anexoDataGridView.Columns[2].Width = 200;
            anexoDataGridView.Columns[3].Width = 600;
            anexoDataGridView.AllowUserToResizeRows = false;
        }
        private void PreencherDocumentacaoDataGridView()
        {
            String query = " SELECT A.HANDLE, D.IMAGEM SIT, B.DATA,C.NOME TIPO, A.ASSUNTO" +
                           " FROM TR_TAREFADOCUMENTACAO A" +
                           " INNER JOIN TR_TAREFA B ON B.HANDLE = A.TAREFA" +
                           " INNER JOIN TR_TAREFADOCUMENTACAOTIPO C ON C.HANDLE = A.TIPO" +
                           " INNER JOIN MD_STATUS D ON D.HANDLE = A.STATUS" +
                           " WHERE B.HANDLE = " + handleTarefa;
            documentacaoDataGridView.AutoGenerateColumns = true;
            Binding1.DataSource = connection.DataTable(query);
            documentacaoDataGridView.DataSource = Binding1;
            documentacaoDataGridView.Columns[0].Width = 0;
            documentacaoDataGridView.Columns[0].Visible = false;
            documentacaoDataGridView.Columns[1].Width = 50;
            documentacaoDataGridView.Columns[2].Width = 130;
            documentacaoDataGridView.Columns[3].Width = 200;
            documentacaoDataGridView.Columns[4].Width = 700;
            documentacaoDataGridView.AllowUserToResizeRows = false;
        }

        private void LiberarButtonOnClick(object sender, EventArgs e)
        {
            AlterarRegistro("Liberar");
        }

        private void VoltarButtonOnClick(object sender, EventArgs e)
        {
            AlterarRegistro("Voltar");
        }

        private void SolicitanteDropDown(object sender, EventArgs e)
        {
            PreencherComboBoxSolicitante();
        }

        private void CancelarButtonOnClick(object sender, EventArgs e)
        {
            DialogResult confirmacaoButton = MessageBox.Show("Deseja Continuar?", "Cancelar tarefa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmacaoButton.ToString().ToUpper() == "YES")
            {
                AlterarRegistro("Cancelar");
            }
        }

        private void AdicionarButtonOnClick(object sender, EventArgs e)
        {
            IAnexoPadrao.handleOrigem = handleTarefa;
            IAnexoPadrao.handleTabelaOrigem = 1;
            IAnexoPadrao iAnexoPadrao = new IAnexoPadrao();
            iAnexoPadrao.ShowDialog();
        }

        private void TarefaFormActivated(object sender, EventArgs e)
        {
            PreencherAnexoDataGridView();
            PreencherDocumentacaoDataGridView();
        }

        private int BuscarHandleAnexo()
        {
            int handleAnexo = 0;

            try
            {
                handleAnexo = Convert.ToInt32(anexoDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {

            }
            return handleAnexo;
        }
        private void AnexoDataGridViewDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IAnexoPadrao.handleAnexo = BuscarHandleAnexo();
            IAnexoPadrao iAnexoPadrao = new IAnexoPadrao();
            iAnexoPadrao.ShowDialog();
        }

        private void EncerrarButtonOnClick(object sender, EventArgs e)
        {
            DialogResult confirmacaoButton = MessageBox.Show("Deseja Continuar?", "Encerrar tarefa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmacaoButton.ToString().ToUpper() == "YES")
            {
                AlterarRegistro("Encerrar");
            }
        }

        private void AdcionarDocumentacaoButtonOnClick(object sender, EventArgs e)
        {
            ITarefaDocumentacao.handleTarefa = BuscarHandleTarefa();
            ITarefaDocumentacao iTarefaDocumentacao = new ITarefaDocumentacao();
            iTarefaDocumentacao.ShowDialog();
        }

        private void ResponsavelDropDown(object sender, EventArgs e)
        {
            PreencherComboBoxResponsavel();
        }

        private void DocumentacaoCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ITarefaDocumentacao.handleTarefa = BuscarHandleTarefa();
            ITarefaDocumentacao.handleDocumentacao = BuscarHandleDocumentacao();
            ITarefaDocumentacao iTarefaDocumentacao = new ITarefaDocumentacao();
            iTarefaDocumentacao.ShowDialog();
        }

        private void SeveridadeDropDown(object sender, EventArgs e)
        {
            PreencherComboBoxSeveridade();
        }

        private void AdicionarEncaminhamentoButtonOnClick(object sender, EventArgs e)
        {
            ITarefaEncaminhamento iTarefaDocumentacao = new ITarefaEncaminhamento();
            iTarefaDocumentacao.ShowDialog();
        }

        private void TipoDropDown(object sender, EventArgs e)
        {
            PreencherComboBoxTipo();
        }

        private void SituacaoDropDown(object sender, EventArgs e)
        {
            PreencherComboBoxSituacao();
        }


        //Validar campos obrigatorios
        private Boolean ValidarCamposObrigatorios()
        {
            try
            {
                if (solicitanteComboBox.SelectedItem != null)
                {
                    if (tipoComboBox.SelectedItem != null)
                    {
                        if (situacaoComboBox.SelectedItem != null)
                        {
                            if (severidadeComboBox.SelectedItem != null)
                            {
                                if (responsavelComboBox.SelectedItem != null)
                                {
                                    if (assuntoTextBox.Text != "")
                                    {
                                        if (solicitacaoTextBox.Text != "")
                                        {
                                            return true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("O campo solicitação é obrigatório");
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("O campo assunto é obrigatório");
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("O campo responsável é obrigatório");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("O campo severidade é obrigatório");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("O campo situação é obrigatório");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("O campo tipo é obrigatório");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("O campo solicitante é obrigatório");
                    return false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                return false;
            }
        }
        //Buscar status
        private int BuscarHandleStatus()
        {
            int handleStatus = 0;
            String query = " SELECT A.STATUS" +
                           " FROM TR_TAREFA A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                           " WHERE A.HANDLE = " + handleTarefa;
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                handleStatus = Convert.ToInt32(reader["STATUS"]);
            }
            reader.Close();
            return handleStatus;
        }
        private int BuscarHandleTarefa()
        {
            int handleTarefa = 0;
            try
            {
                handleTarefa = Convert.ToInt32(numeroTextBox.Text);
            }
            catch
            {

            }
            return handleTarefa;
        }
        private int BuscarHandleDocumentacao()
        {
            int handleDocumentacao = 0;
            try
            {
                handleDocumentacao = Convert.ToInt32(documentacaoDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            return handleDocumentacao;
        }
        //Controle de status
        private void ControleDeStatus()
        {
            String status = "";
            String query = " SELECT B.NOME, A.DATA, A.PRAZO" +
                           " FROM TR_TAREFA A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                           " WHERE A.HANDLE = " + handleTarefa;
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                status = reader["NOME"].ToString();
                dataTextBox.Text = reader["DATA"].ToString();
                prazoTextBox.Text = reader["PRAZO"].ToString();

            }
            reader.Close();
            if (status == "Cadastrado")
            {
                solicitanteComboBox.Enabled = true;
                severidadeComboBox.Enabled = true;
                situacaoComboBox.Enabled = true;
                responsavelComboBox.Enabled = true;
                tipoComboBox.Enabled = true;
                assuntoTextBox.ReadOnly = true;
                solicitacaoTextBox.ReadOnly = true;
                //dataDateTimePicker.Enabled = true;

                gravarButton.Visible = false;
                cancelarButton.Visible = true;
                voltarButton.Visible = false;
                liberarButton.Visible = true;
                encerrarButton.Visible = false;
                adicionarArquivoButton.Visible = true;
                adicionarDocumentacaoButton.Enabled = true;
                liberarButton.Location = new Point(765, 331);
                cancelarButton.Location = new Point(869, 331);
            }
            else
            {
                if (status == "Ag. modificações")
                {
                    //Controle de status
                    solicitanteComboBox.Enabled = true;
                    severidadeComboBox.Enabled = true;
                    situacaoComboBox.Enabled = true;
                    responsavelComboBox.Enabled = true;
                    tipoComboBox.Enabled = true;
                    assuntoTextBox.ReadOnly = false;
                    solicitacaoTextBox.ReadOnly = false;
                    //  dataDateTimePicker.Enabled = true;
                    //Controle de botões (Criar classe para isso)
                    liberarButton.Visible = true;
                    cancelarButton.Visible = true;
                    voltarButton.Visible = false;
                    gravarButton.Visible = false;
                    encerrarButton.Visible = false;
                    adicionarArquivoButton.Enabled = true;
                    adicionarDocumentacaoButton.Enabled = true;
                    liberarButton.Location = new Point(765, 331);
                    cancelarButton.Location = new Point(869, 331);
                }
                else
                {
                    if (status == "Ativo")
                    {
                        solicitanteComboBox.Enabled = false;
                        severidadeComboBox.Enabled = false;
                        situacaoComboBox.Enabled = false;
                        responsavelComboBox.Enabled = false;
                        tipoComboBox.Enabled = false;
                        assuntoTextBox.ReadOnly = true;
                        solicitacaoTextBox.ReadOnly = true;
                        //   dataDateTimePicker.Enabled = false;
                        //Controle de botões (Criar classe para isso)
                        gravarButton.Visible = false;
                        cancelarButton.Visible = false;
                        voltarButton.Visible = true;
                        liberarButton.Visible = false;
                        encerrarButton.Visible = true;
                        adicionarArquivoButton.Enabled = true;
                        adicionarDocumentacaoButton.Enabled = true;
                        encerrarButton.Location = new Point(765, 331);
                        voltarButton.Location = new Point(869, 331);
                    }
                    else
                    {
                        if (status == "Cancelado")
                        {
                            solicitanteComboBox.Enabled = false;
                            severidadeComboBox.Enabled = false;
                            situacaoComboBox.Enabled = false;
                            responsavelComboBox.Enabled = false;
                            tipoComboBox.Enabled = false;
                            assuntoTextBox.ReadOnly = true;
                            solicitacaoTextBox.ReadOnly = true;
                            //     dataDateTimePicker.Enabled = false;
                            //Botões
                            gravarButton.Visible = false;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = false;
                            liberarButton.Visible = false;
                            adicionarArquivoButton.Enabled = false;
                            adicionarDocumentacaoButton.Enabled = false;
                            voltarButton.Location = new Point(869, 331);
                        }
                        else
                        {
                            if (status == "Encerrado")
                            {
                                solicitanteComboBox.Enabled = false;
                                severidadeComboBox.Enabled = false;
                                situacaoComboBox.Enabled = false;
                                responsavelComboBox.Enabled = false;
                                tipoComboBox.Enabled = false;
                                assuntoTextBox.ReadOnly = true;
                                solicitacaoTextBox.ReadOnly = true;
                                //      dataDateTimePicker.Enabled = false;
                                //Botões
                                gravarButton.Visible = false;
                                cancelarButton.Visible = false;
                                voltarButton.Visible = false;
                                liberarButton.Visible = false;
                                encerrarButton.Visible = false;
                                adicionarArquivoButton.Enabled = false;
                                adicionarDocumentacaoButton.Enabled = false;
                                voltarButton.Location = new Point(869, 331);
                            }
                            else
                            {
                                gravarButton.Visible = true;
                                cancelarButton.Visible = false;
                                voltarButton.Visible = false;
                                liberarButton.Visible = false;
                                encerrarButton.Visible = false;
                                adicionarArquivoButton.Enabled = false;
                                //
                                adicionarDocumentacaoButton.Enabled = false;
                                gravarButton.Location = new Point(869, 331);
                            }
                        }
                    }
                }

            }
            this.Text = "Tarefa - " + status;
        }
    }
}
