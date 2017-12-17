using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTO_VALE.DAL
{
    class StatusFilter
    {
        /*
         Status:

         1- Cadastrado
         2- Ag. Modificações
         3- Ativo
         4- Cancelado

        */

        public static String StatusNotIn(String query)
        {
            if (query.Contains("WHERE"))
            {
                query = query + " AND STATUS NOT IN (1,2)";
            }
            else
            {
                query = query + " WHERE STATUS NOT IN (1,2)";
            }

            return query;
        }
    }
}
