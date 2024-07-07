using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_de_tarefas
{
    public partial class Teladatarefafinalizada : Form
    {
        public Teladatarefafinalizada()
        {
            InitializeComponent();
        }

        public Teladatarefafinalizada(string opcaoselecionada) : this()
        {
            string caminhodoarquivo = @".\tarefasjson.txt";

            string[] linhasDoArquivo = File.ReadAllLines(caminhodoarquivo);
            List<tarefa> tarefas = new List<tarefa>();

            foreach (string linha in linhasDoArquivo)
            {
                tarefa tarefadalinha = JsonConvert.DeserializeObject<tarefa>(linha);
                tarefas.Add(tarefadalinha);

            }

            foreach (tarefa tarefa in tarefas)
            {
                if (opcaoselecionada == tarefa.titulodatarefa)
                {
                    label1.Text = tarefa.titulodatarefa;
                    label6.Text = tarefa.tipodatarefa;
                    label7.Text = tarefa.situacaotarefa;
                    label5.Text = tarefa.descricaodatarefa;
                }
            }

        }
        private void Teladatarefafinalizada_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
