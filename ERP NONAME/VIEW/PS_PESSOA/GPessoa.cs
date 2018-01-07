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
using ALTO_VALE.VIEW;

namespace ALTO_VALE.VIEW.PS_PESSOA
{
    public partial class GPessoa : Form
    {
        Connection connection = new Connection();
        
        //Handle da pessoa selecionada
        public static int handlePessoa = 0;

        public GPessoa()
        {
            InitializeComponent();

            //Conecta com o Banco
            connection.Conectar();

            //Monta o dataGridView
            configurarDataGridView();
        }

        //Configurações do datagridview
        private void configurarDataGridView()
        {
            BindingSource Binding = new BindingSource();
            pessoaDataGridView.AutoGenerateColumns = true;
            String query = " SELECT B.NOME SITUAÇÃO, A.RAZAOSOCIAL AS 'RAZÃO SOCIAL', A.APELIDO, A.CPFCNPJ AS 'CPF/CNPJ', A.TELEFONE, C.CIDADE, D.SIGLA ESTADO, C.LOGRADOURO" +
                           " FROM PS_PESSOA A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS " +
                           " LEFT JOIN PS_PESSOAENDERECO C ON C.HANDLE = A.ENDERECO" +
                           " LEFT JOIN PS_ESTADO D ON D.HANDLE = C.ESTADO";
            Binding.DataSource = connection.DataTable(query);
            pessoaDataGridView.DataSource = Binding;

            pessoaDataGridView.Columns[0].Width = 150;
            pessoaDataGridView.Columns[1].Width = 300;
            pessoaDataGridView.Columns[2].Width = 300;
            pessoaDataGridView.Columns[3].Width = 150;
            pessoaDataGridView.Columns[4].Width = 130;
            pessoaDataGridView.Columns[7].Width = 230;

            pessoaDataGridView.AllowUserToResizeRows = false;
        }

        private void gPessoaClosed(object sender, FormClosedEventArgs e)
        {
            connection.Desconectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPessoa iPessoa = new IPessoa();
            iPessoa.ShowDialog();
        
        }

        private void GPessoa_Load(object sender, EventArgs e)
        {

        }
        //Abre a tela da pessoa pelo datagridview
        private void cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pega o cnpj ou cpf e passa para a função de busca no banco
            String cpfCnpjSelecionado = "";
            cpfCnpjSelecionado = pessoaDataGridView.CurrentRow.Cells[3].Value.ToString();
            //Chama a função de busca
            buscarHandlePessoa(cpfCnpjSelecionado);
            
        }

        //Busca o handle da pessoa clicada
        private void buscarHandlePessoa(String cpfCnpjSelecionado)
        {
            String query = "SELECT HANDLE FROM PS_PESSOA WHERE CPFCNPJ = '"+ cpfCnpjSelecionado + "'";
            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
               handlePessoa = Convert.ToInt32(reader["HANDLE"]);
            }
            reader.Close();

            //Envia para a outra tela o registro
            IPessoa.pessoaHandle = handlePessoa;
            IPessoa iPessoa = new IPessoa();
            iPessoa.ShowDialog();
        }

        //Toda vez que o focu volta ele atualiza
        private void pessoaOnActivated(object sender, EventArgs e)
        {
            configurarDataGridView();
        }
    }
}
