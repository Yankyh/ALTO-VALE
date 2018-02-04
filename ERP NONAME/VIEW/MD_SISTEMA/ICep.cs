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

namespace ALTO_VALE.VIEW.MD_SISTEMA
{
    public partial class ICep : Form
    {
        public static int cepHandle = 0;
        Connection connection = new Connection();

        public ICep()
        {
            InitializeComponent();
            connection.Conectar();
            if (cepHandle != 0)
            {
                preencherFormulario(cepHandle);
            }
            ControleDeStatus();
        }


        private void preencherFormulario(int cepHandle)
        {
            String query = " SELECT *" +
                           " FROM MD_CEP" +
                           " WHERE HANDLE = " + cepHandle;
            SqlDataReader reader = connection.Pesquisa(query);

            String cep = "", pais = "", estado = "", cidade = "", bairro = "", logradouro = "";
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
            //preenche os campos
            cepTextBox.Text = cep;
            paisComboBox.SelectedItem = pais;
            estadoComboBox.SelectedItem = estado;
            cidadeTextBox.Text = cidade;
            bairroTextBox.Text = bairro;
            logradouroTextBox.Text = logradouro;

        }


        //Alterar registro
        private void AlterarRegistro(String origem)
        {
            if (origem == "Gravar" || origem == "Liberar")
            {
                if (VerificarCamposObrigatorios() == true)
                {
                    String cep = "", pais = "", estado = "", cidade = "", bairro = "", logradouro = "";
                    cep = cepTextBox.Text;
                    pais = paisComboBox.SelectedItem.ToString();
                    estado = estadoComboBox.SelectedItem.ToString();
                    cidade = cidadeTextBox.Text;
                    bairro = bairroTextBox.Text;
                    logradouro = logradouroTextBox.Text;

                    if (origem == "Gravar")
                    {
                        String query = " INSERT INTO MD_CEP" +
                                       " (STATUS, CEP, PAIS, ESTADO, CIDADE, BAIRRO, LOGRADOURO)" +
                                       " VALUES" +
                                       " (1, '" + cep + "', '" + pais + "', '" + estado + "', '" + cidade + "', '" + bairro + "', '" + logradouro + "')";
                        connection.Inserir(query);
                        //Busca o Handle do registro inserido
                        String query1 = " SELECT " +
                                        " MAX(HANDLE) HANDLE" +
                                        " FROM MD_CEP" +
                                        " WHERE CEP = '" + cep + "'" +
                                        " AND PAIS = '" + pais + "' " +
                                        " AND ESTADO = '" + estado + "' " +
                                        " AND CIDADE = '" + cidade + "' " +
                                        " AND BAIRRO = '" + bairro + "' " +
                                        " AND LOGRADOURO = '" + logradouro + "'";
                        SqlDataReader reader = connection.Pesquisa(query1);
                        while (reader.Read())
                        {
                            try
                            {
                                cepHandle = Convert.ToInt32(reader["HANDLE"]);
                            }
                            catch
                            {

                            }
                        }
                        reader.Close();
                    }
                    else
                    {
                        if (origem == "Liberar")
                        {
                            String query = " UPDATE" +
                                           " MD_CEP" +
                                           " SET STATUS = 3, CEP = '" + cep + "', PAIS = '" + pais + "', ESTADO = '" + estado + "', CIDADE = '" + cidade + "', BAIRRO = '" + bairro + "', LOGRADOURO = '" + logradouro + "'" +
                                           " WHERE HANDLE = " + cepHandle;
                            connection.Inserir(query);
                        }
                    }
                }
            }
            else
            {
                if (origem == "Cancelar")
                {
                    String query = " UPDATE MD_CEP" +
                                   " SET STATUS = 4" +
                                   " WHERE HANDLE = " + cepHandle;
                    connection.Inserir(query);
                }
                else
                {
                    if (origem == "Voltar")
                    {
                        String query = " UPDATE" +
                                       " MD_CEP" +
                                       " SET STATUS = 2" +
                                       " WHERE HANDLE = " + cepHandle;
                        connection.Inserir(query);
                    }
                }
            }
            ControleDeStatus();
        }

