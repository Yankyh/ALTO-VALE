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
using System.IO;
using ALTO_VALE.VIEW.MD_SISTEMA;

namespace ALTO_VALE.VIEW.PS_PESSOA
{
    public partial class IPessoa : Form
    {
        static int tipoPessoa = 0;

        Connection connection = new Connection();
        StatusFilter statusFilter = new StatusFilter();

        //Datagrid view binding
        BindingSource Binding = new BindingSource();
        BindingSource Binding1 = new BindingSource();
        BindingSource Binding2 = new BindingSource();

        //verifica se foi aberto pelo datagridview
        public static int pessoaHandle = 0;

        public IPessoa()
        {
            InitializeComponent();
            connection.Conectar();
            cpfcnpjTextBox.Enabled = false;

            //Preenche os combo box
            PreencherComboBoxTipo();

            if (pessoaHandle == 0)
            {
                ControleDeStatus();
            }
            else
            {
                preencherFormulario(pessoaHandle);
            }
        }

        private void gravarButtonOnClick(object sender, EventArgs e)
        {
            AlterarRegistro("Gravar");
        }

        //Metodos
        private void AlterarRegistro(String situacao)
        {
            String apelido = "", razaoSocial = "", email = "", cpfCnpj = "", telefone = "", celular = "", observacao = "";
            Boolean ehCliente = false, ehFornecedor = false, ehOrgaoPublico = false, ehFuncionario = false;
            int tipoPessoa = 0;
            apelido = apelidoTextBox.Text;
            razaoSocial = razaoSocialTextBox.Text;
            email = emailTextBox.Text;
            cpfCnpj = cpfcnpjTextBox.Text;
            telefone = telefoneTextBox.Text;
            tipoPessoa = BuscarHandleTipoPessoa();
            celular = celularTextBox.Text;
            observacao = ObservacaoTextBox.Text;
            //booleans
            ehCliente = ClienteCheckBox.Checked;
            ehFornecedor = fornecedorCheckBox.Checked;
            ehOrgaoPublico = orgaoPublicoCheckBox.Checked;
            ehFuncionario = funcionarioCheckBox.Checked;

            try
            {
                //Envia a situação para o verificador, pois, caso seja cadastro, o sistema não valida se existe endereço, somente na hora de liberar
                if (VerificaCamposObrigatorios(situacao) == true)
                {
                    if (situacao == "Liberar")
                    {
                        String query = "UPDATE PS_PESSOA SET STATUS = 3, APELIDO = '" + apelido + "', RAZAOSOCIAL = '" + razaoSocial + "'," +
                                             " EMAIL = '" + email + "', CPFCNPJ = '" + cpfCnpj + "', TIPO = " + tipoPessoa + ", " +
                                             " TELEFONE = '" + telefone + "', CELULAR = '" + celular + "', OBSERVACAO = '" + observacao + "'," +
                                             " EHCLIENTE = '" + ehCliente + "', EHFORNECEDOR = '" + ehFornecedor + "', EHORGAOPUBLICO = '" + ehOrgaoPublico + "', EHFUNCIONARIO = '" + ehFuncionario + "'" +
                                             " WHERE HANDLE = " + pessoaHandle;
                        connection.Inserir(query);
                        //Ativar Endereço
                        String query1 = " UPDATE PS_PESSOAENDERECO" +
                                        " SET STATUS = 3" +
                                        " WHERE PESSOA = " + pessoaHandle + "";
                        connection.Inserir(query1);

                        //Ativar Contato
                        String query2 = " UPDATE PS_PESSOACONTATO" +
                                        " SET STATUS = 3" +
                                        " WHERE PESSOA =  " + pessoaHandle + "";
                        connection.Inserir(query2);
                    }
                    else
                    {
                        if (situacao == "Gravar" && VerificaDuplicidadeCpfCnpj() == false)
                        {
                            String query = " INSERT INTO PS_PESSOA (STATUS, APELIDO, RAZAOSOCIAL, EMAIL,CPFCNPJSEMMASCARA, CPFCNPJ, TELEFONE, CELULAR, TIPO, OBSERVACAO, EHCLIENTE, EHFORNECEDOR, EHORGAOPUBLICO)" +
                                           " VALUES" +
                                           " ( " + 1 + "," +
                                           "'" + apelido + "'," +
                                           "'" + razaoSocial + "'," +
                                           "'" + email + "'," +
                                           "'" + cpfCnpj.Replace(".", "").Replace("-", "").Replace("/", "") + "'," +
                                           "'" + cpfCnpj + "', " +
                                           "'" + telefone + "', " +
                                           "'" + celular + "', " +
                                           "'" + tipoPessoa + "', " +
                                           "'" + observacao + "'," +
                                           "'" + ehCliente + "', " +
                                           "'" + ehFornecedor + "',  " +
                                           "'" + ehOrgaoPublico + "')";
                            connection.Inserir(query);

                            String query1 = " SELECT MAX(HANDLE) HANDLE" +
                                            " FROM PS_PESSOA" +
                                            " WHERE CPFCNPJ = '" + cpfCnpj + "'";
                            SqlDataReader reader = connection.Pesquisa(query1);
                            while (reader.Read())
                            {
                                pessoaHandle = Convert.ToInt32(reader["HANDLE"]);
                            }
                            reader.Close();
                        }
                    }
                }
                if (situacao == "Cancelar")
                {
                    String query = " UPDATE PS_PESSOA" +
                                   " SET STATUS = 4" +
                                   " WHERE HANDLE = " + pessoaHandle;
                    connection.Inserir(query);
                    //Cancelar Endereço
                    String query1 = " UPDATE PS_PESSOAENDERECO" +
                                    " SET STATUS = 4" +
                                    " WHERE PESSOA = " + pessoaHandle + "";
                    connection.Inserir(query1);

                    //Cancelar Contato
                    String query2 = " UPDATE PS_PESSOACONTATO" +
                                    " SET STATUS = 4" +
                                    " WHERE PESSOA = " + pessoaHandle + "";
                    connection.Inserir(query2);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            ControleDeStatus();
            AtualizarInformacoesDoFormulario();
        }

        //Metodos de busca de handle
        private int BuscarHandleTipoPessoa()
        {
            int BuscarHandleTipoPessoa = 0;
            String tipoPessoaSelecionado = "";

            try
            {
                tipoPessoaSelecionado = tipoComboBox.SelectedItem.ToString();

                String query = "SELECT HANDLE FROM PS_PESSOATIPO WHERE NOME = '" + tipoPessoaSelecionado + "'";
                SqlDataReader reader = connection.Pesquisa(query);

                while (reader.Read())
                {
                    BuscarHandleTipoPessoa = Convert.ToInt32((reader["HANDLE"]));
                }
                reader.Close();
            }
            catch
            {
                //Faz nada
            }

            return BuscarHandleTipoPessoa;
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
        private void PreencherComboBoxTipo()
        {
            //Limpa a combo box
            tipoComboBox.Items.Clear();

            //Lista os tipos
            String query = "SELECT NOME FROM PS_PESSOATIPO";

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

            tipoPessoa = BuscarHandleTipoPessoa();

            if (tipoPessoa == 1)
            {
                cpfcnpjTextBox.Text = Convert.ToUInt64(cpfcnpjTextBox.Text).ToString(@"000\.000\.000\-00");
            }
            else
            {
                if (tipoPessoa == 2)
                {

                }
            }
            return false;
        }



        private void tipoDropClosed(object sender, EventArgs e)
        {
            cpfcnpjTextBox.Text = "";
            if (tipoComboBox.SelectedIndex == -1)
            {
                cpfcnpjTextBox.Enabled = false;
            }
            else
            {
                cpfcnpjTextBox.Enabled = true;
            }
            tipoPessoa = BuscarHandleTipoPessoa();
        }
        //Verifica se o CPF ou CNPJ já foi cadastrado
        private Boolean VerificaDuplicidadeCpfCnpj()
        {
            String cpfCnpj = "", razaoSocial = "";
            Boolean existeCpfCnpj = false;
            cpfCnpj = cpfcnpjTextBox.Text;


            String query = "SELECT CPFCNPJ, RAZAOSOCIAL FROM PS_PESSOA WHERE CPFCNPJ = '" + cpfCnpj + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            existeCpfCnpj = reader.HasRows;

            if (existeCpfCnpj == true)
            {
                while (reader.Read())
                {
                    cpfCnpj = reader["CPFCNPJ"].ToString();
                    razaoSocial = reader["RAZAOSOCIAL"].ToString();
                    MessageBox.Show("O CPF/CNPJ '" + cpfCnpj + "' já está cadastrado para a pessoa " + razaoSocial);
                }
            }
            reader.Close();
            return existeCpfCnpj;
        }

        //Metodo para encerrar a conexão ao fechar o form
        private void IPessoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Desconectar();
            pessoaHandle = 0;
        }

        public void preencherFormulario(int handlePessoa)
        {
            //Preenche o combo box tipo
            PreencherComboBoxTipo();
            //Preenche os endereços
            PreencherDataGridViewEndereco();
            PreencherDataGridViewAnexo();

            //Preenche o form com as informações da pessoa selecionada
            String apelido = "", razaoSocial = "", email = "", cpfCnpj = "", telefone = "", celular = "", observacao = "", tipo = "", situacao = "";
            //Abrangencia
            String ehFuncionario = "", ehFornecedor = "", ehOrgaoPublico = "", ehCliente = "";

            String query = " SELECT C.NOME SITUACAO, A.APELIDO, A.RAZAOSOCIAL, B.NOME TIPO, A.CPFCNPJ, A.TELEFONE, A.CELULAR, A.EMAIL, A.OBSERVACAO,  A.EHCLIENTE, A.EHFUNCIONARIO, A.EHFORNECEDOR, A.EHORGAOPUBLICO" +
                           " FROM PS_PESSOA A" +
                           " INNER JOIN PS_PESSOATIPO B ON B.HANDLE = A.TIPO" +
                           " INNER JOIN MD_STATUS C ON C.HANDLE = A.STATUS" +
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

                //Abrangencia
                ehCliente = (reader["EHCLIENTE"].ToString());
                ehFuncionario = (reader["EHFUNCIONARIO"].ToString());
                ehOrgaoPublico = (reader["EHORGAOPUBLICO"].ToString());
                ehFornecedor = (reader["EHFORNECEDOR"].ToString());
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
            //Preenche a abrangência
            ClienteCheckBox.Checked = VerificaFlags(ehCliente);
            funcionarioCheckBox.Checked = VerificaFlags(ehFuncionario);
            fornecedorCheckBox.Checked = VerificaFlags(ehFornecedor);
            orgaoPublicoCheckBox.Checked = VerificaFlags(ehOrgaoPublico);
            //Preenche o contato
            PreencherDataGridViewContato();

            ControleDeStatus();
        }
        private Boolean VerificaFlags(String texto)
        {
            if (texto == "True")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void voltarButtonOnClick(object sender, EventArgs e)
        {

            if (buscarStatusRegistro() == 3 || buscarStatusRegistro() == 4)
            {
                //Altera o status
                String query1 = "UPDATE PS_PESSOA SET STATUS  = 2 WHERE HANDLE = " + pessoaHandle;
                SqlDataReader reader = connection.Pesquisa(query1);
                reader.Close();
                ControleDeStatus();
            }
            else
            {
                MessageBox.Show("Para voltar o registro, a situação deve ser ativo.");
            }

        }



        private void liberarButtonOnClick(object sender, EventArgs e)
        {
            //Altera o status
            if (buscarStatusRegistro() == 1 || buscarStatusRegistro() == 2)
            {
                //Grava o registro
                AlterarRegistro("Liberar");
            }
            else
            {
                MessageBox.Show("O registro não pode estar em um status diferente de Cadastrado ou Ag. modificações para liberar o reigstro.");
            }

        }
        //Controle de status
        public void ControleDeStatus()
        {
            String status = "";
            String query = " SELECT B.NOME" +
                           " FROM PS_PESSOA A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                           " WHERE A.HANDLE = " + pessoaHandle;
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
                adicionarContatoButton.Visible = true;
                adicionarArquivoButton.Visible = true;
                adicionarEnderecoButton.Visible = true;
                removerContatoButton.Visible = true;
                removerEnderecoButton.Visible = true;
                liberarButton.Location = new Point(767, 271);
                cancelarButton.Location = new Point(871, 271);
            }
            else
            {
                if (status == "Ag. modificações")
                {
                    //Controle de status
                    apelidoTextBox.ReadOnly = false;
                    razaoSocialTextBox.ReadOnly = false;
                    emailTextBox.ReadOnly = false;
                    tipoComboBox.Enabled = true;
                    cpfcnpjTextBox.ReadOnly = false;
                    telefoneTextBox.ReadOnly = false;
                    celularTextBox.ReadOnly = false;
                    ObservacaoTextBox.ReadOnly = false;
                    //Tabpage abrangencia
                    ClienteCheckBox.Enabled = true;
                    fornecedorCheckBox.Enabled = true;
                    orgaoPublicoCheckBox.Enabled = true;
                    funcionarioCheckBox.Enabled = true;

                    //Controle de botões (Criar classe para isso)
                    liberarButton.Visible = true;
                    cancelarButton.Visible = true;
                    voltarButton.Visible = false;
                    adicionarArquivoButton.Visible = true;
                    adicionarContatoButton.Visible = true;
                    adicionarEnderecoButton.Visible = true;
                    removerContatoButton.Visible = true;
                    removerEnderecoButton.Visible = true;
                    gravarButton.Visible = false;
                    liberarButton.Location = new Point(767, 271);
                    cancelarButton.Location = new Point(871, 271);
                }
                else
                {
                    if (status == "Ativo")
                    {
                        //Caso esteja ativo, não permite alterar antes de voltar o registro
                        apelidoTextBox.ReadOnly = true;
                        razaoSocialTextBox.ReadOnly = true;
                        emailTextBox.ReadOnly = true;
                        tipoComboBox.Enabled = false;
                        cpfcnpjTextBox.ReadOnly = true;
                        telefoneTextBox.ReadOnly = true;
                        celularTextBox.ReadOnly = true;
                        ObservacaoTextBox.ReadOnly = true;
                        //Tabpage abrangencia
                        ClienteCheckBox.Enabled = false;
                        fornecedorCheckBox.Enabled = false;
                        orgaoPublicoCheckBox.Enabled = false;
                        funcionarioCheckBox.Enabled = false;
                        //Controle de botões (Criar classe para isso)
                        gravarButton.Visible = false;
                        cancelarButton.Visible = false;
                        voltarButton.Visible = true;
                        adicionarArquivoButton.Visible = true;
                        adicionarContatoButton.Visible = true;
                        adicionarEnderecoButton.Visible = true;
                        removerContatoButton.Visible = true;
                        removerEnderecoButton.Visible = true;
                        liberarButton.Visible = false;
                        voltarButton.Location = new Point(871, 271);
                    }
                    else
                    {
                        if (status == "Cancelado")
                        {
                            //Caso esteja cancelado, não permite alterar antes de voltar o registro
                            apelidoTextBox.ReadOnly = true;
                            razaoSocialTextBox.ReadOnly = true;
                            emailTextBox.ReadOnly = true;
                            tipoComboBox.Enabled = false;
                            cpfcnpjTextBox.ReadOnly = true;
                            telefoneTextBox.ReadOnly = true;
                            celularTextBox.ReadOnly = true;
                            ObservacaoTextBox.ReadOnly = true;
                            //Tabpage abrangencia
                            ClienteCheckBox.Enabled = false;
                            fornecedorCheckBox.Enabled = false;
                            orgaoPublicoCheckBox.Enabled = false;
                            funcionarioCheckBox.Enabled = false;
                            //Controle de botões (Criar classe para isso)
                            gravarButton.Visible = false;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = true;
                            liberarButton.Visible = false;
                            adicionarArquivoButton.Visible = false;
                            adicionarContatoButton.Visible = false;
                            adicionarEnderecoButton.Visible = false;
                            removerContatoButton.Visible = false;
                            removerEnderecoButton.Visible = false;
                            voltarButton.Location = new Point(871, 271);
                        }
                        else
                        {
                            gravarButton.Visible = true;
                            cancelarButton.Visible = false;
                            voltarButton.Visible = false;
                            liberarButton.Visible = false;
                            adicionarArquivoButton.Visible = false;
                            adicionarContatoButton.Visible = false;
                            adicionarEnderecoButton.Visible = false;
                            removerContatoButton.Visible = false;
                            removerEnderecoButton.Visible = false;
                            gravarButton.Location = new Point(871, 271);
                            adicionarContatoButton.Visible = false;
                            removerContatoButton.Visible = false;
                        }
                    }
                }

            }
            this.Text = "Pessoa - " + status;
        }

        public int buscarStatusRegistro()
        {
            int statusDoRegistro = 0;
            String query = "SELECT STATUS FROM PS_PESSOA WHERE HANDLE = " + pessoaHandle;
            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                statusDoRegistro = Convert.ToInt32(reader["STATUS"]);
            }
            reader.Close();
            return statusDoRegistro;
        }


        //Contato da pessoa
        private void PreencherDataGridViewContato()
        {
            contatoDataGridView.AutoGenerateColumns = true;
            String query = " SELECT E.NOME SITUAÇÃO, D.NOME TIPO, C.TELEFONE, C.CELULAR, C.EMAIL, C.OBSERVACAO, C.HANDLE" +
                           " FROM PS_PESSOA A" +
                           " INNER JOIN PS_PESSOACONTATO C ON C.PESSOA = A.HANDLE" +
                           " INNER JOIN PS_PESSOACONTATOTIPO D ON D.HANDLE = C.TIPO" +
                           " INNER JOIN MD_STATUS E ON E.HANDLE = C.STATUS" +
                           " WHERE A.HANDLE = " + pessoaHandle;
            Binding.DataSource = connection.DataTable(query);

            contatoDataGridView.DataSource = Binding;
            contatoDataGridView.Columns[0].Width = 100;
            contatoDataGridView.Columns[1].Width = 150;
            contatoDataGridView.Columns[2].Width = 150;
            contatoDataGridView.Columns[3].Width = 150;
            contatoDataGridView.Columns[4].Width = 150;
            contatoDataGridView.Columns[5].Width = 250;
            contatoDataGridView.Columns[6].Visible = false;
            contatoDataGridView.AllowUserToResizeRows = false;
        }
        //Preencher endereço da pessoa
        private void PreencherDataGridViewEndereco()
        {
            String query = " SELECT C.HANDLE, D.NOME SITUAÇÃO, C.CEP, C.CIDADE, E.NOME ESTADO, C.BAIRRO, C.LOGRADOURO, C.NUMERO, C.REFERENCIA" +
                           " FROM PS_PESSOA A" +
                           " INNER JOIN PS_PESSOAENDERECO C ON C.PESSOA = A.HANDLE" +
                           " INNER JOIN MD_STATUS D ON D.HANDLE = C.STATUS" +
                           " INNER JOIN MD_ESTADO E ON E.HANDLE = C.ESTADO" +
                           " WHERE A.HANDLE = " + pessoaHandle;
            Binding1.DataSource = connection.DataTable(query);
            enderecoDataGridView.DataSource = Binding1;
            enderecoDataGridView.Columns[7].Width = 150;
            enderecoDataGridView.Columns[1].Width = 150;
            enderecoDataGridView.Columns[2].Width = 150;
            enderecoDataGridView.Columns[3].Width = 150;
            enderecoDataGridView.Columns[4].Width = 200;
            enderecoDataGridView.Columns[6].Width = 300;
            enderecoDataGridView.Columns[0].Visible = false;
            enderecoDataGridView.AllowUserToResizeRows = false;
        }
        //Botão adicionar dos contatos
        private void adicionarButtonOnClick(object sender, EventArgs e)
        {
            IPessoaContato iPessoaContato = new IPessoaContato();
            iPessoaContato.ShowDialog();
        }



        private void AtualizarInformacoesDoFormulario()
        {
            PreencherDataGridViewContato();
            PreencherDataGridViewEndereco();
            PreencherDataGridViewAnexo();
        }

        private void removerContatoButtonOnClick(object sender, EventArgs e)
        {
            DialogResult confirmacaoButton = MessageBox.Show("Deseja Continuar?", "Excluir Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmacaoButton.ToString().ToUpper() == "YES")
            {
                String status = "";
                String query = " SELECT B.NOME" +
                               " FROM PS_PESSOACONTATO A" +
                               " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                               " WHERE A.HANDLE = " + pegarHandleContato();
                SqlDataReader reader = connection.Pesquisa(query);
                while (reader.Read())
                {
                    status = reader["NOME"].ToString();
                }
                reader.Close();
                if (status != "Cancelado")
                {
                    MessageBox.Show("O registro deve estar cancelado para que possa ser excluído.");
                }
                else
                {
                    String query2 = " DELETE" +
                                    " FROM PS_PESSOACONTATO" +
                                    " WHERE HANDLE = " + pegarHandleContato();
                    connection.Inserir(query2);
                    PreencherDataGridViewContato();
                }
            }
        }

        private int pegarHandleContato()
        {
            //Pega o handle do contato para pesquisar
            int contatoHandle = 0;

            contatoHandle = Convert.ToInt32(contatoDataGridView.CurrentRow.Cells[6].Value.ToString());

            return contatoHandle;
        }

        private void cancelarButtonOnClick(object sender, EventArgs e)
        {
            DialogResult confirmacaoButton = MessageBox.Show("Deseja Continuar?", "Cancelar pessoa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmacaoButton.ToString().ToUpper() == "YES")
            {
                AlterarRegistro("Cancelar");
            }
        }

        private void adicionarEnderecoButtonOnClick(object sender, EventArgs e)
        {
            IPessoaEndereco.handlePessoa = pessoaHandle;
            IPessoaEndereco iPessoaEndereco = new IPessoaEndereco();
            iPessoaEndereco.ShowDialog();
        }
        private int PegarHandleEndereco()
        {
            int enderecoHandle = 0;

            try
            {
                enderecoHandle = Convert.ToInt32(enderecoDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {

            }
            return enderecoHandle;
        }



        private void adicionarArquivoButtonOnClick(object sender, EventArgs e)
        {
            IAnexoPadrao.handleTabelaOrigem = 3;
            IAnexoPadrao.handleOrigem = pessoaHandle;
            IAnexoPadrao iAnexoPadrao = new IAnexoPadrao();
            iAnexoPadrao.ShowDialog();
        }


        //Preencher a tabela de anexo
        private void PreencherDataGridViewAnexo()
        {
            String query = " SELECT A.HANDLE, A.DESCRICAO DESCRIÇÃO, A.NOMEARQUIVO NOME, A.CAMINHO" +
                           " FROM MD_ANEXO A" +
                           " INNER JOIN PS_PESSOA B ON B.HANDLE = A.HANDLEORIGEM" +
                           " WHERE B.HANDLE = " + pessoaHandle;
            Binding2.DataSource = connection.DataTable(query);
            anexoDataGridView.DataSource = Binding2;
            anexoDataGridView.Columns[0].Visible = false;
            anexoDataGridView.Columns[1].Width = 200;
            anexoDataGridView.Columns[2].Width = 200;
            anexoDataGridView.Columns[3].Width = 600;
            anexoDataGridView.AllowUserToResizeRows = false;
        }

        private void anexoDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            IAnexoPadrao.handleAnexo = PegarHandleAnexo();
            IAnexoPadrao iAnexoPadrao = new IAnexoPadrao();
            iAnexoPadrao.ShowDialog();
        }
        private int PegarHandleAnexo()
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
        private void removerEnderecoButtonOnClick(object sender, EventArgs e)
        {
            DialogResult confirmacaoButton = MessageBox.Show("Deseja Continuar?", "Excluir Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmacaoButton.ToString().ToUpper() == "YES")
            {
                String status = "";
                String query = " SELECT B.NOME" +
                               " FROM PS_PESSOAENDERECO A" +
                               " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                               " WHERE A.HANDLE = " + PegarHandleEndereco();
                SqlDataReader reader = connection.Pesquisa(query);
                while (reader.Read())
                {
                    status = reader["NOME"].ToString();
                }
                reader.Close();
                if (status != "Cancelado")
                {
                    MessageBox.Show("O registro deve estar cancelado para que possa ser excluído.");
                }
                else
                {
                    String query2 = " DELETE" +
                                    " FROM PS_PESSOAENDERECO" +
                                    " WHERE HANDLE = " + PegarHandleEndereco();
                    connection.Inserir(query2);
                    PreencherDataGridViewEndereco();
                }
            }
        }

        private void cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pegarHandleContato() == 0)
            {

            }
            else
            {
                IPessoaContato.contatoHandle = pegarHandleContato();
                IPessoaContato iPessoaContato = new IPessoaContato();
                iPessoaContato.ShowDialog();
            }
        }

        private void EnderecoCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PegarHandleEndereco() == 0)
            {

            }
            else
            {
                IPessoaEndereco.handleEndereco = PegarHandleEndereco();
                IPessoaEndereco iPessoaEndereco = new IPessoaEndereco();
                iPessoaEndereco.ShowDialog();
            }
        }

        //Verfica campos obrigatórios
        private Boolean VerificaCamposObrigatorios(String situacao)
        {
            try
            {
                if (razaoSocialTextBox.Text != "")
                {
                    if (apelidoTextBox.Text != "")
                    {
                        if (tipoComboBox.SelectedIndex > -1)
                        {
                            if (cpfcnpjTextBox.Text != "")
                            {
                                if (VerificaSeExisteUmaAbrangenciaSelecionada() == true)
                                {
                                    if (VerificaSeExisteUmEndereco() == true || situacao == "Gravar")
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("É necessário adicionar pelo menos um endereço ao cadastro da pessoa.");
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("É necessário selecionar pelo menos uma abrangência.");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("O campo cpf/cnpj é obrigatório.");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("O campo tipo é obrigatório.");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("O campo apelido é obrigatório.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("O campo razão social é obrigatório.");
                    return false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                return false;
            }
        }

        private Boolean VerificaSeExisteUmaAbrangenciaSelecionada()
        {
            if (ClienteCheckBox.Checked == true || fornecedorCheckBox.Checked == true || orgaoPublicoCheckBox.Checked == true || funcionarioCheckBox.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean VerificaSeExisteUmEndereco()
        {
            Boolean existeEndereco = false;
            String query = " SELECT A.HANDLE" +
                           " FROM PS_PESSOA A" +
                           " INNER JOIN PS_PESSOAENDERECO B ON B.PESSOA = A.HANDLE" +
                           " WHERE A.HANDLE = " + pessoaHandle;
            SqlDataReader reader = connection.Pesquisa(query);
            existeEndereco = reader.HasRows;
            reader.Close();

            return existeEndereco;
        }

        private void PessoaOnActivated(object sender, EventArgs e)
        {
            PreencherDataGridViewAnexo();
            PreencherDataGridViewContato();
            PreencherDataGridViewEndereco();
        }

        private void TipoComboBoxOnFocusLeave(object sender, EventArgs e)
        {
            Boolean itemExiste = false;
            try
            {
                foreach (var item in tipoComboBox.Items)
                {
                    if (tipoComboBox.SelectedItem == item)
                    {
                        itemExiste = true;
                    }
                }
                if (itemExiste == false)
                {
                    tipoComboBox.Text = "";
                }
            }
            catch
            {

            }
        }
    }
}
