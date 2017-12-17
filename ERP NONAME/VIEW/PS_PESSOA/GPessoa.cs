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

namespace ALTO_VALE.VIEW.PS_PESSOA
{
    public partial class GPessoa : Form
    {
        Connection connection = new Connection();
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
            String query = " SELECT B.NOME SITUAÇÃO, A.APELIDO, A.RAZAOSOCIAL AS 'RAZÃO SOCIAL', A.CPFCNPJ AS 'CPF/CNPJ', A.TELEFONE, C.CIDADE, D.SIGLA ESTADO, C.LOGRADOURO" +
                           " FROM PS_PESSOA A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS " +
                           " INNER JOIN PS_PESSOAENDERECO C ON C.HANDLE = A.ENDERECO" +
                           " INNER JOIN PS_ESTADO D ON D.HANDLE = C.ESTADO";
            Binding.DataSource = connection.DataTable(query);
            pessoaDataGridView.DataSource = Binding;

            pessoaDataGridView.Columns[0].Width = 100;
            pessoaDataGridView.Columns[1].Width = 180;
            pessoaDataGridView.Columns[2].Width = 180;
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
    }
}
