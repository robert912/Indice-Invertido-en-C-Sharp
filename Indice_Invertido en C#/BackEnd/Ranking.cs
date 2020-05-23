using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Ranking
    {
        public int[] rankings = new int[Documentos.TotalDocumentos];
        public int[] frecuenciaRanking = new int[Documentos.TotalDocumentos];
        public Ranking(int[] result)
        {
            for(int i=0;i<Documentos.TotalDocumentos;i++)
            {
                rankings[i] = -1;
                frecuenciaRanking[i] = result[i];
            }
            //int aux = 0;
            //frecuenciaRanking = result;
            Array.Sort(frecuenciaRanking);
            Array.Reverse(frecuenciaRanking);
            for(int i=0;i<result.Length;i++)
            {
                for (int j = 0; j < result.Length; j++)
                {
                    if (frecuenciaRanking[i] == result[j]) 
                    {
                        rankings[i] = j;
                        result[j] = -1;
                        break;
                    }
                }
            }
        }
    }
}
