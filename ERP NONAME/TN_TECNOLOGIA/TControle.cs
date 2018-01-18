using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTO_VALE.TN_TECNOLOGIA
{
    class TControle
    {
        int handle;
        String fk;
        String tabela;
        TControle prox;
        
        public string Fk { get => fk; set => fk = value; }
        public string Tabela { get => tabela; set => tabela = value; }
        public int Handle { get => handle; set => handle = value; }
        internal TControle Prox { get => prox; set => prox = value; }
    }
}
