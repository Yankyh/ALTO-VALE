using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ALTO_VALE.DAL;

namespace ALTO_VALE.VIEW.PS_PESSOA
{
    
    public partial class IPessoaAnexo : Form
    {
        public static int handlePessoa = 0, handleAnexo = 0;
        private String nomeArquivo = "";

        //Conexao com o banco
        Connection connection = new Connection();
        public IPessoaAnexo()
        {
            InitializeComponent();
            connection.Conectar();
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
            try{
                File.Copy(@dirInic, @dirDest + "\\" + nomeArquivo, true);
                gravarRegistro("Gravar");
            }
            catch(Exception ThisException)
            {
                MessageBox.Show(ThisException.ToString());
            }    
        }

        private void gravarRegistro(String acao)
        {
            if(acao == "Gravar")
            {
                String query = " INSERT INTO PS_PESSOAANEXO" +
                               " (STATUS, PESSOA, CAMINHO)" +
                               " VALUES" +
                               " (3, " + handlePessoa + ", '" + CSistema.diretorioPadrao + "\\" + nomeArquivo + "')";
                connection.Inserir(query);
                MessageBox.Show("Arquivo salvo com sucesso.");
                //Chama o contorle de status
                ControleDeStatus();
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
                nomeArquivo = nomeArquivo + System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void anexoFormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Desconectar();
            handleAnexo = 0;
            handlePessoa = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Controle de status basico
        private void ControleDeStatus()
        {
            if(handleAnexo != 0)
            {
                this.Text = "Arquivo - Ativo";
                selecionarAnexoButton.Enabled = false;
                caminhoAnexoTextBox.Enabled = false;
                gravarButton.Visible = false;
            }

        }
    }
}
