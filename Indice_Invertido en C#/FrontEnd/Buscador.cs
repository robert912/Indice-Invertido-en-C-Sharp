using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;

namespace FrontEnd
{
    public partial class Buscador : Form
    {
        public Buscador()
        {
            InitializeComponent();
        }
        Resultados[] listResult =new Resultados[1];
        int i = 0;
        public void newtab(Resultados Result)
        {
            //Code Snippet;
            CheckForIllegalCrossThreadCalls = false;
            /*  TabPage myTabPage = new TabPage("");
              tabControl1.TabPages.Add(myTabPage);
              myTabPage.Text = Convert.ToString(Result.Phrase);*/
            Array.Resize(ref listResult, i + 1);
            listResult[i] = Result;
            Ranking rank = new Ranking(Result.Result);
            listResult[i].rank = rank;
            i++;
            listBoxResult.Items.Add(Result.Phrase);
            //MessageBox.Show(Result.Phrase);

            
        }

        private void buttonBuscar(object sender, EventArgs e)
        {
            listResult = null; i = 0;
            listBoxResult.Items.Clear();
            Resultados[] resultados = new Resultados[1];
            string totalConsulta = textBuscar.Text;
            textBuscar.Text = "";
            int N;
            
            if (radioExact.Checked == true)
            {
                SRI.EventResult += new SRI.miEvent(newtab);
                N = 2;
                SRI.i = 0;
                resultados = ConsultThread.busquedaThread(totalConsulta, N);
                SRI.EventResult -= newtab;
            }
            else
            {
                if (radioBest.Checked == true)
                {
                    SRI.EventResult += new SRI.miEvent(newtab);
                     
                    N = 1;
                    SRI.i = 0;
                    resultados = ConsultThread.busquedaThread(totalConsulta, N);
                    SRI.EventResult -= newtab;
                }
                else
                    MessageBox.Show("Seleccione Exact Match o Best Match");
            }
            
        }

        private void buttonSalir(object sender, EventArgs e)
        {
            
            Application.Exit();

        }

        private void Buscador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonShowDoc_Click(object sender, EventArgs e)
        {
            listBoxShowDoc.Items.Clear();
            string aux;
            aux = Convert.ToString(this.listBoxResult.SelectedItem);
            for (int i = 0; i < listResult.Length; i++)
                if(listResult[i].Phrase == aux)
                {
                    for(int j =0;j<Documentos.TotalDocumentos;j++)
                    {
                        if(listResult[i].rank.frecuenciaRanking[j]!= 0)
                        {
                            for(int k=0;k<4;k++)
                            {
                                listBoxShowDoc.Items.Add(Documentos.Docs[listResult[i].rank.rankings[j],k]);
                            }
                        }
                    }
                }
        }

    }
}
