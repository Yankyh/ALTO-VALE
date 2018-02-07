using ALTO_VALE.DAL;
using ALTO_VALE.TN_TECNOLOGIA;
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

namespace ALTO_VALE.VIEW.TR_TAREFA
{
    public partial class ITarefaEncaminhamento : Form
    {
        public static int handleTarefa = 0, handleEncaminhamento = 0;

        Connection connection = new Connection();
        public ITarefaEncaminhamento()
        {
            InitializeComponent();
            connection.Conectar();
            if (handleEncaminhamento != 0)
            {
                PreencherFormulario(handleEncaminhamento);
            }
            PreencherComboBoxTipoEncaminhamento();
            PreencherComboBoxResponsavel();
            PreencherComboBoxSeveridade();
            PreencherComboBoxSituacao();
            PreencherComboBoxTipo();
        }

        private void PreencherFormulario(int handleEncaminhamento)
        {

        }


        //Metódos que preenchem os combo box's
        private void PreencherComboBoxTipoEncaminhamento()
        {
            //Limpa a combo box
            tipoEncaminhamentoComboBox.Items.Clear();
            String query = " SELECT A.NOME" +
                           " FROM TR_TAREFAENCAMINHAMENTOTIPO A" +
                           " WHERE A.STATUS = 3";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                tipoEncaminhamentoComboBox.Items.Add((reader["NOME"].ToString()));
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

        private void ResponsavelOnKeyPress(object sender, KeyEventArgs e)
        {

        }

        private void TipoEncaminhamentoIndexChanged(object sender, EventArgs e)
        {
            try
            {
                responsavelComboBox.SelectedIndex = -1;
                situacaoComboBox.SelectedIndex = -1;
                tipoComboBox.SelectedIndex = -1;
                severidadeComboBox.SelectedIndex = -1;
                if (tipoEncaminhamentoComboBox.SelectedItem.ToString() == "Alterar severidade")
                {
                    responsavelComboBox.Enabled = false;
                    situacaoComboBox.Enabled = false;
                    tipoComboBox.Enabled = false;
                    severidadeComboBox.Enabled = true;
                }
                else
                {
                    if (tipoEncaminhamentoComboBox.SelectedItem.ToString() == "Alterar responsável")
                    {
                        responsavelComboBox.Enabled = true;
                        situacaoComboBox.Enabled = false;
                        tipoComboBox.Enabled = false;
                        severidadeComboBox.Enabled = false;
                    }
                    else
                    {
                        if (tipoEncaminhamentoComboBox.SelectedItem.ToString() == "Alterar situação")
                        {
                            responsavelComboBox.Enabled = false;
                            situacaoComboBox.Enabled = true;
                            tipoComboBox.Enabled = false;
                            severidadeComboBox.Enabled = false;
                        }
                        else
                        {
                            if (tipoEncaminhamentoComboBox.SelectedItem.ToString() == "Alterar tipo")
                            {
                                responsavelComboBox.Enabled = false;
                                situacaoComboBox.Enabled = false;
                                tipoComboBox.Enabled = true;
                                severidadeComboBox.Enabled = false;
                            }
                        }
                    }
                }

            }
            catch
            {

            }

        }
        private void AlterarRegistro(String acao)
        {
            if (VerificaCamposObrigatorios() == true)
            {
                int tipoEncaminhamento = BuscarHandleTipoEncaminhamento();
                String responsavel = BuscarHandleResponsavel();
                String situacao = BuscarHandleSituacao();
                String tipo = BuscarHandleTipo();
                String severidade = BuscarHandleSeveridade();
                String assunto = assuntoTextBox.Text;
                String descricao = descricaoTextBox.Text;

                if (acao == "Gravar")
                {
                    String query = " INSERT INTO TR_TAREFAENCAMINHAMENTO" +
                                   " (STATUS, TIPOENCAMINHAMENTO, RESPONSAVEL, SITUACAO, TIPO, SEVERIDADE, ASSUNTO, DATA, DESCRICAO, TAREFA) " +
                                   " VALUES" +
                                   " (1," +
                                   " " + tipoEncaminhamento + "," +
                                   " " + responsavel + "," +
                                   " " + situacao + "," +
                                   " " + tipo + "," +
                                   " " + severidade + "," +
                                   " '" + assunto + "'," +
                                   " GETDATE()," +
                                   " '" + descricao + "'," +
                                   " " + handleTarefa + ")";
                    connection.Inserir(query);

                    String query1 = " SELECT MAX(HANDLE) HANDLE" +
                                    " FROM TR_TAREFAENCAMINHAMENTO" +
                                    " WHERE STATUS = 1" +
                                    " AND TIPOENCAMINHAMENTO =" + tipoEncaminhamento + "" +
                                    " AND TAREFA =" + handleTarefa;
                    SqlDataReader reader = connection.Pesquisa(query1);
                    while (reader.Read())
                    {
                        handleEncaminhamento = Convert.ToInt32(reader["HANDLE"]);
                    }
                    reader.Close();
                }
                else
                {
                    if (acao == "Liberar")
                    {

                    }
                }
            }
            ControleDeStatus();
        }
        private int BuscarHandleTipoEncaminhamento()
        {
            int handleTipoEncaminhamento = 0;
            String query = " SELECT A.HANDLE" +
                           " FROM TR_TAREFAENCAMINHAMENTOTIPO A" +
                           " WHERE A.NOME = '" + tipoEncaminhamentoComboBox.SelectedItem.ToString() + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                handleTipoEncaminhamento = Convert.ToInt32(reader["HANDLE"]);
            }
            reader.Close();
            return handleTipoEncaminhamento;
        }
        private String BuscarHandleResponsavel()
        {
            String handleResponsavel = "";
            if (responsavelComboBox.SelectedIndex != -1)
            {
                String query = " SELECT A.HANDLE" +
                               " FROM PS_USUARIO A" +
                               " WHERE A.LOGIN = '" + responsavelComboBox.SelectedItem.ToString() + "'";
                SqlDataReader reader = connection.Pesquisa(query);
                while (reader.Read())
                {
                    handleResponsavel = (reader["HANDLE"]).ToString();
                }
                reader.Close();
                return handleResponsavel;
            }
            else
            {
                return "null";
            }

        }
        private String BuscarHandleTipo()
        {
            String handleTipo = "";
            if (tipoComboBox.SelectedIndex != -1)
            {
                String query = " SELECT A.HANDLE" +
                               " FROM TR_TAREFATIPO A" +
                               " WHERE A.NOME = '" + tipoComboBox.SelectedItem.ToString() + "'";
                SqlDataReader reader = connection.Pesquisa(query);
                while (reader.Read())
                {
                    handleTipo = reader["HANDLE"].ToString();
                }
                reader.Close();
                return handleTipo;
            }
            else
            {
                return "null";
            }

        }

