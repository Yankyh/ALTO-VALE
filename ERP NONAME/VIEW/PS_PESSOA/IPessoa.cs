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
            if (pessoaHandle == 0)
            {
                controleDeStatus();
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
            if ((validarCpfCnpjCadastrado() == true || buscarHandlePessoa() != 0))
            {
                //.Gravar o registro
                alterarRegistroPessoa("Gravar");
                controleDeStatus();
            }
        }

        //Metodos
        private void alterarRegistroPessoa(String situacao)
        {
            String apelido = "", razaoSocial = "", email = "", cpfCnpj = "", telefone = "", celular = "", observacao = "";
            int tipoPessoa = 0, cepSelecionadoHandle = 0;
            apelido = apelidoTextBox.Text;
            razaoSocial = razaoSocialTextBox.Text;
            email = emailTextBox.Text;
            cpfCnpj = cpfcnpjTextBox.Text;
            telefone = telefoneTextBox.Text;
            tipoPessoa = tipoPessoaHandle();
            celular = celularTextBox.Text;
            observacao = ObservacaoTextBox.Text;

            //Verifica se o registro já foi gravado alguma vez
            if (situacao == "Alterar")
            {
                //BOTAR O TIPO DA PESSOA
                String queryUpdate = "UPDATE PS_PESSOA SET STATUS = 3, APELIDO = '" + apelido + "', RAZAOSOCIAL = '" + razaoSocial + "'," +
                                     " EMAIL = '" + email + "', CPFCNPJ = '" + cpfCnpj + "', TIPO = " + tipoPessoaHandle() + ", " +
                                     " TELEFONE = '" + telefone + "', CELULAR = '" + celular + "', OBSERVACAO = '" + observacao + "'" +
                                     " WHERE HANDLE = " + buscarHandlePessoa();
                connection.Inserir(queryUpdate);
            }
            else
            {
                if (situacao == "Cancelar")
                {
                    String query = " UPDATE PS_PESSOA" +
                                   " SET STATUS = 4" +
                                   " WHERE HANDLE = " + buscarHandlePessoa();
                    connection.Inserir(query);
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
            controleDeStatus();
        }

        //Metodos de busca de handle
        private int tipoPessoaHandle()
        {
            int tipoPessoaHandle = 0;
            String tipoPessoaSelecionado = "";
            tipoPessoaSelecionado = tipoComboBox.SelectedItem.ToString();

            String query = "SELECT HANDLE FROM PS_PESSOATIPO WHERE NOME = '" + tipoPessoaSelecionado + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                tipoPessoaHandle = Convert.ToInt32((reader["HANDLE"]));
            }
            reader.Close();

            return tipoPessoaHandle;
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

            tipoPessoa = tipoPessoaHandle();

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
        }
        //Verifica se o CPF ou CNPJ já foi cadastrado
        private Boolean validarCpfCnpjCadastrado()
        {

            String cpfCnpj = "";
            cpfCnpj = cpfcnpjTextBox.Text;
            int count = 0;

            String query = "SELECT HANDLE FROM PS_PESSOA WHERE CPFCNPJ = '" + cpfCnpj + "'";
            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                count++;
            }
            if (count > 0)
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

        public void preencherFormulario(int handlePessoa)
        {
            //Preenche o combo box tipo
            preencherTipo();
            //Preenche os endereços
            PreencherEndereco();

            //Preenche o form com as informações da pessoa selecionada
            String apelido = "", razaoSocial = "", email = "", cpfCnpj = "", telefone = "", celular = "", observacao = "", tipo = "", situacao = "", cep = "";

            String query = " SELECT C.NOME SITUACAO, A.APELIDO, A.RAZAOSOCIAL, B.NOME TIPO, A.CPFCNPJ, A.TELEFONE, A.CELULAR, A.EMAIL, A.OBSERVACAO, D.CEP" +
                           " FROM PS_PESSOA A" +
                           " INNER JOIN PS_PESSOATIPO B ON B.HANDLE = A.TIPO" +
                           " INNER JOIN MD_STATUS C ON C.HANDLE = A.STATUS" +
                           " LEFT JOIN PS_PESSOAENDERECO D ON D.HANDLE = A.ENDERECO" +
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
            //Preenche o contato
            preencherContatoPessoa();

            controleDeStatus();
        }

        private void voltarButtonOnClick(object sender, EventArgs e)
        {

            if (buscarStatusRegistro() == 3 || buscarStatusRegistro() == 4)
            {
                //Altera o status
                String query1 = "UPDATE PS_PESSOA SET STATUS  = 2 WHERE HANDLE = " + buscarHandlePessoa();
                SqlDataReader reader = connection.Pesquisa(query1);
                reader.Close();
                controleDeStatus();
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
            if (buscarStatusRegistro() == 1 || buscarStatusRegistro() == 2)
            {
                String query = "UPDATE PS_PESSOA SET STATUS = 3 WHERE HANDLE = " + buscarHandlePessoa();
                SqlDataReader reader = connection.Pesquisa(query);
                reader.Close();
                //Grava o registro
                alterarRegistroPessoa("Alterar");
                controleDeStatus();
            }
            else
            {
                MessageBox.Show("O registro não pode estar em um status diferente de Cadastrado ou Ag. modificações para liberar o reigstro.");
            }

        }




        //Controle de status
        public void controleDeStatus()
        {
            String status = "";
            String query = " SELECT B.NOME" +
                           " FROM PS_PESSOA A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                           " WHERE A.HANDLE = " + buscarHandlePessoa();
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
                removerContatoButton.Visible = true;
                liberarButton.Location = new Point(770, 286);
                cancelarButton.Location = new Point(874, 286);
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
                        apelidoTextBox.Enabled = false;
                        razaoSocialTextBox.Enabled = false;
                        emailTextBox.Enabled = false;
                        tipoComboBox.Enabled = false;
                        cpfcnpjTextBox.Enabled = false;
                        telefoneTextBox.Enabled = false;
                        celularTextBox.Enabled = false;
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
                            apelidoTextBox.Enabled = false;
                            razaoSocialTextBox.Enabled = false;
                            emailTextBox.Enabled = false;
                            tipoComboBox.Enabled = false;
                            cpfcnpjTextBox.Enabled = false;
                            telefoneTextBox.Enabled = false;
                            celularTextBox.Enabled = false;
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
                            adicionarContatoButton.Visible = false;
                            removerContatoButton.Visible = false;
                        }
                    }
                }
                this.Text = "Pessoa - " + status;
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


        //Contato da pessoa
        private void preencherContatoPessoa()
        {
            BindingSource Binding = new BindingSource();
            contatoDataGridView.AutoGenerateColumns = true;
            String query = " SELECT E.NOME SITUAÇÃO, D.NOME TIPO, C.TELEFONE, C.CELULAR, C.EMAIL, C.OBSERVACAO, C.HANDLE" +
                           " FROM PS_PESSOA A" +
                           " INNER JOIN PS_PESSOACONTATOFK B ON B.PESSOA = A.HANDLE" +
                           " INNER JOIN PS_PESSOACONTATO C ON C.HANDLE = B.CONTATO" +
                           " INNER JOIN PS_PESSOACONTATOTIPO D ON D.HANDLE = C.TIPO" +
                           " INNER JOIN MD_STATUS E ON E.HANDLE = C.STATUS" +
                           " WHERE A.HANDLE = " + buscarHandlePessoa();
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
        private void PreencherEndereco()
        {
            BindingSource Binding = new BindingSource();
            enderecoDataGridView.AutoGenerateColumns = true;
            String query = " SELECT C.HANDLE, C.CEP, C.CIDADE, C.ESTADO, C.BAIRRO, C.LOGRADOURO, C.NUMERO, C.REFERENCIA" +
                           " FROM PS_PESSOA A" +
                           " INNER JOIN PS_PESSOAENDERECOFK B ON B.PESSOA = A.HANDLE" +
                           " INNER JOIN PS_PESSOAENDERECO C ON C.HANDLE = B.ENDERECO" +
                           " WHERE A.HANDLE = " + buscarHandlePessoa();
            Binding.DataSource = connection.DataTable(query);
            enderecoDataGridView.DataSource = Binding;
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
            //Passa o handle da pessoa pro contato
            IPessoaContato.pessoaHandle = buscarHandlePessoa();
            IPessoaContato iPessoaContato = new IPessoaContato();
            iPessoaContato.ShowDialog();
        }



        private void atualizarInformacoesDoFormulario(object sender, EventArgs e)
        {
            preencherContatoPessoa();
            PreencherEndereco();
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
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

        private void removerButtonOnClick(object sender, EventArgs e)
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
                MessageBox.Show("O registro deve estar cancelado para que possa ser exclúido.");
            }
            else
            {
                String query1 = " DELETE " +
                                " FROM PS_PESSOACONTATOFK" +
                                " WHERE CONTATO = " + pegarHandleContato();
                connection.Inserir(query1);
                String query2 = " DELETE" +
                                " FROM PS_PESSOACONTATO" +
                                " WHERE HANDLE = " + pegarHandleContato();
                connection.Inserir(query2);
                preencherContatoPessoa();
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
            alterarRegistroPessoa("Cancelar");
        }

        private void adicionarEnderecoButtonOnClick(object sender, EventArgs e)
        {
            IPessoaEndereco.handlePessoa = buscarHandlePessoa();
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

        private void EnderecoCellClick(object sender, DataGridViewCellEventArgs e)
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

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void adicionarArquivoButtonOnClick(object sender, EventArgs e)
        {
            IPessoaAnexo.handlePessoa = buscarHandlePessoa();
            IPessoaAnexo ipessoaAnexo = new IPessoaAnexo();
            ipessoaAnexo.ShowDialog();
        }

    }
}
