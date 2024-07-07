using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;

namespace Aplicativo_de_tarefas
{
    public partial class Form2 : Form
    {
        private string _opcaoselecionada;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Criacaodetarefa criacaodetarefa = new Criacaodetarefa();
            criacaodetarefa.ShowDialog();
        }



        private void atualizarListbox()
        {
            DateTime dataselecionada = monthCalendar1.SelectionRange.Start;
            string caminhodoarquivo = @".\tarefasjson.txt";


            if (File.Exists(caminhodoarquivo))
            {

                string[] linhasDoArquivo = File.ReadAllLines(caminhodoarquivo);
                List<tarefa> tarefas = new List<tarefa>();
                int quantidadedetarefas = 0;
                int quantidadeconcluidas = 0;

                listBox1.Items.Clear();

                foreach (string linha in linhasDoArquivo)
                {
                    tarefa tarefadalinha = JsonConvert.DeserializeObject<tarefa>(linha);
                    tarefas.Add(tarefadalinha);

                }

                foreach (tarefa tarefa in tarefas)
                {
                    if (tarefa.data == dataselecionada)
                    {
                        listBox1.Items.Add(tarefa.titulodatarefa);
                        quantidadedetarefas++;
                        if (tarefa.situacaotarefa == "Finalizado")
                        {
                            quantidadeconcluidas++;
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                    quantidade.Text = $"{quantidadeconcluidas}/{quantidadedetarefas}";
                }
            }
            else
            {

            }
        }

        private void clicandoEmOpcaoListbox()
        {
            if (listBox1.SelectedItems != null)
            {
                string _opcaoselecionada = _listBox1.SelectedItem.ToString();
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
                    if (_opcaoselecionada == tarefa.titulodatarefa)
                    {
                        if (tarefa.situacaotarefa == "Finalizado")
                        {
                            using (var teladatarefafinalizada = new Teladatarefafinalizada(_opcaoselecionada))
                            {
                                teladatarefafinalizada.ShowDialog();
                            }
                        }
                        else
                        {
                            using (var teladatarefa = new Teladatarefa(_opcaoselecionada))
                            {
                                teladatarefa.ShowDialog();
                            }
                        }
                    }
                }

            }
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            atualizarListbox();
        }

        private void _listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clicandoEmOpcaoListbox();
        }

    }
}