        private String BuscarHandleSeveridade()
        {
            String handleSeveridade = "";
            if (severidadeComboBox.SelectedIndex != -1)
            {
                String query = " SELECT A.HANDLE" +
                           " FROM TR_TAREFASEVERIDADE A" +
                           " WHERE A.NOME = '" + severidadeComboBox.SelectedItem.ToString() + "'";
                SqlDataReader reader = connection.Pesquisa(query);
                while (reader.Read())
                {
                    handleSeveridade = (reader["HANDLE"]).ToString();
                }
                reader.Close();
                return handleSeveridade;
            }
            else
            {
                return "null";
            }

        }
        private String BuscarHandleSituacao()
        {
            String handleSituacao = "";
            if (situacaoComboBox.SelectedIndex != -1)
            {
                String query = " SELECT A.HANDLE" +
                           " FROM TR_TAREFASITUACAO A" +
                           " WHERE A.NOME = '" + situacaoComboBox.SelectedItem.ToString() + "'";
                SqlDataReader reader = connection.Pesquisa(query);
                while (reader.Read())
                {
                    handleSituacao = (reader["HANDLE"]).ToString();
                }
                reader.Close();
                return handleSituacao;
            }
            else
            {
                return "null";
            }

        }
        private void GravarButtonOnClick(object sender, EventArgs e)
        {
            AlterarRegistro("Gravar");
        }

        private void LiberarButtonOnClick(object sender, EventArgs e)
        {
            AlterarRegistro("Liberar");
        }
        private Boolean VerificaCamposObrigatorios()
        {
            return true;
        }
        private void ControleDeStatus()
        {
            String situacao = "";
            String query = " SELECT B.NOME SITUACAO, A.DATA" +
                           " FROM TR_TAREFAENCAMINHAMENTO A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                           " WHERE A.HANDLE = " + handleEncaminhamento;
            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                situacao = reader["SITUACAO"].ToString();
                dataTextBox.Text = reader["DATA"].ToString();
            }
            reader.Close();

            if (situacao == "Cadastrado")
            {
                tipoEncaminhamentoComboBox.Enabled = true;
                tipoComboBox.Enabled = true;
                responsavelComboBox.Enabled = true;
                situacaoComboBox.Enabled = true;
                severidadeComboBox.Enabled = true;
                descricaoTextBox.ReadOnly = true;
                assuntoTextBox.ReadOnly = true;

                liberarButton.Visible = true;
                gravarButton.Visible = false;
                liberarButton.Location = new Point(681, 320);
            }
            else
            {
                if (situacao == "Ativo")
                {
                    tipoEncaminhamentoComboBox.Enabled = false;
                    tipoComboBox.Enabled = false;
                    responsavelComboBox.Enabled = false;
                    situacaoComboBox.Enabled = false;
                    severidadeComboBox.Enabled = false;
                    descricaoTextBox.ReadOnly = false;
                    assuntoTextBox.ReadOnly = false;

                    liberarButton.Visible = false;
                    gravarButton.Visible = false;
                }
                else
                {
                    tipoEncaminhamentoComboBox.Enabled = true;
                    tipoComboBox.Enabled = true;
                    responsavelComboBox.Enabled = true;
                    situacaoComboBox.Enabled = true;
                    severidadeComboBox.Enabled = true;
                    descricaoTextBox.ReadOnly = true;
                    assuntoTextBox.ReadOnly = true;

                    liberarButton.Visible = false;
                    gravarButton.Visible = true;
                }
            }
            this.Text = "Encaminhamento - " + situacao;

        }
        //
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            handleTarefa = 0;
            connection.Desconectar();
        }
    }
}
