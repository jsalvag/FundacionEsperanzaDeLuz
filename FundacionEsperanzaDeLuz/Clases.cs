using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionEsperanzaDeLuz
{
    class Clases
    {
        
    }
    public class Manejador
    {
        OleDbConnection CONEX;

        public conectar()
        {
            CONEX = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = .\\FELDB.accdb");
            initializeComponet();
        }
    }
}
