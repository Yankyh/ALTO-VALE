using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTO_VALE.TN_TECNOLOGIA.Email
{
    public class TEmail
    {
        Boolean ssl;
        String usuario,smtp, senha;
        int porta;
        
        public string Smtp { get => smtp; set => smtp = value; }
        public int Porta { get => porta; set => porta = value; }
        public string Senha { get => senha; set => senha = value; }
        public bool Ssl { get => ssl; set => ssl = value; }
        public string Usuario { get => usuario; set => usuario = value; }
    }
}
