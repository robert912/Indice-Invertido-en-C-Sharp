using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BackEnd
{
    public class SRI
    {
        public static int i = 0;
        static object Block = new object();
        public static Resultados[] Result = new Resultados[1];
        public static string[] Phrase = new string[1];
        public delegate void miEvent(Resultados Result);
        public static event miEvent EventResult;

        public static void ConsultarB(object Frase)
        {
            string frase = Frase.ToString();
            string[] SW = new string[StopWords.TotalPalabras];
            SW = StopWords.Palabras;
            string[] Palabras = LimpiarPalabras(frase, SW);

            Resultados ResultDoc = new Resultados();
            ResultDoc = bestMatch(Palabras, Indice.PalabrasIndice, Indice.DocsIndice);

            lock (Block)
            {
                if (ResultDoc != null)
                {
                    Array.Resize(ref Result, i + 1);
                    Result[i] = ResultDoc;
                    Result[i].Phrase = frase;
                    EventResult(Result[i]);
                    i++;
                }
            }

        }

        public static void ConsultarE(object Frase)
        {
            string frase = Frase.ToString();
            string[] SW = new string[StopWords.TotalPalabras];
            SW = StopWords.Palabras;
            string[] Palabras = LimpiarPalabras(frase, SW);

            Resultados ResultDoc = new Resultados();
            ResultDoc = exactMatch(Palabras, Indice.PalabrasIndice, Indice.DocsIndice);

            lock (Block)
            {
                if (ResultDoc != null)
                {
                    Array.Resize(ref Result, i + 1);
                    Result[i] = ResultDoc;
                    Result[i].Phrase = frase;
                    EventResult(Result[i]);
                    i++;
                }
            }

        }

        public static string[] LimpiarPalabras(string frase, string[] PalabrasComunes)
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


        public static bool Comparar(string palabra, string[] Palabras)
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

        public static Resultados bestMatch(string[] consulta, string[] PalabraIndice,int[,] DocIndice)
        {
            Resultados Result = new Resultados();
            for (int i =0;i<consulta.Length;i++)
            {
                for(int j =0;j<PalabraIndice.Length;j++)
                {
                    if(consulta[i]==PalabraIndice[j])
                    {
                        for(int k=0;k<Documentos.TotalDocumentos;k++)
                        {
                            Result.Result[k] = DocIndice[j,k] + Result.Result[k];
                        }
                    }
                }
            }
            int l = 0;
            for(int i = 0;i<Result.Result.Length;i++)
            {
                if(Result.Result[i]==0)
                {
                    l++;
                    if (l == Result.Result.Length)
                        return null;
                }
            }
            return Result;
        }

        public static Resultados exactMatch(string[] consulta, string[] PalabraIndice, int[,] DocIndice)
        {
            Resultados Result = new Resultados();
            for (int i = 0; i < consulta.Length; i++)
            {
                for (int j = 0; j < PalabraIndice.Length; j++)
                {
                    if (consulta[i] == PalabraIndice[j])
                    {
                        for (int k = 0; k < Documentos.TotalDocumentos; k++)
                        {
                            Result.Result[k] = DocIndice[j, k] + Result.Result[k];
                            if (DocIndice[j, k] != 0)
                                Result.ExactMatch[k]++;
                        }
                    }
                }
            }
            int l = 0;
            for (int i = 0; i < Result.Result.Length; i++)
            {
                if (Result.Result[i] != 0)
                {
                    if (Result.ExactMatch[i] != consulta.Length)
                        Result.Result[i] = 0;
                }

                if (Result.Result[i] == 0)
                {
                    l++;
                    if (l == Result.Result.Length)
                        return null;
                }
            }
            return Result;
        }
    }
}
