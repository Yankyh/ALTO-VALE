using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALTO_VALE.DAL;
using System.Data.SqlClient;

namespace ALTO_VALE.TECNOLOGIA
{
    class ConexaoUtil
    {
        public DAL.Connection Rede = new DAL.Connection();
        public String VariavelUsuario (int handle)
        {
            String resultado;
            SqlDataReader result;
            Rede.Conectar();
            String pesquisa = "SELECT VARIAVELUSUARIO FROM MS_USUARIO WHERE HANDLE =";
            result = Rede.Pesquisa(pesquisa);
            result.Read();
            resultado = result["VARIAVELUSUARIO"].ToString();
            Rede.Desconectar();
            return resultado;
            
        }
    }
}
