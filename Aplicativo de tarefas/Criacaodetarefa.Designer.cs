namespace Aplicativo_de_tarefas
{
    partial class Criacaodetarefa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Criacaodetarefa));
            label1 = new Label();
            titulodatarefa = new TextBox();
            label2 = new Label();
            label3 = new Label();
            descricaodatarefa = new TextBox();
            button1 = new Button();
            button2 = new Button();
            monthCalendar1 = new MonthCalendar();
            tipodatarefa = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 39);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Titulo da tarefa: ";
            // 
            // titulodatarefa
            // 
            titulodatarefa.Location = new Point(33, 62);
            titulodatarefa.Name = "titulodatarefa";
            titulodatarefa.Size = new Size(236, 27);
            titulodatarefa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 102);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 2;
            label2.Text = "Tipo da tarefa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 170);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 4;
            label3.Text = "Descrição da tarefa:";
            // 
            // descricaodatarefa
            // 
            descricaodatarefa.Location = new Point(33, 193);
            descricaodatarefa.Name = "descricaodatarefa";
            descricaodatarefa.Size = new Size(236, 27);
            descricaodatarefa.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(69, 322);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 6;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(366, 322);
            button2.Name = "button2";
            button2.Size = new Size(200, 50);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(323, 39);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            // 
            // tipodatarefa
            // 
            tipodatarefa.FormattingEnabled = true;
            tipodatarefa.Items.AddRange(new object[] { "Afazeres", "Lazer", "Estudo" });
            tipodatarefa.Location = new Point(33, 125);
            tipodatarefa.Name = "tipodatarefa";
            tipodatarefa.Size = new Size(236, 28);
            tipodatarefa.TabIndex = 9;
            // 
            // Criacaodetarefa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 401);
            Controls.Add(tipodatarefa);
            Controls.Add(monthCalendar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(descricaodatarefa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(titulodatarefa);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Criacaodetarefa";
            Text = "Criacaodetarefa";
            Load += Criacaodetarefa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titulodatarefa;
        private Label label2;
        private Label label3;
        private TextBox descricaodatarefa;
        private Button button1;
        private Button button2;
        private MonthCalendar monthCalendar1;
        private ComboBox tipodatarefa;
    }
}