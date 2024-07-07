namespace Aplicativo_de_tarefas
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            label4 = new Label();
            quantidade = new Label();
            _listBox1 = new ListBox();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(206, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(268, 266);
            button1.Name = "button1";
            button1.Size = new Size(141, 60);
            button1.TabIndex = 9;
            button1.Text = "Adicionar Tarefa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 19);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 10;
            label4.Text = "Tarefas:";
            // 
            // quantidade
            // 
            quantidade.AutoSize = true;
            quantidade.Location = new Point(150, 19);
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(31, 20);
            quantidade.TabIndex = 11;
            quantidade.Text = "0/0";
            // 
            // _listBox1
            // 
            _listBox1.FormattingEnabled = true;
            _listBox1.Location = new Point(12, 47);
            _listBox1.Name = "_listBox1";
            _listBox1.Size = new Size(178, 404);
            _listBox1.TabIndex = 12;
            _listBox1.SelectedIndexChanged += _listBox1_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 472);
            Controls.Add(_listBox1);
            Controls.Add(quantidade);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MonthCalendar monthCalendar1;
        private Button button1;
        private Label label4;
        private Label quantidade;
        private ListBox _listBox1;

        public ListBox listBox1 {
            get { return _listBox1; }
        }
    }
}