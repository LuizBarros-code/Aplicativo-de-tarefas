namespace Aplicativo_de_tarefas
{
    partial class Teladatarefa
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
            textteste = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textteste
            // 
            textteste.AutoSize = true;
            textteste.Location = new Point(12, 9);
            textteste.Name = "textteste";
            textteste.Size = new Size(103, 20);
            textteste.TabIndex = 0;
            textteste.Text = "Titulodatarefa";
            textteste.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 55);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 1;
            label1.Text = "Situação da tarefa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 2;
            label2.Text = "Tipo da tarefa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 3;
            label3.Text = "Descrição da tarefa: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 135);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // button1
            // 
            button1.Location = new Point(110, 363);
            button1.Name = "button1";
            button1.Size = new Size(137, 29);
            button1.TabIndex = 5;
            button1.Text = "Finalizar tarefa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(367, 363);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 55);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(495, 55);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 8;
            label6.Text = "label6";
            // 
            // Teladatarefa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 432);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textteste);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Teladatarefa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Teladatarefa";
            Load += Teladatarefa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textteste;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
    }
}