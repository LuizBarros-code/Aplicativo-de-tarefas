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
    public partial class Criacaodetarefa : Form
    {
        public Criacaodetarefa()
        {
            InitializeComponent();
        }

        private void criacaotarefa()
        {
            DialogResult adicionar;
            adicionar = MessageBox.Show("Deseja adicionar a tarefa?", "adicionar tarefa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (adicionar.Equals(DialogResult.No))
            {

            }
            else
            {
                tarefa tarefa1 = new tarefa();

                tarefa1.data = monthCalendar1.SelectionRange.Start;
                tarefa1.titulodatarefa = titulodatarefa.Text;
                tarefa1.tipodatarefa = tipodatarefa.Text;
                tarefa1.descricaodatarefa = descricaodatarefa.Text;

                titulodatarefa.Text = "";
                tipodatarefa.Text = "";
                descricaodatarefa.Text = "";
                string json = JsonConvert.SerializeObject(tarefa1);
                string caminhodoarquivo = @".\tarefasjson.txt";
                if (File.Exists(caminhodoarquivo))
                {
                    string conteudoAtual = File.ReadAllText(caminhodoarquivo);

                    string novatarefa = json;
                    List<tarefa> tarefas = new List<tarefa>();


                    foreach (string linha in File.ReadAllLines(caminhodoarquivo))
                    {
                        tarefa tarefadalinha = JsonConvert.DeserializeObject<tarefa>(linha);
                        tarefas.Add(tarefadalinha);
                    }
                    tarefas.Add(tarefa1);

                    var tarefasNaoVazias = tarefas.Where(t => !string.IsNullOrWhiteSpace(t.titulodatarefa));
                    File.WriteAllLines(caminhodoarquivo, tarefasNaoVazias.Select(t => JsonConvert.SerializeObject(t)));
                }
                else
                {
                    File.Create(caminhodoarquivo).Close();
                    File.WriteAllText(caminhodoarquivo, json);
                }
                this.Close();
            }

        }

        private void Criacaodetarefa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            criacaotarefa();
        }
    }
}
