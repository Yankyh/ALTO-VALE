using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTO_VALE.TN_TECNOLOGIA.Controles
{
    class Control
    {

        public static int BuscarHandleRegistro(String tabela, String campo, String valorCampo)
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
        public static Boolean retornaBoolean(String texto)
        {
            Boolean valida = false;
            if (texto.Equals("S"))
            {
                valida = true;
                return valida;
            }
            else if (texto.Equals("N"))
            {
                valida = false;
                return valida;
            }
            else
            {
                MessageBox.Show("Não foi possível atribuir o booleano");
                return valida;
            }

        }
        public static String retornaBoolToString(Boolean texto)
        {
            String retorno = "";
            if(texto == true)
            {
                retorno = "S";
                return retorno;
            }else if (texto == false)
            {
                retorno = "N";
                return retorno;
            }
            else
            {
                MessageBox.Show("Não há boolean para ser tratado");
                return "";
            }
        }
    }
}
