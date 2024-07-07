namespace Aplicativo_de_tarefas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BotaoContinuar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BotaoContinuar
            // 
            BotaoContinuar.Cursor = Cursors.Hand;
            BotaoContinuar.Location = new Point(346, 330);
            BotaoContinuar.Name = "BotaoContinuar";
            BotaoContinuar.Size = new Size(94, 29);
            BotaoContinuar.TabIndex = 0;
            BotaoContinuar.Text = "Continuar";
            BotaoContinuar.UseVisualStyleBackColor = true;
            BotaoContinuar.Click += BotaoContinuar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ilustracao_de_papel_clipboard;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(322, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 123);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 252);
            label1.Name = "label1";
            label1.Size = new Size(351, 20);
            label1.TabIndex = 3;
            label1.Text = "BEM-VINDO AO APLICATIVO DE TAREFAS DO NETO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 498);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(BotaoContinuar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tarefas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotaoContinuar;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
