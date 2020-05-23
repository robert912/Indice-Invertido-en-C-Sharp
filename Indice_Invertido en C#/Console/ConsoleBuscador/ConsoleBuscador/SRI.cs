using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd;

namespace ConsoleBuscador
{
    public class SRI
    {
       
        public static void Consultar(object Frase)
        {
            string frase = Frase.ToString();
            //StopWords SW = Convert.
            string[] SW = new string[StopWords.TotalPalabras];
            SW = StopWords.Palabras;
            string[] Palabras;
            Palabras = LimpiarPalabras(frase,SW);
            foreach (string p in Palabras)
                Console.WriteLine(p);
        }

        public string[] LimpiarPalabras(string frase,string[] PalabrasComunes)
        {
            int i = 0;
            bool stopW = false, MismaPal = false;
            string[] palabraDividida = frase.Split(new Char[] { (char)13, (char)10, ' ', ',', '.', ':', '\t', '\"', '/', '-', 'A', 'T', 'I', 'B', 'W' });//Divide una cadena en subcadenas basadas en los caracteres de una matriz.
            string[] Palabras = new string[palabraDividida.Length];
            foreach (string palabra in palabraDividida)
            {
                if (palabra.Trim() != "")//Trim() Quita todos los caracteres de espacio en blanco del principio y el final del objeto String actual.
                {
                    stopW = Comparar(palabra, PalabrasComunes);
                    if (stopW == false)//si las palabras de Stopword no es igual a la palabra del Indice, ingresa a este scope
                    {
                        //if (i != 0)
                            MismaPal = Comparar(palabra, Palabras);
                        if (MismaPal == false)
                        {
                            Palabras[i] = palabra;
                            i++;
                        }
                        else
                            MismaPal = false;
                    }
                    else
                        stopW = false;
                }
            }
            Array.Resize(ref Palabras, i);
            return Palabras;
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
