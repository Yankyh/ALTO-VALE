using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTO_VALE.VIEW.TN_EMAIL
{
    class UServidorEmail
    {
        String smtp, pop, nome;
        int smtpporta, popporta, status;
        String sslpop, sslsmtp;

        public string Smtp { get => smtp; set => smtp = value; }
        public string Pop { get => pop; set => pop = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Smtpporta { get => smtpporta; set => smtpporta = value; }
        public int Popporta { get => popporta; set => popporta = value; }
        public int Status { get => status; set => status = value; }
        public String Sslpop { get => sslpop; set => sslpop = value; }
        public String Sslsmtp { get => sslsmtp; set => sslsmtp = value; }
    }
}
