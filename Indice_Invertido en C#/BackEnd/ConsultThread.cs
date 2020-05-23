using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BackEnd
{
    public static class ConsultThread
    {
        static string[] frases;
        public static Resultados[] busquedaThread(string totalConsulta,int N)
        {
            frases = separaConsulta(totalConsulta);
            Thread[] t = new Thread[frases.Length];
            if (N==1)
            {
                for (int i = 0; i < frases.Length; i++)
                {
                    t[i] = new Thread(new ParameterizedThreadStart(SRI.ConsultarB));
                    t[i].Start(frases[i]);
                }

            }
            else
            {
                for (int i = 0; i < frases.Length; i++)
                {
                    t[i] = new Thread(new ParameterizedThreadStart(SRI.ConsultarE));
                    t[i].Start(frases[i]);
                }
            }
            foreach (var threads in t)
                threads.Join();
            return SRI.Result;
        }
        
         public static string[] separaConsulta(string totalConsulta)
        {
            string[] fraseDividida = totalConsulta.Split(new Char[] { ';'});
            return fraseDividida;
        }

    }
}
