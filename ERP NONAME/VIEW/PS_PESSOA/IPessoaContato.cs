using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ALTO_VALE.DAL;
using System.Data.SqlClient;

namespace ALTO_VALE.VIEW.PS_PESSOA
{

    public partial class IPessoaContato : Form
    {
        Connection connection = new Connection();
        //Handle statico
        public static int pessoaHandle = 0, contatoHandle = 0;

        public IPessoaContato()
        {
            InitializeComponent();
            //Conexão
            connection.Conectar();
            //Preencher o formulário ao abrir
            if (contatoHandle == 0)
            {
                controleDeStatus();
            }
            else
            {
                preencherFormulario(contatoHandle);
            }

        }



        //Preencher o tipo
        private void preencherTipo()
        {
            //Limpa a combo box
            tipoComboBox.Items.Clear();

            //Lista os tipos
            String query = "SELECT NOME FROM PS_PESSOACONTATOTIPO";
            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                tipoComboBox.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();
        }

        private void tipoDropDown(object sender, EventArgs e)
        {
            preencherTipo();
        }

        private void gravarButtonOnClick(object sender, EventArgs e)
        {
            inserirRegistro("Gravar");
        }

        //Inserir informações com o gravar
        private void inserirRegistro(String origem)
        {
            //Verifica se os campos obrigatorios foram preenchidos
            if (verificarCamposObrigatorios() == false)
            {

            }
            else
            {
                String telefone = "", celular = "", email = "", observacao = "";
                int tipo = 0;

                telefone = telefoneTextBox.Text;
                celular = celularTextBox.Text;
                email = emailTextBox.Text;
                observacao = ObservacaoTextBox.Text;
                tipo = buscarHandleTipo();

                //Inserir
                if (origem == "Gravar")
                {
                    String query = "INSERT INTO PS_PESSOACONTATO (STATUS, TIPO, TELEFONE, CELULAR, EMAIL, OBSERVACAO) VALUES (1," + tipo + ", '" + telefone + "', '" + celular + "', '" + email + "', '" + observacao + "')";
                    connection.Inserir(query);

                    String query1 = "SELECT MAX(HANDLE) HANDLE FROM PS_PESSOACONTATO WHERE TIPO = " + tipo + " AND TELEFONE = '" + telefone + "' AND CELULAR = '" + celular + "' AND EMAIL = '" + email + "' AND OBSERVACAO = '" + observacao + "'";
                    SqlDataReader reader = connection.Pesquisa(query1);
                    int maxHandleContato = 0;
                    while (reader.Read())
                    {
                        maxHandleContato = Convert.ToInt32(reader["HANDLE"]);
                    }
                    reader.Close();
                    String query2 = "INSERT INTO PS_PESSOACONTATOFK (PESSOA, CONTATO) VALUES (" + pessoaHandle + ", " + maxHandleContato + ")";
                    connection.Inserir(query2);
                    controleDeStatus();
                }
                //Alterar
                if (origem == "Alterar")
                {
                    String query = " UPDATE PS_PESSOACONTATO" +
                                   " SET " +
                                   " STATUS = 3," +
                                   " TELEFONE = '"+telefone+"'," +
                                   " CELULAR = '"+celular+"'," +
                                   " EMAIL = '"+email+"'," +
                                   " OBSERVACAO = '"+observacao+"'," +
                                   " TIPO = "+tipo+"" +
                                   " WHERE HANDLE = "+contatoHandle;
                    connection.Inserir(query);
                }
            }
        }