        private void gravarButtonOnClick(object sender, EventArgs e)
        {
            AlterarRegistro("Gravar");
        }

        private void liberarButtonOnClick(object sender, EventArgs e)
        {
            AlterarRegistro("Liberar");
        }

        private void cancelarButtonOnClick(object sender, EventArgs e)
        {
            DialogResult confirmacaoButton = MessageBox.Show("Deseja Continuar?", "Cancelar cep", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmacaoButton.ToString().ToUpper() == "YES")
            {
                AlterarRegistro("Cancelar");
            }
        }

        //verifica se os campos obrigatorios foram preenchidos
        private Boolean VerificarCamposObrigatorios()
        {
            if (cepTextBox.Text == "")
            {
                MessageBox.Show("O campo Cep é obrigatório.");
                return false;
            }
            else
            {
                if (paisComboBox.Text == "")
                {
                    MessageBox.Show("O campo país é obrigatório.");
                    return false;
                }
                else
                {
                    if (estadoComboBox.Text == "")
                    {
                        MessageBox.Show("O campo estado é obrigatório.");
                        return false;
                    }
                    else
                    {
                        if (cidadeTextBox.Text == "")
                        {
                            MessageBox.Show("O campo cidade é obrigatório.");
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
                }
            }
        }

        private void voltarButtonOnClick(object sender, EventArgs e)
        {
            AlterarRegistro("Voltar");
        }
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            cepHandle = 0;
            connection.Desconectar();
        }

        //Controle de status
        private void ControleDeStatus()
        {

            String status = "";
            String query = " SELECT B.NOME" +
                           " FROM MD_CEP A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                           " WHERE A.HANDLE = " + cepHandle;
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
                liberarButton.Location = new Point(439, 108);
                cancelarButton.Location = new Point(543, 108);
            }
            else
            {
                if (status == "Ag. modificações")
                {
                    //Controle de status
                    cepTextBox.Enabled = true;
                    paisComboBox.Enabled = true;
                    estadoComboBox.Enabled = true;
                    cidadeTextBox.Enabled = true;
                    bairroTextBox.Enabled = true;
                    logradouroTextBox.Enabled = true;
                    //Controle de botões (Criar classe para isso)
                    liberarButton.Visible = true;
                    cancelarButton.Visible = true;
                    voltarButton.Visible = false;
                    gravarButton.Visible = false;
                    liberarButton.Location = new Point(439, 108);
                    cancelarButton.Location = new Point(543, 108);
                }
                else
                {
                    if (status == "Ativo")
                    {
                        //Caso esteja ativo, não permite alterar antes de voltar o registro
                        cepTextBox.Enabled = false;
                        paisComboBox.Enabled = false;
                        estadoComboBox.Enabled = false;
                        cidadeTextBox.Enabled = false;
                        bairroTextBox.Enabled = false;
                        logradouroTextBox.Enabled = false;
                        //Controle de botões (Criar classe para isso)
                        gravarButton.Visible = false;
                        cancelarButton.Visible = false;
                        voltarButton.Visible = true;
                        liberarButton.Visible = false;
                        voltarButton.Location = new Point(543, 108);
                    }
                    else
                    {
                        if (status == "Cancelado")
                        {
                            //Caso esteja cancelado, não permite alterar antes de voltar o registro
                            cepTextBox.Enabled = false;
                            paisComboBox.Enabled = false;
                            estadoComboBox.Enabled = false;
                            cidadeTextBox.Enabled = false;
                            bairroTextBox.Enabled = false;
                            logradouroTextBox.Enabled = false;
                            //Controle de botões (Criar classe para isso)
                            gravarButton.Visible = false;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = true;
                            liberarButton.Visible = false;
                            voltarButton.Location = new Point(543, 108);
                        }
                        else
                        {
                            gravarButton.Visible = true;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = false;
                            liberarButton.Visible = false;
                            gravarButton.Location = new Point(543, 108);
                        }
                    }
                }
            }
            this.Text = "Endereço - " + status;
        }

        private void ICep_Load(object sender, EventArgs e)
        {

        }

        private void bairroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
