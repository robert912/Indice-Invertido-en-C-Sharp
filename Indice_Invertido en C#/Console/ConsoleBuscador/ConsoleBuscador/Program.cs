using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd;
using System.Threading;

namespace ConsoleBuscador
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWords stop = new StopWords("StopWords.txt");

            Documentos doc = new Documentos("TestCollection.txt");
            Indice Index = new Indice(StopWords.Palabras,doc.TotalDocumentos, "TestCollection.txt");

            for(int i=0;i<Index.PalabrasIndice.Length;i++)
            {
                Console.Write(Index.PalabrasIndice[i]+" = \t");
                for(int j=0;j<5;j++)
                {
                    Console.Write("|" + Index.DocsIndice[i, j] + "|");
                }
                Console.WriteLine();
            }

            Thread T1 = new Thread(new ParameterizedThreadStart(SRI.Consultar));


            //SRI buscar = new SRI("hola mundo, este is mi primera frase for you",stop);

            //for (int i = 0; i < doc.TotalDocumentos; i++)
            //Console.WriteLine(doc.TotalDocumentos[i]);
            //Indice Ind = new Indice();
            Console.ReadKey();
        }
    }
}
