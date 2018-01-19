using ALTO_VALE.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTO_VALE.VIEW.TR_TAREFA
{
    public partial class ITarefaAnexo : Form
    {
        public static int handleTarefa = 0, handleAnexo = 0;
        String nomeArquivo = "";
        Connection connection = new Connection();
        public ITarefaAnexo()
        {
            InitializeComponent();
            connection.Conectar();
            if(handleAnexo != 0)
            {
                PreencherFormulario();
            }
        }

        private void gravarButtonOnClick(object sender, EventArgs e)
        {
            if (caminhoAnexoTextBox.Text != "")
            {
                gravarAnexo(caminhoAnexoTextBox.Text, CSistema.diretorioPadrao, nomeArquivo);
            }
            else
            {
                MessageBox.Show("Selecione um arquivo para salvar.");
            }
        }

        private void gravarAnexo(String dirInic, String dirDest, String nomeArquivo)
        {
            try
            {
                File.Copy(@dirInic, @dirDest + "\\" + nomeArquivo, true);
                GravarRegistro("Gravar");
            }
            catch (Exception ThisException)
            {
                MessageBox.Show(ThisException.ToString());
            }
        }



        private void GravarRegistro(String acao)
        {
            if (acao == "Gravar")
            {
                String descricao = "", caminho = "", diretorioPadrao = "";

                descricao = descricaoTextBox.Text;
                caminho = caminhoAnexoTextBox.Text;
                diretorioPadrao = CSistema.diretorioPadrao;

                String query = " INSERT INTO TR_TAREFAANEXO" +
                               " (STATUS, TAREFA, CAMINHO, DESCRICAO, NOMEARQUIVO)" +
                               " VALUES" +
                               " (3, " +
                               "" + handleTarefa + ", " +
                               "'" + diretorioPadrao + "\\" + nomeArquivo + "'," +
                               "'" + descricao + "'," +
                               "'" + nomeArquivo + "')";

                connection.Inserir(query);

                //query para pegar o handle do arquivo adicionado
                String query1 = " SELECT MAX(A.HANDLE) HANDLE" +
                                " FROM TR_TAREFAANEXO A" +
                                " WHERE A.DESCRICAO = '" + descricao + "'" +
                                " AND A.CAMINHO = '" + diretorioPadrao + "\\" + nomeArquivo + "'" +
                                " AND A.TAREFA = " + handleTarefa;
                SqlDataReader reader = connection.Pesquisa(query1);
                while (reader.Read())
                {
                    handleAnexo = Convert.ToInt32(reader["HANDLE"]);
                }
                reader.Close();

                MessageBox.Show("Arquivo salvo com sucesso.");
                //Chama o controle de status
                ControleDeStatus(true);
            }
            else
            {
                if (acao == "Excluir")
                {
                    DialogResult confirmacaoButton = MessageBox.Show("Deseja Continuar?", "Excluir Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                    if (confirmacaoButton.ToString().ToUpper() == "YES")
                    {
                        String query = " DELETE FROM TR_TAREFAANEXO" +
                                       " WHERE HANDLE = " + handleAnexo;
                        connection.Inserir(query);
                        this.Close();
                    }
                }
            }
        }


        private void selecionarAnexoButtonOnclick(object sender, EventArgs e)
        {
            nomeArquivo = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Arquivo";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                caminhoAnexoTextBox.Text = System.IO.Path.GetFullPath(openFileDialog.FileName);
                descricaoTextBox.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
                nomeArquivo = nomeArquivo + System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        //Controle de status basico
        private void ControleDeStatus(Boolean ehGravado)
        {
            if ((handleAnexo != 0) || ehGravado == true)
            {
                this.Text = "Arquivo - Ativo";
                selecionarAnexoButton.Enabled = false;
                caminhoAnexoTextBox.Enabled = false;
                descricaoTextBox.Enabled = false;
                gravarButton.Visible = false;
                excluirButton.Visible = true;
                exibirButton.Visible = true;
                //Ordena os botões
                excluirButton.Location = new Point(373, 107);
            }
        }

        private void exibirButtonOnClick(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"" + caminhoAnexoTextBox.Text + "");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void excluirButtonOnClick(object sender, EventArgs e)
        {
            GravarRegistro("Excluir");
        }

        private void PreencherFormulario()
        {
            String descricao = "", caminho = "";

            String query = " SELECT A.DESCRICAO, A.CAMINHO" +
                           " FROM TR_TAREFAANEXO A" +
                           " WHERE A.HANDLE = " + handleAnexo;
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                descricao = reader["DESCRICAO"].ToString();
                caminho = reader["CAMINHO"].ToString();
            }
            reader.Close();
            descricaoTextBox.Text = descricao;
            caminhoAnexoTextBox.Text = caminho;
            ControleDeStatus(false);

        }


        private void AnexoFormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Desconectar();
            handleTarefa = 0;
            handleAnexo = 0;
        }
    }
}
