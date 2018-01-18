using ALTO_VALE.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTO_VALE.VIEW.TR_TAREFA
{
    public partial class GTarefa : Form
    {
        Connection connection = new Connection();
        public GTarefa()
        {
            InitializeComponent();
            connection.Conectar();
            PreencherTarefaDataGridView();
        }
        private void PreencherTarefaDataGridView()
        {
            BindingSource Binding = new BindingSource();
            tarefaDataGridView.AutoGenerateColumns = true;
            String query = " SELECT A.HANDLE, B.NOME ESTADO, A.DATA, A.PRAZO, C.LOGIN SOLICITANTE, D.LOGIN RESPONSAVEL, E.NOME SEVERIDADE, F.NOME AS SITUAÇÃO, G.NOME TIPO " +
                           " FROM TR_TAREFA A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                           " INNER JOIN PS_USUARIO C ON C.HANDLE = A.SOLICITANTE" +
                           " INNER JOIN PS_USUARIO D ON D.HANDLE = A.RESPONSAVEL" +
                           " INNER JOIN TR_TAREFASEVERIDADE E ON E.HANDLE = A.SEVERIDADE" +
                           " INNER JOIN TR_TAREFASITUACAO F ON F.HANDLE = A.SITUACAO" +
                           " INNER JOIN TR_TAREFATIPO G ON G.HANDLE = A.TIPO";
            Binding.DataSource = connection.DataTable(query);
            tarefaDataGridView.DataSource = Binding;

            tarefaDataGridView.Columns[0].Width = 0;
            tarefaDataGridView.Columns[0].Visible = false;
            tarefaDataGridView.Columns[1].Width = 150;
            tarefaDataGridView.Columns[2].Width = 150;
            tarefaDataGridView.Columns[3].Width = 150;
            tarefaDataGridView.Columns[4].Width = 150;
            tarefaDataGridView.Columns[5].Width = 150;
            tarefaDataGridView.Columns[6].Width = 150;
            tarefaDataGridView.Columns[7].Width = 150;

            tarefaDataGridView.AllowUserToResizeRows = false;
        }

        private void TarefaFormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Desconectar();
        }

        private void TarefaActivated(object sender, EventArgs e)
        {
            PreencherTarefaDataGridView();
        }

        private void adicionarButtonOnClick(object sender, EventArgs e)
        {
            ITarefa iTarefa = new ITarefa();
            iTarefa.ShowDialog();
        }

        private void TarefaCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ITarefa.handleTarefa = pegarHandleTarefa();
            ITarefa iTarefa = new ITarefa();
            iTarefa.ShowDialog();
        }
        private int pegarHandleTarefa()
        {
            //Pega o handle da tarefa para pesquisar
            int handleTarefa = 0;

            handleTarefa = Convert.ToInt32(tarefaDataGridView.CurrentRow.Cells[0].Value.ToString());

            return handleTarefa;
        }
    }
}
