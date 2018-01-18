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
using ALTO_VALE.DAL;

namespace ALTO_VALE.VIEW.TR_TAREFA
{
    public partial class ITarefa : Form
    {

        //Conexão com o banco
        Connection connection = new Connection(); 
        public ITarefa()
        {
            InitializeComponent();
            //abre a conexão
            connection.Conectar();
        }








        //Preencher tipo
        private void PreencherTipo()
        {
            //Limpa a combo box
            tipoComboBox.Items.Clear();
            //Lista os tipos
            String query = " SELECT HANDLE, NOME FROM TR_TAREFATIPO";
            SqlDataReader reader = connection.Pesquisa(query);
            while (reader.Read())
            {
                tipoComboBox.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();
        }

        private void tarefaFormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Desconectar();
        }
    }
}
