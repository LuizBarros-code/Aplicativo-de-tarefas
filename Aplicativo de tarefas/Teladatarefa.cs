using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_de_tarefas
{
    public partial class Teladatarefa : Form
    {
        private string opcao;
        string json;
        public Teladatarefa()
        {
            InitializeComponent();
        }

        public Teladatarefa(string opcaoselecionada) : this()
        {
            opcao = opcaoselecionada;

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
                if (opcao == tarefa.titulodatarefa)
                {
                    textteste.Text = tarefa.titulodatarefa;
                    label5.Text = tarefa.tipodatarefa;
                    label6.Text = tarefa.situacaotarefa;
                    label4.Text = tarefa.descricaodatarefa;
                }
            }
        }
        private void Teladatarefa_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult finalizar;
            finalizar = MessageBox.Show("Deseja Finalizar a tarefa?", "Finalizar tarefa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (finalizar == DialogResult.Yes)
            {
                string caminhodoarquivo = @".\tarefasjson.txt";
                List<tarefa> tarefas = new List<tarefa>();


                foreach (string linha in File.ReadAllLines(caminhodoarquivo))
                {
                    tarefa tarefadalinha = JsonConvert.DeserializeObject<tarefa>(linha);
                    tarefas.Add(tarefadalinha);
                }


                foreach (tarefa tarefa in tarefas)
                {
                    if (opcao == tarefa.titulodatarefa)
                    {
                        tarefa.situacaotarefa = "Finalizado";
                    }
                }


                var tarefasNaoVazias = tarefas.Where(t => !string.IsNullOrWhiteSpace(t.situacaotarefa));


                File.WriteAllLines(caminhodoarquivo, tarefasNaoVazias.Select(t => JsonConvert.SerializeObject(t)));


                this.Close();
            }
            else
            {

            }
        }

    }
}
