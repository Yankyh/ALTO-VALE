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

namespace ALTO_VALE.VIEW.MD_SISTEMA
{
    public partial class IAnexoPadrao : Form
    {
        public static int handleOrigem = 0, handleAnexo = 0, handleTabelaOrigem = 0;
        private String nomeArquivo = "", extensao = "";

        //Conexao com o banco
        Connection connection = new Connection();

        public IAnexoPadrao()
        {
            InitializeComponent();
            connection.Conectar();
            //Preenche o formulário
            PreencherFormulario();
        }


        private void gravarButtonOnClick(object sender, EventArgs e)
        {
            if (caminhoAnexoTextBox.Text != "")
            {
                nomeArquivo = descricaoTextBox.Text + extensao;
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
                dirDest = dirDest + "\\" + nomeArquivo;
                File.Copy(@dirInic, @dirDest, true);
                GravarRegistro("Gravar", dirDest);
            }
            catch (Exception ThisException)
            {
                MessageBox.Show(ThisException.ToString());
            }
        }

        private void GravarRegistro(String acao, String caminho)
        {
            //handle tabela origem
            //1 TarefaAnexo //2 TarefaDocumentacaoAnexo  //3 PessoaAnexo

            String descricao = "", diretorioPadrao = "";

            descricao = descricaoTextBox.Text;
            diretorioPadrao = CSistema.diretorioPadrao;
            if (acao == "Gravar")
            {
                String query = " INSERT INTO MD_ANEXO" +
               " (STATUS, HANDLEORIGEM, CAMINHO, DESCRICAO, NOMEARQUIVO, TABELAORIGEM)" +
               " VALUES" +
               " (3, " +
               "" + handleOrigem + ", " +
               "'" + caminho + "'," +
               "'" + descricao + "'," +
               "'" + nomeArquivo + "'," +
               "" + handleTabelaOrigem + ")";
                connection.Inserir(query);

                //query para pegar o handle do arquivo adicionado
                String query1 = " SELECT MAX(A.HANDLE) HANDLE" +
                                " FROM MD_ANEXO A" +
                                " WHERE A.DESCRICAO = '" + descricao + "'" +
                                " AND A.CAMINHO = '" + diretorioPadrao + "\\" + nomeArquivo + "'" +
                                " AND A.TABELAORIGEM = " + handleTabelaOrigem +
                                " AND A.HANDLEORIGEM = " + handleOrigem;
                SqlDataReader reader = connection.Pesquisa(query1);
                while (reader.Read())
                {
                    handleAnexo = Convert.ToInt32(reader["HANDLE"]);
                }
                reader.Close();

                caminhoAnexoTextBox.Text = caminho;
                MessageBox.Show("Arquivo salvo com sucesso.");
                //Chama o contorle de status
                ControleDeStatus(true);
            }
            else
            {
                if (acao == "Excluir")
                {
                    DialogResult confirmacaoButton = MessageBox.Show("Deseja Continuar?", "Excluir Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                    if (confirmacaoButton.ToString().ToUpper() == "YES")
                    {
                        String query = " DELETE FROM MD_ANEXO" +
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
                descricaoTextBox.Text = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                extensao = System.IO.Path.GetExtension(openFileDialog.FileName);
            }
        }

        private void anexoFormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Desconectar();
            handleAnexo = 0;
            handleTabelaOrigem = 0;
            handleOrigem = 0;
        }

        //Controle de status basico
        private void ControleDeStatus(Boolean ehGravado)
        {
            if ((handleAnexo != 0) || ehGravado == true)
            {
                this.Text = "Anexo - Ativo";
                //    selecionarAnexoButton.Enabled = false;
                caminhoAnexoTextBox.Enabled = false;
                descricaoTextBox.Enabled = false;
                gravarButton.Visible = false;
                excluirButton.Visible = true;
                exibirButton.Visible = true;
                selecionarAnexoButton.Enabled = false;
                //Ordena os botões
                exibirButton.Location = new Point(270, 117);
                excluirButton.Location = new Point(375, 117);
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

        private void AnexoOnFormClosed(object sender, FormClosedEventArgs e)
        {
            handleOrigem = 0;
            handleTabelaOrigem = 0;
            handleAnexo = 0;
        }

        private void excluirButtonOnClick(object sender, EventArgs e)
        {
            try
            {
                String caminho = caminhoAnexoTextBox.Text;
                GravarRegistro("Excluir", null);

                if (System.IO.File.Exists(@caminho))
                {
                    try
                    {
                        System.IO.File.Delete(@caminho);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }

        private void PreencherFormulario()
        {
            String descricao = "", caminho = "";

            String query = " SELECT A.DESCRICAO, A.CAMINHO" +
                           " FROM MD_ANEXO A" +
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
    }
}
