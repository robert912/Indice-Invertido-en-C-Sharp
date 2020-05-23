using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Resultados
    {
        public string Phrase;
        public int[] Result = new int[Documentos.TotalDocumentos];
        public int[] ExactMatch = new int[Documentos.TotalDocumentos];
        public Ranking rank;
    }
}
