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
            //   if (ValidarCamposObrigatorios() == true)
            // {
            String data = "", prazo = "", assunto = "", solicitacao = "";
            int solicitante = 0, tipo = 0, situacao = 0, severidade = 0, responsavel = 0;
            solicitante = BuscarHandleSolicitante();
            tipo = BuscarHandleTipo();
            situacao = BuscarHandleSituacao();
            severidade = BuscarHandleSeveridade();
            data = dataTimePicker.Value.ToString();
            prazo = prazoTimePicker.Value.ToString();
            assunto = assuntoTextBox.Text;
            solicitacao = solicitacaoTextBox.Text;
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
                              " '" + data + "'," +
                              " '" + prazo + "'," +
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
                               " AND DATA = '" + data + "'" +
                               " AND PRAZO = '" + prazo + "'" +
                               " AND ASSUNTO = '" + assunto + "'" +
                               " AND SOLICITACAO = '" + solicitacao + "'" +
                               " AND RESPONSAVEL = " + responsavel;
                SqlDataReader reader = connection.Pesquisa(query1);
                Console.WriteLine(query1);
                while (reader.Read())
                {
                    handleTarefa = Convert.ToInt32(reader["HANDLE"]);
                }
                reader.Close();
            }

            ControleDeStatus();
            // }
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
                                    if (dataTimePicker.Value.ToString() != "")
                                    {
                                        if (prazoTimePicker.Value.ToString() != "")
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
                                            MessageBox.Show("O campo prazo é obrigatório");
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("O campo data é obrigatório");
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
                return false;
                MessageBox.Show(exception.ToString());
            }
        }

        //Controle de status
        private void ControleDeStatus()
        {
            String status = "";
            String query = " SELECT B.NOME" +
                           " FROM TR_TAREFA A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                           " WHERE A.HANDLE = " + handleTarefa;
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                status = reader["NOME"].ToString();
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
                dataTimePicker.Enabled = true;
                prazoTimePicker.Enabled = true;

                gravarButton.Visible = false;
                cancelarButton.Visible = true;
                voltarButton.Visible = false;
                liberarButton.Visible = true;
                liberarButton.Location = new Point(770, 286);
                cancelarButton.Location = new Point(874, 286);
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
                    dataTimePicker.Enabled = true;
                    prazoTimePicker.Enabled = true;
                    //Controle de botões (Criar classe para isso)
                    liberarButton.Visible = true;
                    cancelarButton.Visible = true;
                    voltarButton.Visible = false;
                    gravarButton.Visible = false;
                    liberarButton.Location = new Point(768, 375);
                    cancelarButton.Location = new Point(872, 375);
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
                        dataTimePicker.Enabled = false;
                        prazoTimePicker.Enabled = false;
                        //Controle de botões (Criar classe para isso)
                        gravarButton.Visible = false;
                        cancelarButton.Visible = false;
                        voltarButton.Visible = true;
                        liberarButton.Visible = false;
                        voltarButton.Location = new Point(872, 375);
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
                            dataTimePicker.Enabled = false;
                            prazoTimePicker.Enabled = false;
                            //Botões
                            gravarButton.Visible = false;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = true;
                            liberarButton.Visible = false;
                            voltarButton.Location = new Point(872, 375);
                        }
                        else
                        {
                            gravarButton.Visible = true;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = false;
                            liberarButton.Visible = false;
                            gravarButton.Location = new Point(872, 375);
                        }
                    }
                }

            }
            this.Text = "Tarefa - " + status;
        }
    }
}
