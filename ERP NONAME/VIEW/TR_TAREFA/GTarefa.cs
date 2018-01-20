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
        BindingSource Binding = new BindingSource();
        Connection connection = new Connection();
        public GTarefa()
        {
            InitializeComponent();
            connection.Conectar();
            PreencherTarefaDataGridView();
        }
        private void PreencherTarefaDataGridView()
        {
            //Filtro de baiano
            String status = "1, 2, 3";

            if(ehEncerradoCheckBox.Checked == true)
            {
                status = status + ", 5 ";
            }
            if(ehCanceladoCheckBox.Checked == true)
            {
                status = status + ", 4 ";
            }
            tarefaDataGridView.AutoGenerateColumns = true;
            String query = " SELECT A.HANDLE, B.IMAGEM STA, F.NOME SITUAÇÃO, E.NOME SEVERIDADE, G.NOME TIPO, A.PRAZO, A.ASSUNTO, C.LOGIN SOLICITANTE, D.LOGIN RESPONSAVEL, A.DATA " +
                           " FROM TR_TAREFA A" +
                           " INNER JOIN MD_STATUS B ON B.HANDLE = A.STATUS" +
                           " INNER JOIN PS_USUARIO C ON C.HANDLE = A.SOLICITANTE" +
                           " INNER JOIN PS_USUARIO D ON D.HANDLE = A.RESPONSAVEL" +
                           " INNER JOIN TR_TAREFASEVERIDADE E ON E.HANDLE = A.SEVERIDADE" +
                           " INNER JOIN TR_TAREFASITUACAO F ON F.HANDLE = A.SITUACAO" +
                           " INNER JOIN TR_TAREFATIPO G ON G.HANDLE = A.TIPO" +
                           " WHERE A.STATUS IN ("+status+")";
            Binding.DataSource = connection.DataTable(query);
            tarefaDataGridView.DataSource = Binding;

            tarefaDataGridView.Columns[0].Width = 0;
            tarefaDataGridView.Columns[0].Visible = false;
            tarefaDataGridView.Columns[1].Width = 50;
            tarefaDataGridView.Columns[2].Width = 120;
            tarefaDataGridView.Columns[3].Width = 120;
            tarefaDataGridView.Columns[4].Width = 150;
            tarefaDataGridView.Columns[5].Width = 150;
            tarefaDataGridView.Columns[6].Width = 850;
            tarefaDataGridView.Columns[7].Width = 120;
            tarefaDataGridView.Columns[8].Width = 130;
            tarefaDataGridView.Columns[9].Width = 150;

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

        private void AtualizarButtonOnClick(object sender, EventArgs e)
        {
            PreencherTarefaDataGridView();
        }

    }
}
