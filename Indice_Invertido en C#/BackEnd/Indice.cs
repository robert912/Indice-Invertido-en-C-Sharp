using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BackEnd
{
    public class Indice:SRI
    {
        private static StreamReader fichero;
        public static string[] PalabrasIndice;
        public static int[,] DocsIndice;

        public Indice(int Docs,string Ruta)
        {
            if (File.Exists(Ruta))
            {
                string Aux;
                fichero = File.OpenText(Ruta);
                Aux = fichero.ReadToEnd();
                PalabrasIndice = LimpiarPalabras(Aux, StopWords.Palabras);
               
                DocsIndice = new int[PalabrasIndice.Length, Docs];
                string[] palabras = Aux.Split(new Char[] { (char)13, (char)10, ' ', ',', '.', ':', '\t', '\"', '/', '-', 'A', 'T', 'I', 'B', 'W' });//Divide una cadena en subcadenas basadas en los caracteres de una matriz.
                bool stopW = false;
                int j = -1;
                foreach (string palabra in palabras)
                {
                    if (palabra.Trim() != "")//Trim() Quita todos los caracteres de espacio en blanco del principio y el final del objeto String actual.
                    {
                        stopW = Comparar(palabra, StopWords.Palabras);
                        if (stopW == false)//si las palabras de Stopword no es igual a la palabra del Indice, ingresa a este scope
                        {
                            if (palabra == Convert.ToString(j + 2))
                                j++;
                            for (int k = 0; k < PalabrasIndice.Length; k++)
                            {
                                if (palabra == PalabrasIndice[k])
                                    DocsIndice[k, j]++;
                            }
                        }
                        else
                            stopW = false;
                    }
                }
                
            }
        }
    }
}

