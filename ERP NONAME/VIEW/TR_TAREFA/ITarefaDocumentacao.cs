using ALTO_VALE.DAL;
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
    public partial class ITarefaDocumentacao : Form
    {
        public static int handleTarefa = 0, handleDocumentacao = 0;
        Connection connection = new Connection();

        //Variaveis
        String observacao = "";
        int tipo = 0;

        public ITarefaDocumentacao()
        {
            InitializeComponent();
            connection.Conectar();
            PreencherTipo();
            tarefaTextBox.ReadOnly = true;
            if (handleDocumentacao != 0)
            {
                PreencherFormulario();
            }
            else
            {
                ControleDeStatus();
            }
        }
        //Preencher formulario
        private void PreencherFormulario()
        {
            PreencherTipo();
            String query = " SELECT B.NOME TIPO, A.OBSERVACAO, A.TAREFA" +
                           " FROM TR_TAREFADOCUMENTACAO A" +
                           " INNER JOIN TR_TAREFADOCUMENTACAOTIPO B ON B.HANDLE = A.TIPO" +
                           " WHERE A.HANDLE = " + handleDocumentacao;
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                tipoComboBox.SelectedItem = reader["TIPO"];
                ObservacaoTextBox.Text = reader["OBSERVACAO"].ToString();
                tarefaTextBox.Text = reader["TAREFA"].ToString();
            }
            reader.Close();

            ControleDeStatus();
        }
        //Alterar Registro
        private void AlterarRegistro(String acao)
        {
            tipo = BuscarHandleTipo();
            observacao = ObservacaoTextBox.Text;

            //campos obrigatorios

            //if(VerificarCamposObrigatorios == true){

            if (acao == "Gravar")
            {
                String query = " INSERT INTO TR_TAREFADOCUMENTACAO" +
                               " (STATUS, TAREFA, TIPO, OBSERVACAO)" +
                               " VALUES" +
                               " (2" +
                               ", " + handleTarefa +
                               ", " + tipo +
                               ", '" + observacao + "')";
                connection.Inserir(query);

                //Buscar novo handle
                String query1 = " SELECT MAX(HANDLE) HANDLE" +
                                " FROM TR_TAREFADOCUMENTACAO" +
                                " WHERE STATUS = 2" +
                                " AND TAREFA = " + handleTarefa +
                                " AND TIPO = " + tipo +
                                " AND OBSERVACAO = '" + observacao + "'";
                SqlDataReader reader = connection.Pesquisa(query1);
                while (reader.Read())
                {
                    handleDocumentacao = Convert.ToInt32(reader["HANDLE"]);
                }
                reader.Close();
            }
            else
            {
                if (acao == "Liberar")
                {
                    String query = " UPDATE TR_TAREFADOCUMENTACAO" +
                                   " SET STATUS = 3" +
                                   " WHERE HANDLE = " + handleDocumentacao;
                    connection.Inserir(query);
                }
                else
                {
                    if (acao == "Cancelar")
                    {
                        String query = " UPDATE TR_TAREFADOCUMENTACAO" +
                                       " SET STATUS = 4" +
                                       " WHERE HANDLE = " + handleDocumentacao;
                        connection.Inserir(query);
                    }
                    else
                    {
                        if (acao == "Excluir")
                        {
                            String query = " DELETE TR_TAREFADOCUMENTACAO" +
                                           " WHERE HANDLE = " + handleDocumentacao;
                            connection.Inserir(query);
                            this.Close();
                        }
                        else
                        {
                            if (acao == "Voltar")
                            {
                                String query = " UPDATE TR_TAREFADOCUMENTACAO" +
                                       " SET STATUS = 2" +
                                       " WHERE HANDLE = " + handleDocumentacao;
                                connection.Inserir(query);
                            }
                        }
                    }
                }
            }


            // }

            ControleDeStatus();
        }

        private void GravarButtonOnClick(object sender, EventArgs e)
        {
            AlterarRegistro("Gravar");
        }

        private void LiberarButtonOnClick(object sender, EventArgs e)
        {
            AlterarRegistro("Liberar");
        }

        private void CancelarButtonOnClick(object sender, EventArgs e)
        {
            DialogResult confirmacaoButton = MessageBox.Show("Deseja Continuar?", "Cancelar tarefa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmacaoButton.ToString().ToUpper() == "YES")
            {
                AlterarRegistro("Cancelar");
            }
        }

        private void VoltarButtonOnClick(object sender, EventArgs e)
        {
            AlterarRegistro("Voltar");
        }

        //Buscar handle
        private int BuscarHandleTipo()
        {
            int handleTipo = 0;

            String query = "SELECT HANDLE FROM TR_TAREFADOCUMENTACAOTIPO WHERE NOME = '" + tipoComboBox.SelectedItem.ToString() + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                handleTipo = Convert.ToInt32(reader["HANDLE"]);
            }
            reader.Close();

            return handleTipo;
        }

        private void DocumentacaoFormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Desconectar();
            handleTarefa = 0;
            handleDocumentacao = 0;
        }

        //Preencher campos
        private void PreencherTipo()
        {
            //Limpa a combo box
            tipoComboBox.Items.Clear();

            //Lista os tipos
            String query = "SELECT NOME FROM TR_TAREFADOCUMENTACAOTIPO";
            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                tipoComboBox.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();
        }

        private void ExcluirButtonOnClick(object sender, EventArgs e)
        {
            DialogResult confirmacaoButton = MessageBox.Show("Deseja Continuar?", "Cancelar tarefa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmacaoButton.ToString().ToUpper() == "YES")
            {
                AlterarRegistro("Excluir");
            }

        }


        //Controle de status
        public void ControleDeStatus()
        {
            String status = "";
            String query = " SELECT B.NOME" +
                           " FROM TR_TAREFADOCUMENTACAO A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                           " WHERE A.HANDLE = " + handleDocumentacao;
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                status = reader["NOME"].ToString();
            }
            reader.Close();
            if (status == "Cadastrado")
            {
                gravarButton.Visible = false;
                cancelarButton.Visible = true;
                voltarButton.Visible = false;
                liberarButton.Visible = true;
                liberarButton.Location = new Point(564, 269);
                cancelarButton.Location = new Point(668, 269);
            }
            else
            {
                if (status == "Ag. modificações")
                {
                    //Controle de status
                    tipoComboBox.Enabled = true;
                    ObservacaoTextBox.ReadOnly = false;
                    //Controle de botões (Criar classe para isso)
                    liberarButton.Visible = true;
                    cancelarButton.Visible = true;
                    voltarButton.Visible = false;
                    gravarButton.Visible = false;
                    excluirButton.Visible = false;
                    liberarButton.Location = new Point(564, 269);
                    cancelarButton.Location = new Point(668, 269);
                }
                else
                {
                    if (status == "Ativo")
                    {
                        //Caso esteja ativo, não permite alterar antes de voltar o registro
                        tipoComboBox.Enabled = false;
                        ObservacaoTextBox.ReadOnly = false;
                        //Controle de botões (Criar classe para isso)
                        gravarButton.Visible = false;
                        cancelarButton.Visible = false;
                        voltarButton.Visible = true;
                        excluirButton.Visible = false;
                        liberarButton.Visible = false;
                        voltarButton.Location = new Point(668, 269);
                    }
                    else
                    {
                        if (status == "Cancelado")
                        {
                            //Caso esteja ativo, não permite alterar antes de voltar o registro
                            tipoComboBox.Enabled = false;
                            ObservacaoTextBox.ReadOnly = true;
                            //Controle de botões (Criar classe para isso)
                            gravarButton.Visible = false;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = true;
                            liberarButton.Visible = false;
                            excluirButton.Visible = true;
                            excluirButton.Location = new Point(564, 269);
                            voltarButton.Location = new Point(668, 269);
                        }
                        else
                        {
                            gravarButton.Visible = true;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = false;
                            excluirButton.Visible = false;
                            liberarButton.Visible = false;
                            gravarButton.Location = new Point(668, 269);
                        }
                    }
                }
            }
            this.Text = "Documentação - " + status;
        }











    }
}
