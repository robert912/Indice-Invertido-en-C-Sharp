using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BackEnd;

namespace FrontEnd
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        BackEnd.StopWords SW;
        BackEnd.Indice Index;

        private void buttonStopWords(object sender, EventArgs e)//carga las StopWords
        {
            openFileDialog1.ShowDialog();
            string archivo = openFileDialog1.FileName;
            SW = new BackEnd.StopWords(archivo);
            if(BackEnd.StopWords.Cargado == true)
                MessageBox.Show("StopWords Cargados Exitosamente");
            else
                MessageBox.Show("no se pudo cargar las StopWords");
        }

        private void buttonDocumentos(object sender, EventArgs e)//Carga los Documentos
        {
            openFileDialog1.ShowDialog();
            string archivo = openFileDialog1.FileName;
            BackEnd.Documentos Docs = new BackEnd.Documentos(archivo);
            if (SW == null)
            {
                MessageBox.Show("Primero cargar StopWords");

            }
            else
            {
                Index = new BackEnd.Indice(Documentos.TotalDocumentos,archivo);
                if (BackEnd.Documentos.Cargado == true)
                    MessageBox.Show("Documentos Cargados Exitosamente " + Documentos.TotalDocumentos);
                else
                    MessageBox.Show("no se pudo cargar los Documentos");
            }

        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            if (SW == null)
            {
                MessageBox.Show("Primero cargar Los Documentos");

            }
            else
            {
                this.Hide();
                Buscador formBuscador = new Buscador();
                formBuscador.Show();
            }
        }
    }
}