        //Busca o handle do tipo selecionado
        private int buscarHandleTipo()
        {
            int tipoHandle = 0;
            String query = "SELECT HANDLE FROM PS_PESSOACONTATOTIPO WHERE NOME = '" + tipoComboBox.SelectedItem.ToString() + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                tipoHandle = Convert.ToInt32(reader["HANDLE"]);
            }
            reader.Close();
            return tipoHandle;
        }
        //Verifica se os campos foram preenchidos
        public Boolean verificarCamposObrigatorios()
        {
            if (tipoComboBox.Text == "")
            {
                MessageBox.Show("O campo tipo é obrigatório.");
                return false;
            }
            else
            {
                if (telefoneTextBox.Text == "" || celularTextBox.Text == "" || emailTextBox.Text == "")
                {
                    MessageBox.Show("Insira pelo menos um tipo de contato.");
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

        //Controle de status
        public void controleDeStatus()
        {
            String status = "";
            String query = " SELECT B.NOME" +
                           " FROM PS_PESSOACONTATO A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                           " WHERE A.HANDLE = "+contatoHandle;
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
                this.Text = "Contato - Cadastrado";
                liberarButton.Location = new Point(564, 205);
                cancelarButton.Location = new Point(668, 205);
            }
            else
            {
                if (status == "Ag. modificações")
                {
                    //Controle de status

                    emailTextBox.Enabled = true;
                    tipoComboBox.Enabled = true;
                    telefoneTextBox.Enabled = true;
                    celularTextBox.Enabled = true;
                    ObservacaoTextBox.Enabled = true;
                    //Controle de botões (Criar classe para isso)
                    liberarButton.Visible = true;
                    cancelarButton.Visible = true;
                    voltarButton.Visible = false;
                    gravarButton.Visible = false;
                    this.Text = "Contato - Ag. modificações";
                    liberarButton.Location = new Point(564, 205);
                    cancelarButton.Location = new Point(668, 205);
                }
                else
                {
                    if (status == "Ativo")
                    {
                        //Caso esteja ativo, não permite alterar antes de voltar o registro
                        emailTextBox.Enabled = false;
                        tipoComboBox.Enabled = false;
                        telefoneTextBox.Enabled = false;
                        celularTextBox.Enabled = false;
                        ObservacaoTextBox.Enabled = false;
                        //Controle de botões (Criar classe para isso)
                        gravarButton.Visible = false;
                        cancelarButton.Visible = false;
                        voltarButton.Visible = true;
                        liberarButton.Visible = false;
                        this.Text = "Pessoa - Ativo";
                        voltarButton.Location = new Point(668, 205);
                    }
                    else
                    {
                            gravarButton.Visible = true;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = false;
                            liberarButton.Visible = false;
                            gravarButton.Location = new Point(668, 205);
                    }
                }
            }
        }

        public void preencherFormulario(int contatoHandle)
        {
            //Preenche o combo box tipo
            preencherTipo();

            //Preenche o form com as informações da pessoa selecionada
            String telefone = "", celular = "", email = "", observacao = "", tipoContato = "", situacao = "";
            String query = " SELECT  A.TELEFONE, A.CELULAR, A.EMAIL, A.OBSERVACAO, B.NOME TIPO, C.NOME SITUACAO" +
                           " FROM PS_PESSOACONTATO A" +
                           " INNER JOIN PS_PESSOACONTATOTIPO B ON B.HANDLE = A.TIPO" +
                           " INNER JOIN MD_STATUS C ON C.HANDLE = A.STATUS" +
                           " WHERE A.HANDLE = " + contatoHandle;
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                email = (reader["EMAIL"].ToString());
                tipoContato = (reader["TIPO"].ToString());
                telefone = (reader["TELEFONE"].ToString());
                celular = (reader["CELULAR"].ToString());
                observacao = (reader["OBSERVACAO"].ToString());
                situacao = (reader["SITUACAO"].ToString());
            }
            reader.Close();
            //Preenche o status do form
            this.Text = this.Text + " - " + situacao;
            //Preenche os campos
            emailTextBox.Text = email;
            tipoComboBox.SelectedItem = tipoContato;
            telefoneTextBox.Text = telefone;
            celularTextBox.Text = celular;
            ObservacaoTextBox.Text = observacao;
            controleDeStatus();
        }
        private void voltarRegistro()
        {
            String query = " UPDATE PS_PESSOACONTATO" +
                           " SET STATUS = 2" +
                           " WHERE HANDLE =" + contatoHandle;
            connection.Inserir(query);
            controleDeStatus();
        }
        private void voltarButtonOnClick(object sender, EventArgs e)
        {
            voltarRegistro();
        }

        private void contatoFormClosed(object sender, FormClosedEventArgs e)
        {
            pessoaHandle = 0;
            contatoHandle = 0;
        }

        private void liberarButtonOnClick(object sender, EventArgs e)
        {
            inserirRegistro("Alterar");
            controleDeStatus();
        }
    }
}
