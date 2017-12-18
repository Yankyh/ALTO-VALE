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
using ALTO_VALE.DAL;
using System.Data.SqlClient;

namespace ALTO_VALE.VIEW.PS_PESSOA
{
    public partial class IPessoa : Form
    {
        Connection connection = new Connection();
        StatusFilter statusFilter = new StatusFilter();

        //verifica se foi aberto pelo datagridview
        public static int pessoaHandle = 0;

        public IPessoa()
        {
            InitializeComponent();
            connection.Conectar();
            cpfcnpjTextBox.Enabled = false;
            //preenche o formulario caso seja diferente de 0
            if(pessoaHandle == 0)
            {
                controleDeStatus("Vazio");
            }
            else
            {
                preencherFormulario(pessoaHandle);
                pessoaHandle = 0;
            }
        }

        

        private void gravarButtonOnClick(object sender, EventArgs e)
        {
            //Método para verificar os campos obrigatórios e método para validar se o cpf/cnpj já não foi cadastrado
            if (verificarCamposObrigatorios() == true && (validarCpfCnpjCadastrado() == true || buscarHandlePessoa() != 0))
            {
                    //Gravar o registro
                    gravarRegistroPessoa();
                    controleDeStatus("Cadastrado");
            }          
        }


        //Metodos
        private void gravarRegistroPessoa()
        {
            String apelido = "", razaoSocial = "", email = "", cpfCnpj = "", telefone = "", celular = "", observacao = "";
            int tipoPessoa = 0, cepSelecionadoHandle = 0;
            apelido = apelidoTextBox.Text;
            razaoSocial = razaoSocialTextBox.Text;
            email = emailTextBox.Text;
            cpfCnpj = cpfcnpjTextBox.Text;
            telefone = telefoneTextBox.Text;
            tipoPessoa = tipoPessoaHandle();
            cepSelecionadoHandle = cepHandle();
            celular = celularTextBox.Text;
            observacao = ObservacaoTextBox.Text;

            //Verifica se o registro já foi gravado alguma vez
            if (buscarHandlePessoa() != 0)
            {
            //BOTAR O TIPO DA PESSOA
                String queryUpdate = "UPDATE PS_PESSOA SET STATUS = 3, APELIDO = '"+apelido+"', RAZAOSOCIAL = '"+razaoSocial+ "'," +
                                     " EMAIL = '" + email + "', CPFCNPJ = '" + cpfCnpj + "', TIPO = "+ tipoPessoaHandle() + ", " +
                                     " TELEFONE = '" + telefone + "', CELULAR = '" + celular + "', OBSERVACAO = '" + observacao + "'" +
                                     " WHERE HANDLE = "+ buscarHandlePessoa();
                connection.Inserir(queryUpdate);
            }
            else
            {
                //Caso não exista ele insere
                //Query principal de insert
                String queryInsert = " INSERT INTO PS_PESSOA (STATUS, APELIDO, RAZAOSOCIAL, EMAIL,CPFCNPJSEMMASCARA, CPFCNPJ, TELEFONE, CELULAR, TIPO, ENDERECO, OBSERVACAO) VALUES" +
                                     " ( " + 1 + ",'" + apelido + "', '" + razaoSocial + "','" + email + "','" + cpfCnpj.Replace(".", "").Replace("-", "").Replace("/", "") + "', " +
                                     " '" + cpfCnpj + "', '" + telefone + "', '" + celular + "', '" + tipoPessoa + "', " + cepSelecionadoHandle + ", '" + observacao + "')";
                connection.Inserir(queryInsert);
            }
        }

        //Metodos de busca de handle
        private int tipoPessoaHandle()
        {
            int tipoPessoaHandle = 0;
            String tipoPessoaSelecionado = "";
            tipoPessoaSelecionado = tipoComboBox.SelectedItem.ToString();

            String query = "SELECT HANDLE FROM PS_PESSOATIPO WHERE NOME = '"+tipoPessoaSelecionado+"'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                tipoPessoaHandle = Convert.ToInt32((reader["HANDLE"]));
            }
            reader.Close();
            
            return tipoPessoaHandle;
        }
        //Busca o handle do CEP
        private int cepHandle()
        {
            int cepHandle = 0;
            String cepSelecionado = "";
            
            if (cepComboBox.SelectedItem != null)
            {
                cepSelecionado = cepComboBox.SelectedItem.ToString();
               
            }

            String query = "SELECT HANDLE FROM PS_PESSOAENDERECO WHERE CEP = '" + cepSelecionado + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                cepHandle = Convert.ToInt32((reader["HANDLE"]));
            }
            reader.Close();
            
