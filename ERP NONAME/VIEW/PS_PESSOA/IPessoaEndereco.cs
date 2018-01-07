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

namespace ALTO_VALE.VIEW.PS_PESSOA
{
    public partial class IPessoaEndereco : Form
    {
        //Conexão
        Connection connection = new Connection();
        public static int handlePessoa = 0, handleEndereco = 0;
        public IPessoaEndereco()
        {
            InitializeComponent();
            //Conectar
            connection.Conectar();
        }

        private void gravarButtonOnClick(object sender, EventArgs e)
        {
            if (verificarCamposObrigatorios() == true)
            {
                gravarRegistroEndereco("Gravar");
            }
        }

        public void gravarRegistroEndereco(String acao)
        {
            String cep = "", cidade = "", bairro = "", logradouro = "", numero = "", referencia = "";
            int estado = 0;
            cep = cepComboBox.SelectedItem.ToString();
            cidade = cidadeTextBox.Text;
            bairro = bairroTextBox.Text;
            logradouro = logradouroTextBox.Text;
            numero = numeroTextBox.Text;
            referencia = referenciaTextBox.Text;
            estado = estadoHandle();

            if (acao == "Gravar")
            {
                String query = "INSERT INTO PS_PESSOAENDERECO (STATUS, CEP, CIDADE, BAIRRO, LOGRADOURO, NUMERO, REFERENCIA, ESTADO) VALUES " +
                              " (1, " +
                              " '" + cep + "', " +
                              " '" + cidade + "', " +
                              " '" + bairro + "', " +
                              " '" + logradouro + "', " +
                              " '" + numero + "', " +
                              " '" + referencia + "', " +
                              " " + estado + ")";
                connection.Inserir(query);

                //Busca o registro para adicionar na fk
                String query2 = " SELECT MAX(A.HANDLE) AS HANDLE" +
                                " FROM PS_PESSOAENDERECO A" +
                                " WHERE CEP = '" + cep + "'" +
                                " AND CIDADE = '" + cidade + "'" +
                                " AND BAIRRO = '" + bairro + "' " +
                                " AND LOGRADOURO = '" + logradouro + "'" +
                                " AND NUMERO = '" + numero + "'" +
                                " AND REFERENCIA = '" + referencia + "'" +
                                " AND ESTADO = " + estado;
                SqlDataReader reader = connection.Pesquisa(query2);
                while (reader.Read())
                {
                    handleEndereco = Convert.ToInt32(reader["HANDLE"]);
                }
                reader.Close();
                String query3 = " INSERT INTO PS_PESSOAENDERECOFK" +
                                " (PESSOA, ENDERECO)" +
                                " VALUES" +
                                " (" + handlePessoa + ", " + handleEndereco + ")";

                connection.Inserir(query3);
            }

            //Controle de status
            controleDeStatus();
        }



        //Tipo Pessoa
        private void estadoDropDown(object sender, EventArgs e)
        {
            preencherEstado();
        }
        //preencher estado
        private void preencherEstado()
        {
            //Limpa a combo box
            estadoComboBox.Items.Clear();

            //Lista os tipos
            String query = "SELECT NOME FROM PS_ESTADO";
            query = StatusFilter.StatusNotIn(query);

            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                estadoComboBox.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();
        }



        //Metodos de busca de handle
        private int estadoHandle()
        {
            int estadoHandle = 0;
            String estadoSelecionado = "";
            estadoSelecionado = estadoComboBox.SelectedItem.ToString();

            String query = "SELECT HANDLE FROM PS_ESTADO WHERE NOME = '" + estadoSelecionado + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                estadoHandle = Convert.ToInt32((reader["HANDLE"]));
            }
            reader.Close();

            return estadoHandle;
        }



        //Verificar campos obrigatórios
        public Boolean verificarCamposObrigatorios()
        {
            /*  if(cepTextBox.Text == "")
              {
                  MessageBox.Show("O campo Cep é obrigatório.");
                  return false;
              }
              else
              {
                  if(cidadeTextBox.Text == "")
                  {
                      MessageBox.Show("O campo cidade é obrigatório.");
                      return false;
                  }
                  else
                  {
                      if (estadoComboBox.SelectedValue == "")
                      {
                          MessageBox.Show("O campo estado é obrigatório.");
                          return false;
                      }
                      else
                      {
                          if (bairroTextBox.Text == "")
                          {
                              MessageBox.Show("O campo bairro é obrigatório.");
                              return false;
                          }
                          else
                          {
                              if (logradouroTextBox.Text == "")
                              {
                                  MessageBox.Show("O campo logradouro é obrigatório.");
                                  return false;
                              }
                              else
                              {
                                  return true;
                              }
                          }
                      }
                  }
              } */
            return true;
        }


