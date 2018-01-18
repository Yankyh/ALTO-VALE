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

namespace ALTO_VALE.VIEW.TR_TAREFA
{
    public partial class ITarefa : Form
    {

        //Conexão com o banco
        Connection connection = new Connection();
        public ITarefa()
        {
            InitializeComponent();
            //abre a conexão
            connection.Conectar();
        }

        private void tarefaFormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Desconectar();
        }

        private void gravarButtonOnClick(object sender, EventArgs e)
        {
            AlterarRegistro("Gravar");
        }

        //Metodo de alteração
        private void AlterarRegistro(String acao)
        {
            String tipo = "", situacao = "", severidade = "", numero = "", data = "", prazo = "", assunto = "", solicitacao = "", responsavel = "";
            int solicitante = 0;
            solicitante = BuscarHandleSolicitante();
            tipo = tipoComboBox.SelectedText;
            situacao = situacaoComboBox.SelectedText;
            severidade = severidadeComboBox.SelectedText;
            numero = numeroTextBox.Text;
            data = dataTimePicker.Value.ToString();
            prazo = prazoTimePicker.Value.ToString();
            assunto = assuntoTextBox.Text;
            solicitacao = solicitacaoTextBox.Text;
            responsavel = responsavelComboBox.Text;


            if (acao == "Gravar")
            {
                String query = " INSERT INTO TR_TAREFA" +
                              " (STATUS, SOLICITANTE, TIPO, SITUACAO, SEVERIDADE, NUMERO, DATA, PRAZO, ASSUNTO, SOLICITACAO, RESPONSAVEL)" +
                              " VALUES" +
                              " (" +
                              " 2," +
                              " " + solicitante + "," +
                              " " + tipo + "," +
                              " " + situacao + "," +
                              " " + severidade + "," +
                              " " + numero + "," +
                              " '" + data + "'," +
                              " '" + prazo + "'," +
                              " '" + assunto + "'," +
                              " '" + solicitacao + "'," +
                              " " + responsavel + "" +
                              ")";

            }
        }

        //Buscar handles
        private int BuscarHandleSolicitante()
        {
            int handleSolicitante = 0;
            String query = " SELECT A.HANDLE" +
                           " FROM PS_USUARIO A" +
                           " WHERE A.LOGIN = '" + solicitanteComboBox.SelectedText + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                handleSolicitante = Convert.ToInt32(reader["HANDLE"]);
            }
            reader.Close();
            MessageBox.Show(handleSolicitante.ToString());
            return handleSolicitante;
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

        private void SolicitanteDropDown(object sender, EventArgs e)
        {
            PreencherComboBoxSolicitante();
        }

        private void ResponsavelDropDown(object sender, EventArgs e)
        {
            PreencherComboBoxResponsavel();
        }

        private void SeveridadeDropDown(object sender, EventArgs e)
        {
            PreencherComboBoxSeveridade();
        }

        private void TipoDropDown(object sender, EventArgs e)
        {
            PreencherComboBoxTipo();
        }

        private void SituacaoDropDown(object sender, EventArgs e)
        {
            PreencherComboBoxSituacao();
        }
    }
}
