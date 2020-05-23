using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BackEnd
{
    public class Documentos
    {
        private StreamReader fichero;
        public static string[,] Docs;
        public int TotalDocumentos = 0;
        public static bool Cargado;
        public Documentos(string Ruta)
        {
            if (File.Exists(Ruta))
            {
                string Aux;
                fichero = File.OpenText(Ruta);
                do
                {
                    Aux = fichero.ReadLine();
                    if (Aux != null)
                        if (Aux[0] == '.' && Aux[1] == 'I')
                            TotalDocumentos++;
                } while (Aux != null);

                Docs = new string[TotalDocumentos,5];
                fichero.BaseStream.Seek(0, SeekOrigin.Begin);

                int i = 0, j = 0;
                Aux = fichero.ReadToEnd();

                string[] palabras = Aux.Split(new Char[] { 'A', 'T', 'I', 'B', 'W' });//Divide una cadena en subcadenas basadas en los caracteres de una matriz.

                foreach (string p in palabras)
                {
                    string palabra = p.Replace(".", "");
                    if (palabra.Trim() != "." && palabra.Trim() != "")//Trim() Quita todos los caracteres de espacio en blanco del principio y el final del objeto String actual.
                    {
                        Docs[j, i] = palabra;
                        i++;
                        if (i == 5)
                        {
                            j++;
                            i = 0;
                        }
                    }
                }

                fichero.Close();
                Cargado = true;
            }
            else
                Cargado = false;
        }

    }
}
