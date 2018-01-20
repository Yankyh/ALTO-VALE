using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTO_VALE.TN_TECNOLOGIA.Logins
{
    public static class TLoginInfo
    {
        
        public static Email.TEmail informacoesEmail(String usuario)
        {
            Email.TEmail email = new Email.TEmail();
            String query;
            query = "SELECT TOP 1 A.USUARIOEMAIL," +
                "A.SENHA, " +
                "B.SMTP, " +
                "B.SSL, " +
                "B.PORTA  " +
                "FROM PS_EMAIL A" +
                "INNER JOIN PS_SERVIDOREMAIL B ON B.HANDLE = A.SERVIDOREMAIL" +
                "WHERE A.USUARIO = " + getHandleUsuarioAtual(usuario);
            DAL.Connection conexao = new DAL.Connection();
            SqlDataReader reader;
            reader = conexao.Pesquisa(query);
            while (reader.Read())
            {
                email.Porta = Convert.ToInt32(reader["PORTA"]);
                email.Smtp = (reader["SMTP"].ToString());
                email.Senha = (reader["SENHA"].ToString());
                email.Ssl = TN_TECNOLOGIA.Controles.Control.retornaBoolean(reader["SSL"].ToString());
                email.Usuario = reader["USUARIOEMAIL"].ToString();

            }

            return email;
        }

        public static int getHandleUsuarioAtual(String usuario)
        {
            int handleAtual = 0;
            String query = "SELECT HANDLE FROM US_USUARIO WHERE USUARIO = " + usuario;
            DAL.Connection conexao = new DAL.Connection();
            conexao.Conectar();

            SqlDataReader reader = conexao.Pesquisa(query);
            while (reader.Read())
            {
                handleAtual = Convert.ToInt32(reader["HANDLE"]);

                if (handleAtual == 0)
                {
                    MessageBox.Show("Não foi possível atribuir um handle para o usuário : " + usuario);
                }

            }
            reader.Close();
            conexao.Desconectar();
            return handleAtual;

        }

    }
}
