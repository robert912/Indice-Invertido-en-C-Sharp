using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BackEnd;

namespace BackEnd
{
    public class StopWords
    {
        private static StreamReader fichero;
        public static string[] Palabras;
        public static int TotalPalabras = 0;
        public static bool Cargado;
        public StopWords(string Directorio)
        {
            
            if (File.Exists(Directorio))
            {
                string Aux;
                fichero = File.OpenText(Directorio);
                do
                {
                    Aux = fichero.ReadLine();
                    if (Aux != null)
                        TotalPalabras++;
                } while (Aux != null);

                Palabras = new string[TotalPalabras];
                fichero.BaseStream.Seek(0, SeekOrigin.Begin);
                int i = 0;
                do
                {
                    Aux = fichero.ReadLine();
                    if (Aux != null)
                        Palabras[i] = Aux;
                    i++;
                } while (Aux != null);

                fichero.Close();
                Cargado = true;
            }
            else
                Cargado = false;
        }
    }
}
