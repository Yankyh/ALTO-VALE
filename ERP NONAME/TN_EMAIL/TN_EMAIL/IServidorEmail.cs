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

namespace ALTO_VALE.VIEW.TN_EMAIL
{
    public partial class IServidorEmail : PADRONIZACAO.FormPadrao
    {
        int internalHandle;
        public IServidorEmail(int handle)
        {
            InitializeComponent();
            verificaStatus(handle);
            internalHandle = handle;

        }




        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoLimpar(int handle)
        {
            if (handle == 0)
            {
                richTextBoxPop.Text = "";
                richTextBoxPopPorta.Text = "";
                richTextBoxSmtp.Text = "";
                richTextBoxSmtpPorta.Text = "";
                richTextBoxNome.Text = "";
            }
            else
            {
                DAL.Connection conexao = new DAL.Connection();
                conexao.Conectar();
                String query = "SELECT * FROM TN_SERVIDOREMAIL WHERE HANDLE = " + handle;
                SqlDataReader reader = conexao.Pesquisa(query);
                while (reader.Read())
                {
                    richTextBoxSmtp.Text = reader["SMTP"].ToString();
                    richTextBoxSmtpPorta.Text = reader["SMTPPORTA"].ToString();
                    richTextBoxPop.Text = reader["POP"].ToString();
                    richTextBoxPopPorta.Text = reader["POPPORTA"].ToString();
                    richTextBoxNome.Text = reader["NOME"].ToString();
                }
                reader.Close();
                conexao.Desconectar();
            }
        }
        private void verificaStatus(int handle)
        {
            if (handle == 0 || handle == 1)
            {
                button1.Text = "Liberar";
                button2.Text = "Limpar";

            }
            else if (handle > 0)
            {
                String query = "SELECT STATUS FROM TN_SERVIDOREMAIL WHERE HANDLE = " + handle;
                DAL.Connection conexao = new DAL.Connection();
                conexao.Conectar();
                SqlDataReader reader = conexao.Pesquisa(query);
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["STATUS"]) == StatusServidorEmail.Cadastrado)
                    {
                        button1.Text = "Liberar";
                        button2.Text = "Limpar";
                    }
                    else if (Convert.ToInt32(reader["STATUS"]) == StatusServidorEmail.Encerrado)
                    {
                        button1.Text = "Voltar";
                        button2.Text = "Cancelar";
                    }
                }
                conexao.Desconectar();
                reader.Close();
            }
        }

        private void Button1OnClick(object sender, EventArgs e)
        {
            if (button1.Text == "Liberar")
            {
                if (internalHandle == 0 || internalHandle == 1)
                {
                    UServidorEmail servidor = new UServidorEmail();
                    servidor.Nome = richTextBoxNome.Text;
                    servidor.Pop = richTextBoxPop.Text;
                    servidor.Popporta = Convert.ToInt32(richTextBoxPopPorta.Text);
                    servidor.Smtp = richTextBoxSmtp.Text;
                    servidor.Smtpporta = Convert.ToInt32(richTextBoxSmtpPorta.Text);
                    servidor.Sslsmtp = "1";
                    servidor.Sslpop = "2";
                    if (VerificaCamposObrigatorios(servidor) == true)
                    {
                        tentaInserirRegistro(servidor);
                    }
                }
            }
        }

        private void tentaInserirRegistro(UServidorEmail servidor)
        {
            DAL.Connection conexao = new DAL.Connection();
            conexao.Conectar();
            String query = "INSERT INTO TN_SERVIDOREMAIL(SMTP,SMTPPORTA,POP,POPPORTA,NOME,STATUS,EHSSLSMTP,EHSSLPOP)" +
                "VALUES('" + servidor.Smtp + "'," + servidor.Smtpporta + ",'" + servidor.Pop + "'," + servidor.Popporta + ",'" + servidor.Nome + "'," +
                StatusServidorEmail.Ativo + ",'" + servidor.Sslsmtp + "','" + servidor.Sslpop + "')";
            try
            {
                SqlDataReader reader = conexao.Pesquisa(query);
                MessageBox.Show("Inserido com sucesso!");
                verificaStatus(internalHandle);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private Boolean VerificaCamposObrigatorios(UServidorEmail servidor)
        {
            Boolean retorno;
            if (servidor.Nome.Trim() == "")
            {
                MessageBox.Show("O cmapo nome é obrigatório");
                retorno = false;
            }
            else if (servidor.Pop.Trim() == "")
            {
                MessageBox.Show("O campo pop é obrigatório");
                retorno = false;
            }
            else if (servidor.Popporta.ToString().Trim() == "")
            {
                MessageBox.Show("O campo porta do pop é obrigatório");
                retorno = false;
            }
            else if (servidor.Smtp.Trim() == "")
            {
                MessageBox.Show("O Smtp é obrigatório");
                retorno = false;
            }
            else if (servidor.Smtpporta.ToString().Trim() == "")
            {
                MessageBox.Show("a porta do smtp é obrigatório");
                retorno = false;
            }
            else
            {
                retorno = true;
            }
            return retorno;
        }


        private void button2OnClick(object sender, EventArgs e)
        {
            if (button2.Text == "Limpar")
            {
                botaoLimpar(internalHandle);
            }
        }
    }
}
