using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTO_VALE.TN_TECNOLOGIA.EditorSQL
{
    static class Control
    {

        public static int ChaveRegistro(String tabela, String campo, String valorCampo)
        {
            int handle = 0;
            String query;
            query = "SELECT HANDLE FROM " + tabela + " WHERE " + campo + " = " + valorCampo;
            DAL.Connection conexao = new DAL.Connection();
            conexao.Conectar();
            conexao.Pesquisa(query);
            SqlDataReader resultSet;
            resultSet = conexao.Pesquisa(query);
            while (resultSet.Read())
            {
                try
                {
                    handle = Convert.ToInt32(resultSet["HANDLE"]);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            resultSet.Close();
            conexao.Desconectar();

            if (String.IsNullOrEmpty(handle.ToString()) || handle == 0)
            {
                MessageBox.Show("Não é possível instanciar objeto com handle = 0");
            }

            return handle;
        }
    }
}
