using ALTO_VALE.DAL;
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

namespace ALTO_VALE.VIEW.PS_PESSOA
{
    public partial class IPessoaEndereco : Form
    {
        //Conexão
        Connection connection = new Connection();

        public IPessoaEndereco()
        {
            InitializeComponent();
            //Conectar
            connection.Conectar();
        }

        private void gravarButtonOnClick(object sender, EventArgs e)
        {
            if (verificarCamposObrigatorios() == true)
            {
                gravarRegistroEndereco();
            }
        }

        public void gravarRegistroEndereco()
        {
            String cep = "", cidade = "", bairro = "", logradouro = "", numero = "", referencia = "";
            int estado = 0;
            cep = cepTextBox.Text;
            cidade = cidadeTextBox.Text;
            bairro = bairroTextBox.Text;
            logradouro = logradouroTextBox.Text;
            numero = numeroTextBox.Text;
            referencia = referenciaTextBox.Text;
            estado = estadoHandle();

            String queryInsert = "INSERT INTO PS_PESSOAENDERECO (STATUS, CEP, CIDADE, BAIRRO, LOGRADOURO, NUMERO, REFERENCIA, ESTADO) VALUES " +
                                 " (1, '"+cep+"', '"+cidade+"', '"+bairro+"', '"+logradouro+"', '"+numero+"', '"+referencia+"', "+estado+")";
            connection.Inserir(queryInsert);
        }



        //Tipo Pessoa
        private void estadoDropDown(object sender, EventArgs e)
        {
            //Limpa a combo box
            estadoComboBox.Items.Clear();

            //Lista os tipos
            String query = "SELECT NOME FROM PS_ESTADO";
            query = StatusFilter.StatusNotIn(query);

            SqlDataReader reader = connection.Pesquisa(query);

            while (reader.Read())
            {
                estadoComboBox.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();

        }



        //Metodos de busca de handle
        private int estadoHandle()
        {
            int estadoHandle = 0;
            String estadoSelecionado = "";
            estadoSelecionado = estadoComboBox.SelectedItem.ToString();

            String query = "SELECT HANDLE FROM PS_ESTADO WHERE NOME = '" + estadoSelecionado + "'";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                estadoHandle = Convert.ToInt32((reader["HANDLE"]));
            }
            reader.Close();

            return estadoHandle;
        }



        //Verificar campos obrigatórios
        public Boolean verificarCamposObrigatorios()
        {
            if(cepTextBox.Text == "")
            {
                MessageBox.Show("O campo Cep é obrigatório.");
                return false;
            }
            else
            {
                if(cidadeTextBox.Text == "")
                {
                    MessageBox.Show("O campo cidade é obrigatório.");
                    return false;
                }
                else
                {
                    if (estadoComboBox.SelectedValue == "")
                    {
                        MessageBox.Show("O campo estado é obrigatório.");
                        return false;
                    }
                    else
                    {
                        if (bairroTextBox.Text == "")
                        {
                            MessageBox.Show("O campo bairro é obrigatório.");
                            return false;
                        }
                        else
                        {
                            if (logradouroTextBox.Text == "")
                            {
                                MessageBox.Show("O campo logradouro é obrigatório.");
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                }
            }   
        }




    }
}