        private void cepDropDown(object sender, EventArgs e)
        {
            //Limpa a combo box
            cepComboBox.Items.Clear();

            //Lista os tipos
            String query = "SELECT CEP FROM MD_CEP";
            query = StatusFilter.StatusNotIn(query);

            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                cepComboBox.Items.Add((reader["CEP"].ToString()));
            }
            reader.Close();
        }

        private void cepDropDownClosed(object sender, EventArgs e)
        {
            PreencherFormularioComCep(BuscarHandleCep(cepComboBox.SelectedItem.ToString()));

        }

        //Busca o handle do cep selecionado
        private int BuscarHandleCep(String cep)
        {
            int handleCep = 0;

            String query = " SELECT HANDLE" +
                           " FROM MD_CEP" +
                           " WHERE CEP = '" + cep + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                handleCep = Convert.ToInt32(reader["HANDLE"]);
            }
            reader.Close();
            return handleCep;
        }

        //Prenche o form depois de buscar o cep
        private void PreencherFormularioComCep(int handleCep)
        {
            estadoComboBox.SelectedText = "";

            String cep = "", pais = "", estado = "", cidade = "", bairro = "", logradouro = "";

            String query = " SELECT A.CEP, A.PAIS, A.ESTADO, A.CIDADE, A.BAIRRO, A.LOGRADOURO" +
                           " FROM MD_CEP A" +
                           " WHERE A.HANDLE = " + handleCep;
            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                cep = reader["CEP"].ToString();
                pais = reader["PAIS"].ToString();
                estado = reader["ESTADO"].ToString();
                cidade = reader["CIDADE"].ToString();
                bairro = reader["BAIRRO"].ToString();
                logradouro = reader["LOGRADOURO"].ToString();
            }
            reader.Close();
            //Preenche o campo estado
            preencherEstado();
            estadoComboBox.SelectedItem = estado;
            cidadeTextBox.Text = cidade;
            bairroTextBox.Text = bairro;
            logradouroTextBox.Text = logradouro;
        }

        //Controle de status
        public void controleDeStatus()
        {
            String status = "";
            String query = " SELECT B.NOME" +
                           " FROM PS_PESSOAENDERECO A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                           " WHERE A.HANDLE = " + handleEndereco;
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
                liberarButton.Location = new Point(770, 286);
                cancelarButton.Location = new Point(874, 286);
            }
            else
            {
                if (status == "Ag. modificações")
                {
                    //Controle de status
                    cepComboBox.Enabled = true;
                    cidadeTextBox.Enabled = true;
                    estadoComboBox.Enabled = true;
                    bairroTextBox.Enabled = true;
                    logradouroTextBox.Enabled = true;
                    numeroTextBox.Enabled = true;
                    referenciaTextBox.Enabled = true;
                    ObservacaoTextBox.Enabled = true;
                    //Controle de botões (Criar classe para isso)
                    liberarButton.Visible = true;
                    cancelarButton.Visible = true;
                    voltarButton.Visible = false;
                    gravarButton.Visible = false;
                    liberarButton.Location = new Point(770, 286);
                    cancelarButton.Location = new Point(874, 286);
                }
                else
                {
                    if (status == "Ativo")
                    {
                        //Caso esteja ativo, não permite alterar antes de voltar o registro
                        cepComboBox.Enabled = false;
                        cidadeTextBox.Enabled = false;
                        estadoComboBox.Enabled = false;
                        bairroTextBox.Enabled = false;
                        logradouroTextBox.Enabled = false;
                        numeroTextBox.Enabled = false;
                        referenciaTextBox.Enabled = false;
                        ObservacaoTextBox.Enabled = false;
                        //Controle de botões (Criar classe para isso)
                        gravarButton.Visible = false;
                        cancelarButton.Visible = false;
                        voltarButton.Visible = true;
                        liberarButton.Visible = false;
                        voltarButton.Location = new Point(874, 286);
                    }
                    else
                    {
                        if (status == "Cancelado")
                        {
                            //Caso esteja cancelado, não permite alterar antes de voltar o registro
                            cepComboBox.Enabled = false;
                            cidadeTextBox.Enabled = false;
                            estadoComboBox.Enabled = false;
                            bairroTextBox.Enabled = false;
                            logradouroTextBox.Enabled = false;
                            numeroTextBox.Enabled = false;
                            referenciaTextBox.Enabled = false;
                            ObservacaoTextBox.Enabled = false;
                            //Controle de botões (Criar classe para isso)
                            gravarButton.Visible = false;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = true;
                            liberarButton.Visible = false;
                            voltarButton.Location = new Point(874, 286);
                        }
                        else
                        {
                            gravarButton.Visible = true;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = false;
                            liberarButton.Visible = false;
                            gravarButton.Location = new Point(874, 286);
                        }
                    }
                }
                this.Text = "Pessoa - " + status;
                //  }
            }








        }
    }
