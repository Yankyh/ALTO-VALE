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
        public static int contatoHandle = 0;

        public IPessoaContato()
        {
            InitializeComponent();
            //Conexão
            connection.Conectar();
            //Preencher o formulário ao abrir
            if (contatoHandle == 0)
            {
                ControleDeStatus();
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

        //Preencher pessoa
        private void PreencherPessoa()
        {
            //Limpa a combo box
            pessoaComboBox.Items.Clear();

            //Lista os tipos
            String query = " SELECT A.RAZAOSOCIAL " +
                           " FROM PS_PESSOA A " +
                           " INNER JOIN PS_PESSOACONTATO B ON B.PESSOA = A.HANDLE"+
                           " WHERE A.STATUS = 3 OR B.PESSOA = (SELECT PESSOA FROM PS_PESSOACONTATO WHERE HANDLE = "+contatoHandle+") ";
            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                pessoaComboBox.Items.Add((reader["RAZAOSOCIAL"].ToString()));
            }
            reader.Close();
        }

        private void tipoDropDown(object sender, EventArgs e)
        {
            preencherTipo();
        }

        private void gravarButtonOnClick(object sender, EventArgs e)
        {
            alterarRegistro("Gravar");
        }

        //Inserir informações com o gravar
        private void alterarRegistro(String origem)
        {
            //Verifica se os campos obrigatorios foram preenchidos
            if (verificarCamposObrigatorios() == false)
            {

            }
            else
            {
                String telefone = "", celular = "", email = "", observacao = "";
                int tipo = 0, pessoa = 0;

                telefone = telefoneTextBox.Text;
                celular = celularTextBox.Text;
                email = emailTextBox.Text;
                observacao = ObservacaoTextBox.Text;
                tipo = buscarHandleTipo();
                pessoa = BuscarHandlePessoa();

                //Inserir
                if (origem == "Gravar")
                {
                    String query = "INSERT INTO PS_PESSOACONTATO (STATUS, TIPO, TELEFONE, CELULAR, EMAIL, OBSERVACAO, PESSOA) VALUES (1," + tipo + ", '" + telefone + "', '" + celular + "', '" + email + "', '" + observacao + "', " + pessoa + ")";
                    connection.Inserir(query);

                    String query1 = " SELECT MAX(A.HANDLE) HANDLE " +
                                    " FROM PS_PESSOACONTATO A" +
                                    " WHERE A.TIPO = " + tipo + " AND A.TELEFONE = '" + telefone + "' AND A.CELULAR = '" + celular + "' AND A.EMAIL = '" + email + "' AND A.OBSERVACAO = '" + observacao + "'";

                    SqlDataReader reader = connection.Pesquisa(query1);
                    int maxHandleContato = 0;
                    while (reader.Read())
                    {
                        maxHandleContato = Convert.ToInt32(reader["HANDLE"]);
                        contatoHandle = maxHandleContato;
                    }
                    reader.Close();

                }
                //Alterar
                if (origem == "Alterar")
                {
                    String query = " UPDATE PS_PESSOACONTATO" +
                                   " SET " +
                                   " STATUS = 3," +
                                   " TELEFONE = '" + telefone + "'," +
                                   " CELULAR = '" + celular + "'," +
                                   " EMAIL = '" + email + "'," +
                                   " OBSERVACAO = '" + observacao + "'," +
                                   " TIPO = " + tipo + "," +
                                   " PESSOA = " + pessoa + "" +
                                   " WHERE HANDLE = " + contatoHandle;
                    connection.Inserir(query);
                }
                if (origem == "Cancelar")
                {
                    String query = " UPDATE PS_PESSOACONTATO" +
                                   " SET " +
                                   " STATUS = 4" +
                                   " WHERE HANDLE = " + contatoHandle;
                    connection.Inserir(query);
                }
                ControleDeStatus();
            }
        }
        //Busca o handle da pessoa selecionada
        private int BuscarHandlePessoa()
        {
            int handlePessoaSelecionada = 0;

            try
            {
                String query = "SELECT HANDLE FROM PS_PESSOA WHERE RAZAOSOCIAL = '" + pessoaComboBox.SelectedItem.ToString() + "'";
                SqlDataReader reader = connection.Pesquisa(query);

                while (reader.Read())
                {
                    handlePessoaSelecionada = Convert.ToInt32(reader["HANDLE"]);
                }
                reader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            return handlePessoaSelecionada;
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
        //Buscar status da pessoa
        private int BuscarStatusPessoa()
        {
            int statusPessoa = 0;
            String query = " SELECT A.STATUS" +
                           " FROM PS_PESSOA A" +
                           " WHERE HANDLE = " + BuscarHandlePessoa();
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                statusPessoa = Convert.ToInt32(reader["STATUS"]);
            }
            reader.Close();

            return statusPessoa;
        }
        //Controle de status
        public void ControleDeStatus()
        {
            String status = "";
            String query = " SELECT B.NOME" +
                           " FROM PS_PESSOACONTATO A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                           " WHERE A.HANDLE = " + contatoHandle;
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
                    emailTextBox.Enabled = true;
                    tipoComboBox.Enabled = true;
                    telefoneTextBox.Enabled = true;
                    celularTextBox.Enabled = true;
                    ObservacaoTextBox.Enabled = true;
                    pessoaComboBox.Enabled = true;
                    //Controle de botões (Criar classe para isso)
                    liberarButton.Visible = true;
                    cancelarButton.Visible = true;
                    voltarButton.Visible = false;
                    gravarButton.Visible = false;
                    liberarButton.Location = new Point(564, 269);
                    cancelarButton.Location = new Point(668, 269);
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
                        pessoaComboBox.Enabled = false;
                        //Controle de botões (Criar classe para isso)
                        gravarButton.Visible = false;
                        cancelarButton.Visible = false;
                        voltarButton.Visible = true;
                        liberarButton.Visible = false;
                        voltarButton.Location = new Point(668, 269);
                    }
                    else
                    {
                        if (status == "Cancelado")
                        {
                            //Caso esteja ativo, não permite alterar antes de voltar o registro
                            emailTextBox.Enabled = false;
                            tipoComboBox.Enabled = false;
                            telefoneTextBox.Enabled = false;
                            celularTextBox.Enabled = false;
                            ObservacaoTextBox.Enabled = false;
                            pessoaComboBox.Enabled = false;
                            //Controle de botões (Criar classe para isso)
                            gravarButton.Visible = false;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = true;
                            liberarButton.Visible = false;
                            voltarButton.Location = new Point(668, 269);
                        }
                        else
                        {
                            gravarButton.Visible = true;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = false;
                            liberarButton.Visible = false;
                            gravarButton.Location = new Point(668, 269);
                        }
                    }
                }
            }
            this.Text = "Contato - " + status;
        }

        public void preencherFormulario(int contatoHandle)
        {
            //Preenche o combo box tipo
            preencherTipo();
            PreencherPessoa();

            //Preenche o form com as informações da pessoa selecionada
            String telefone = "", celular = "", email = "", observacao = "", tipoContato = "", situacao = "", pessoa = "";
            String query = " SELECT D.RAZAOSOCIAL, A.TELEFONE, A.CELULAR, A.EMAIL, A.OBSERVACAO, B.NOME TIPO, C.NOME SITUACAO" +
                           " FROM PS_PESSOACONTATO A" +
                           " INNER JOIN PS_PESSOACONTATOTIPO B ON B.HANDLE = A.TIPO" +
                           " INNER JOIN MD_STATUS C ON C.HANDLE = A.STATUS" +
                           " INNER JOIN PS_PESSOA D ON D.HANDLE = A.PESSOA" +
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
                pessoa = (reader["RAZAOSOCIAL"].ToString());
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
            pessoaComboBox.SelectedItem = pessoa;
            ControleDeStatus();
        }
        private void voltarRegistro()
        {
            String query = " UPDATE PS_PESSOACONTATO" +
                           " SET STATUS = 2" +
                           " WHERE HANDLE =" + contatoHandle;
            connection.Inserir(query);
            ControleDeStatus();
        }
        private void voltarButtonOnClick(object sender, EventArgs e)
        {
            if (BuscarStatusPessoa() == 4)
            {
                MessageBox.Show("O cadastro da pessoa não pode estar cancelado para voltar o contato.");
            }
            else
            {
                voltarRegistro();
            }
        }

        private void contatoFormClosed(object sender, FormClosedEventArgs e)
        {
            contatoHandle = 0;
        }

        private void cancelarButtonOnClick(object sender, EventArgs e)
        {
            alterarRegistro("Cancelar");
        }

        private void PessoaComboBoxDropDown(object sender, EventArgs e)
        {
            PreencherPessoa();
        }

        private void liberarButtonOnClick(object sender, EventArgs e)
        {
            if (BuscarStatusPessoa() == 4)
            {
                MessageBox.Show("O cadastro da pessoa não pode estar cancelado para liberar o contato.");
            }
            else
            {
                alterarRegistro("Alterar");
                ControleDeStatus();
            }

        }
    }
}
