using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTO_VALE.TN_TECNOLOGIA
{
    public class TControleFluxo
    {

        static TControle inicio = null;
        static TControle fim = null;
        static TControle aux = null;
        static TControle LDNode = null; // last delete node

        public static void insertNode(int handle, String tabela, String fk)
        {
            TControle novo = new TControle();
            novo.Handle = handle;
            novo.Tabela = tabela;
            novo.Fk = fk;
            if (inicio == null)
            {
                inicio = novo;
                fim = novo;
            }
            else
            {
                aux = inicio;
                novo.Prox= null;
                inicio = novo;
                inicio.Prox= aux;
            }
        }
        public static void removeNode()
        {
            inicio.Prox= aux;
            LDNode = inicio;
            inicio = aux;
        }
        public static void listaNodos()
        {
            aux = inicio;
            while (aux != null)
            {
                Console.WriteLine("O caminho é o seguinte : "+aux.Handle);
                aux = aux.Prox;
            }
        }
    }
}
