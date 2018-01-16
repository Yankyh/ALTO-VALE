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

namespace ALTO_VALE.VIEW.MD_SISTEMA
{
    public partial class GCep : Form
    {
        Connection connection = new Connection();

        public GCep()
        {
            InitializeComponent();
            connection.Conectar();
            preencherDataGridView();
        }

        //Preenche o datagridview
        private void preencherDataGridView()
        {
            BindingSource Binding = new BindingSource();
            cepDataGridView.AutoGenerateColumns = true;
            String query = " SELECT B.NOME, A.CEP, A.PAIS, A.ESTADO, A.CIDADE, A.BAIRRO, A.LOGRADOURO, A.HANDLE" +
                           " FROM MD_CEP A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS";
            Binding.DataSource = connection.DataTable(query);
            cepDataGridView.DataSource = Binding;

            cepDataGridView.Columns[0].Width = 150;
            cepDataGridView.Columns[1].Width = 150;
            cepDataGridView.Columns[2].Width = 150;
            cepDataGridView.Columns[3].Width = 150;
            cepDataGridView.Columns[4].Width = 200;
            cepDataGridView.Columns[6].Width = 300;
            cepDataGridView.Columns[7].Visible = false;
            cepDataGridView.AllowUserToResizeRows = false;
        }

        private void cellClickOnClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pega cep e passa para a função de busca no banco
            String cepSelecionado = "";
            cepSelecionado = cepDataGridView.CurrentRow.Cells[7].Value.ToString();
            if(cepSelecionado != "")
            {
                try
                {
                    ICep.cepHandle = Convert.ToInt32(cepSelecionado);
                    ICep iCep = new ICep();
                    iCep.ShowDialog();
                }
                catch
                {

                }
            }
        }




        //Controle de status
        private void ControleDeStatus()
        {

        }

        private void adicionarButtonOnClick(object sender, EventArgs e)
        {
            ICep iCep = new ICep();
            iCep.ShowDialog();
        }

        private void OnActivated(object sender, EventArgs e)
        {
            preencherDataGridView();
        }

        private void cepDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //teste 123
        }
    }
}
