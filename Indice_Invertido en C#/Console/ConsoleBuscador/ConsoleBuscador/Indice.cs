using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BackEnd
{
    public class Indice:
    {
        private static StreamReader fichero;
        public string[] PalabrasIndice;
        public int[,] DocsIndice;

        public Indice(string[] SW, int Docs,string Ruta)
        {
            if (File.Exists(Ruta))
            {
                string Aux;
                fichero = File.OpenText(Ruta);

                Aux = fichero.ReadToEnd();
                int i = 0;
                bool stopW = false, stopW2 = false;
                string[] palabras = Aux.Split(new Char[] { (char)13, (char)10, ' ', ',', '.', ':', '\t', '\"', '/', '-', 'A', 'T', 'I', 'B', 'W' });//Divide una cadena en subcadenas basadas en los caracteres de una matriz.
                PalabrasIndice = new string[palabras.Length];
                foreach (string palabra in palabras)
                {
                    if (palabra.Trim() != "")//Trim() Quita todos los caracteres de espacio en blanco del principio y el final del objeto String actual.
                    {
                        stopW = Comparar(palabra, SW);
                        if (stopW == false)//si las palabras de Stopword no es igual a la palabra del Indice, ingresa a este scope
                        {
                            if (i != 0)
                                stopW2 = Comparar(palabra, PalabrasIndice);
                            if (stopW2 == false)
                            {
                                PalabrasIndice[i] = palabra;
                                i++;
                            }
                            else
                                stopW2 = false;
                        }
                        else
                            stopW = false;
                    }
                }
                Array.Resize(ref PalabrasIndice, i);

                DocsIndice = new int[i, Docs];
                i = 0; stopW = false;
                int j = -1;
                foreach (string palabra in palabras)
                {
                    if (palabra.Trim() != "")//Trim() Quita todos los caracteres de espacio en blanco del principio y el final del objeto String actual.
                    {
                        stopW = Comparar(palabra, SW);
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

        public bool Comparar(string palabra, string[] Palabras)
        {
            for (int j = 0; j < Palabras.Length; j++)
            {
                if (palabra == Palabras[j])
                {
                    return true;
                }

            }
            return false;
        }
    }
}