            return cepHandle;
        }
        //--------------------
        //Metodos de fomatação
        //Conversor de CNPJ
        private void converterCNPJ(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox; // ou text Box
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                t.SelectionStart = t.Text.Length + 1;

                if (t.Text.Length == 2 || t.Text.Length == 6)
                    t.Text += ".";
                else if (t.Text.Length == 10)
                    t.Text += "/";
                else if (t.Text.Length == 15)
                    t.Text += "-";
                t.SelectionStart = t.Text.Length + 1;
            }
        }

        //Conversor de CPF
        private void converterCpf(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox; // ou text Box
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                t.SelectionStart = t.Text.Length + 1;

                if (t.Text.Length == 3 || t.Text.Length == 7)
                    t.Text += ".";
                else if (t.Text.Length == 11)
                    t.Text += "-";
                t.SelectionStart = t.Text.Length + 1;
            }
        }
        //Metodo que chama o conversor de CNPJ
        private void cpfCnpjKeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite que seja digitado somente números e backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            int tipoPessoa = 0;
            tipoPessoa = tipoPessoaHandle();

            if (tipoPessoa == 1)
            {
                converterCpf(sender, e);
                cpfcnpjTextBox.MaxLength = 14;
            }
            else
            {
                if (tipoPessoa == 2)
                {
                    converterCNPJ(sender, e);
                    cpfcnpjTextBox.MaxLength = 18;
                }
            }
        }
        //Tipo Pessoa
        private void tipoDropDown(object sender, EventArgs e)
        {
            preencherTipo();
        }
        private void preencherTipo()
        {
            //Limpa a combo box
            tipoComboBox.Items.Clear();

            //Lista os tipos
            String query = "SELECT NOME FROM PS_PESSOATIPO";
            query = StatusFilter.StatusNotIn(query);

            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                tipoComboBox.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();
        }




        //Metodos de validação
        private Boolean validarCpfCnpj()
        {
            int tipoPessoa = 0;
            String cpfCnpj = "";
            tipoPessoa = tipoPessoaHandle();

            if (tipoPessoa == 1)
            {
                cpfcnpjTextBox.Text = Convert.ToUInt64(cpfcnpjTextBox.Text).ToString(@"000\.000\.000\-00");
            }
            else
            {
             if(tipoPessoa == 2)
                {

                }
            }
            return false;
        }



        private void tipoDropClosed(object sender, EventArgs e)
        {
            cpfcnpjTextBox.Text = "";
            if(tipoComboBox.SelectedIndex == -1)
            {
                cpfcnpjTextBox.Enabled = false;
            }
            else
            {
                cpfcnpjTextBox.Enabled = true;
            }
        }
        //Verifica se o CPF ou CNPJ já foi cadastrado
        private Boolean validarCpfCnpjCadastrado()
        {
            
            String cpfCnpj = "";
            cpfCnpj = cpfcnpjTextBox.Text;
            int count = 0;

            String query = "SELECT HANDLE FROM PS_PESSOA WHERE CPFCNPJ = '"+ cpfCnpj+"'";
            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                count++;
            }
            if(count > 0)
            {
                reader.Close();
                return false;
            }
            else
            {
                reader.Close();
                return true;
            }

           

        }

        //Metodo para encerrar a conexão ao fechar o form
        private void IPessoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Desconectar();
        }


        //Campos obrigatórios
        public Boolean verificarCamposObrigatorios()
        {

            if(apelidoTextBox.Text == "")
            {
                MessageBox.Show("O campo apelido é obrigatório.");
                return false;
            }
            else
            {
                if (razaoSocialTextBox.Text == "")
                {
                    MessageBox.Show("O campo razão social é obrigatório.");
                    return false;
                }
                else
                {
                    if (tipoComboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("O campo tipo é obrigatório.");
                        return false;
                    }
                    else
                    {
                        if (cpfcnpjTextBox.Text == "")
                        {
                            MessageBox.Show("O campo CPF/CNPJ é obrigatório.");
                            return false;
                        }
                        else
                        {
                            if (cepComboBox.SelectedIndex == -1)
                            {
                                MessageBox.Show("O campo CEP é obrigatório.");
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

        private void cepDropDown(object sender, EventArgs e)
        {
            preencherCep();
        }
        private void preencherCep()
        {
            //Limpa a combo box
            cepComboBox.Items.Clear();

            //Lista os tipos
            String query = "SELECT CEP FROM PS_PESSOAENDERECO";
            query = StatusFilter.StatusNotIn(query);

            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                cepComboBox.Items.Add((reader["CEP"].ToString()));
            }
            reader.Close();
        }

        private void cepTextChanged(object sender, EventArgs e)
        {
            preencherEndereco();
        }
        public void preencherEndereco()
        {
            int cepHandleSelecionado = cepHandle();
            String cidade = "", bairro = "", logradouro = "", numero = "", referencia = "", estado = "";
            //Busca as informações do CEP selecionado para preencher os campos
            String query = " SELECT A.CIDADE, A.BAIRRO, A.LOGRADOURO, A.NUMERO, A.REFERENCIA, B.SIGLA ESTADO " +
                           " FROM PS_PESSOAENDERECO A " +
                           " INNER JOIN PS_ESTADO B ON B.HANDLE = A.ESTADO " +
                           " WHERE A.HANDLE = " + cepHandleSelecionado;
            // query = StatusFilter.StatusNotIn(query);

            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                cidade = (reader["CIDADE"].ToString());
                bairro = (reader["BAIRRO"].ToString());
                logradouro = (reader["LOGRADOURO"].ToString());
                numero = (reader["NUMERO"].ToString());
                referencia = (reader["REFERENCIA"].ToString());
                estado = (reader["ESTADO"].ToString());
            }
            reader.Close();
            //Preenche os campos
            cidadeTextBox.Text = cidade;
            bairroTextBox.Text = bairro;
            logradouroTextBox.Text = logradouro;
            numeroTextBox.Text = numero;
            referenciaTextBox.Text = referencia;
            estadoTextBox.Text = estado;
        }

        public void preencherFormulario(int handlePessoa)
        {
            //Preenche o combo box tipo
            preencherTipo();
            preencherCep();
            //Preenche o form com as informações da pessoa selecionada
            String apelido = "", razaoSocial = "", email = "", cpfCnpj = "", telefone = "", celular = "", observacao = "", tipo = "", situacao = "", cep = "";
            int tipoPessoa = 0, cepSelecionadoHandle = 0;

            String query = " SELECT C.NOME SITUACAO, A.APELIDO, A.RAZAOSOCIAL, B.NOME TIPO, A.CPFCNPJ, A.TELEFONE, A.CELULAR, A.EMAIL, A.OBSERVACAO, D.CEP" +
                           " FROM PS_PESSOA A" +
                           " INNER JOIN PS_PESSOATIPO B ON B.HANDLE = A.TIPO" +
                           " INNER JOIN MD_STATUS C ON C.HANDLE = A.STATUS" +
                           " INNER JOIN PS_PESSOAENDERECO D ON D.HANDLE = A.ENDERECO" +
                           " WHERE A.HANDLE = " + handlePessoa;
            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                apelido = (reader["APELIDO"].ToString());
                razaoSocial = (reader["RAZAOSOCIAL"].ToString());
                email = (reader["EMAIL"].ToString());
                tipo = (reader["TIPO"].ToString());
                cpfCnpj = (reader["CPFCNPJ"].ToString());
                telefone = (reader["TELEFONE"].ToString());
                celular = (reader["CELULAR"].ToString());
                observacao = (reader["OBSERVACAO"].ToString());
                situacao = (reader["SITUACAO"].ToString());
                cep = (reader["CEP"].ToString());
            }
            reader.Close();

            //Preenche o status do form
            this.Text = this.Text + " - " + situacao;
            //Preenche os campos
            apelidoTextBox.Text = apelido;
            razaoSocialTextBox.Text = razaoSocial;
            emailTextBox.Text = email;
            tipoComboBox.SelectedItem = tipo;
            cpfcnpjTextBox.Text = cpfCnpj;
            telefoneTextBox.Text = telefone;
            celularTextBox.Text = celular;
            ObservacaoTextBox.Text = observacao;
            //Preenche o endereço
            //Busca os dados do cep selecionado
            cepComboBox.SelectedItem = cep;
            preencherEndereco();

            controleDeStatus(situacao);
        }

        private void voltarButtonOnClick(object sender, EventArgs e)
        {

            if(buscarStatusRegistro() == 3)
            {
                //Altera o status
                String query1 = "UPDATE PS_PESSOA SET STATUS  = 2 WHERE HANDLE = " + buscarHandlePessoa();
                SqlDataReader reader = connection.Pesquisa(query1);
                reader.Close();
                controleDeStatus("Ag. modificações");
            }
            else
            {
                MessageBox.Show("Para voltar o registro, a situação deve ser ativo.");
            }

        }


        private int buscarHandlePessoa()
        {
            //Busca o handle do registro a ser voltado
            String query = "SELECT HANDLE FROM PS_PESSOA WHERE CPFCNPJ = '" + cpfcnpjTextBox.Text + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            int handlePessoaModificar = 0;

            while (reader.Read())
            {
                handlePessoaModificar = Convert.ToInt32(reader["HANDLE"]);
            }
            reader.Close();
            //alterado status do registro voltado

            return handlePessoaModificar;
        }

        private void liberarButtonOnClick(object sender, EventArgs e)
        {
            //Altera o status
            if(buscarStatusRegistro() == 1 || buscarStatusRegistro() == 2)
            {
                String query = "UPDATE PS_PESSOA SET STATUS = 3 WHERE HANDLE = " + buscarHandlePessoa();
                SqlDataReader reader = connection.Pesquisa(query);
                reader.Close();
                //Grava o registro
                gravarRegistroPessoa();
                controleDeStatus("Ativo");
            }
            else
            {
                MessageBox.Show("O registro não pode estar em um status diferente de Cadastrado ou Ag. modificações para liberar o reigstro.");
            }
           
        }




        //Controle de status
        public void controleDeStatus(String status)
        {
            if (status == "Cadastrado")
            {                    
                gravarButton.Visible = false;
                cancelarButton.Visible = true;
                voltarButton.Visible = false;
                liberarButton.Visible = true;
                this.Text = "Pessoa - Cadastrado";
            }
            else
            {
                if (status == "Ag. modificações")
                {
                    //Controle de status
                    apelidoTextBox.Enabled = true;
                    razaoSocialTextBox.Enabled = true;
                    emailTextBox.Enabled = true;
                    tipoComboBox.Enabled = true;
                    cpfcnpjTextBox.Enabled = true;
                    telefoneTextBox.Enabled = true;
                    celularTextBox.Enabled = true;
                    ObservacaoTextBox.Enabled = true;
                    //Endereços
                    cepComboBox.Enabled = true;
                    cidadeTextBox.Enabled = true;
                    estadoTextBox.Enabled = true;
                    bairroTextBox.Enabled = true;
                    logradouroTextBox.Enabled = true;
                    numeroTextBox.Enabled = true;
                    referenciaTextBox.Enabled = true;
                    //Controle de botões (Criar classe para isso)
                    liberarButton.Visible = true;
                    cancelarButton.Visible = true;
                    voltarButton.Visible = false;
                    gravarButton.Visible = false;
                    this.Text = "Pessoa - Ag. modificações";
                }
                else
                {
                    if (status == "Ativo")
                    {
                    //Caso esteja ativo, não permite alterar antes de voltar o registro
                    apelidoTextBox.Enabled = false;
                    razaoSocialTextBox.Enabled = false;
                    emailTextBox.Enabled = false;
                    tipoComboBox.Enabled = false;
                    cpfcnpjTextBox.Enabled = false;
                    telefoneTextBox.Enabled = false;
                    celularTextBox.Enabled = false;
                    ObservacaoTextBox.Enabled = false;
                    //Endereço
                    cepComboBox.Enabled = false;
                    cidadeTextBox.Enabled = false;
                    estadoTextBox.Enabled = false;
                    bairroTextBox.Enabled = false;
                    logradouroTextBox.Enabled = false;
                    numeroTextBox.Enabled = false;
                    referenciaTextBox.Enabled = false;
                    //Controle de botões (Criar classe para isso)
                    gravarButton.Visible = false;
                    cancelarButton.Visible = false;
                    voltarButton.Visible = true;
                    liberarButton.Visible = false;

                    this.Text = "Pessoa - Ativo";
                    }
                    else
                    {
                        if(status == "Vazio")
                        {
                            gravarButton.Visible = true;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = false;
                            liberarButton.Visible = false;
                        }
                    }
                }
            }
        }    
        
        public int buscarStatusRegistro()
        {
            int statusDoRegistro = 0;
            String query = "SELECT STATUS FROM PS_PESSOA WHERE HANDLE = " + buscarHandlePessoa();
            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                statusDoRegistro = Convert.ToInt32(reader["STATUS"]);
            }
            reader.Close();
            return statusDoRegistro;
        }







    }
}
