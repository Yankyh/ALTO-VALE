using ALTO_VALE.DAL;
using ALTO_VALE.TN_TECNOLOGIA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTO_VALE.VIEW.TR_TAREFA
{
    public partial class ITarefaEncaminhamento : Form
    {
        public static int handleTarefa = 0, handleEncaminhamento = 0;

        Connection connection = new Connection();
        public ITarefaEncaminhamento()
        {
            InitializeComponent();
            connection.Conectar();
            if (handleEncaminhamento != 0)
            {
                PreencherFormulario(handleEncaminhamento);
            }
            PreencherComboBoxTipoEncaminhamento();
            PreencherComboBoxResponsavel();
            PreencherComboBoxSeveridade();
            PreencherComboBoxSituacao();
            PreencherComboBoxTipo();
        }

        private void PreencherFormulario(int handleEncaminhamento)
        {

        }


        //Metódos que preenchem os combo box's
        private void PreencherComboBoxTipoEncaminhamento()
        {
            //Limpa a combo box
            tipoEncaminhamentoComboBox.Items.Clear();
            String query = " SELECT A.NOME" +
                           " FROM TR_TAREFAENCAMINHAMENTOTIPO A" +
                           " WHERE A.STATUS = 3";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                tipoEncaminhamentoComboBox.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();
        }
        private void PreencherComboBoxResponsavel()
        {
            //Limpa a combo box
            responsavelComboBox.Items.Clear();
            String query = " SELECT A.LOGIN" +
                           " FROM PS_USUARIO A" +
                           " WHERE A.STATUS = 3";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                responsavelComboBox.Items.Add((reader["LOGIN"].ToString()));
            }
            reader.Close();
        }
        private void PreencherComboBoxTipo()
        {
            //Limpa a combo box
            tipoComboBox.Items.Clear();
            String query = " SELECT A.NOME" +
                           " FROM TR_TAREFATIPO A";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                tipoComboBox.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();
        }
        private void PreencherComboBoxSeveridade()
        {
            //Limpa a combo box
            severidadeComboBox.Items.Clear();
            String query = " SELECT A.NOME" +
                           " FROM TR_TAREFASEVERIDADE A" +
                           " ORDER BY A.PRIORIDADE ASC";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                severidadeComboBox.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();
        }
        private void PreencherComboBoxSituacao()
        {
            //Limpa a combo box
            situacaoComboBox.Items.Clear();
            String query = " SELECT A.NOME" +
                           " FROM TR_TAREFASITUACAO A";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                situacaoComboBox.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();
        }

        private void ResponsavelOnKeyPress(object sender, KeyEventArgs e)
        {

        }

        private void TipoEncaminhamentoIndexChanged(object sender, EventArgs e)
        {
            try
            {
                responsavelComboBox.SelectedIndex = -1;
                situacaoComboBox.SelectedIndex = -1;
                tipoComboBox.SelectedIndex = -1;
                severidadeComboBox.SelectedIndex = -1;
                if (tipoEncaminhamentoComboBox.SelectedItem.ToString() == "Alterar severidade")
                {
                    responsavelComboBox.Enabled = false;
                    situacaoComboBox.Enabled = false;
                    tipoComboBox.Enabled = false;
                    severidadeComboBox.Enabled = true;
                }
                else
                {
                    if (tipoEncaminhamentoComboBox.SelectedItem.ToString() == "Alterar responsável")
                    {
                        responsavelComboBox.Enabled = true;
                        situacaoComboBox.Enabled = false;
                        tipoComboBox.Enabled = false;
                        severidadeComboBox.Enabled = false;
                    }
                    else
                    {
                        if (tipoEncaminhamentoComboBox.SelectedItem.ToString() == "Alterar situação")
                        {
                            responsavelComboBox.Enabled = false;
                            situacaoComboBox.Enabled = true;
                            tipoComboBox.Enabled = false;
                            severidadeComboBox.Enabled = false;
                        }
                        else
                        {
                            if (tipoEncaminhamentoComboBox.SelectedItem.ToString() == "Alterar tipo")
                            {
                                responsavelComboBox.Enabled = false;
                                situacaoComboBox.Enabled = false;
                                tipoComboBox.Enabled = true;
                                severidadeComboBox.Enabled = false;
                            }
                        }
                    }
                }

            }
            catch
            {

            }

        }

        //
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            handleTarefa = 0;
            connection.Desconectar();
        }
    }
}
