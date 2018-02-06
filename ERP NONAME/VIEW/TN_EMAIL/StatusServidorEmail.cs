using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTO_VALE.VIEW.TN_EMAIL
{
    public class StatusServidorEmail
    {
        const int cadastrado = 1;
        const int aguardandoModificacoes = 2;
        const int ativo = 3;
        const int encerrado = 4;
        const int cancelado = 5;

        public static int Cadastrado => cadastrado;

        public static int AguardandoModificacoes => aguardandoModificacoes;

        public static int Ativo => ativo;

        public static int Encerrado => encerrado;

        public static int Cancelado => cancelado;
    }
}
