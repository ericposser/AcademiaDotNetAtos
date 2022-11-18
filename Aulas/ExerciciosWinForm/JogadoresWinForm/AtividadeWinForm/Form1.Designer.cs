namespace AtividadeWinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomeJogador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_listaJogador = new System.Windows.Forms.TextBox();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do jogador:";
            // 
            // txt_nomeJogador
            // 
            this.txt_nomeJogador.Location = new System.Drawing.Point(122, 6);
            this.txt_nomeJogador.Name = "txt_nomeJogador";
            this.txt_nomeJogador.Size = new System.Drawing.Size(200, 23);
            this.txt_nomeJogador.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista de jogadores";
            // 
            // txt_listaJogador
            // 
            this.txt_listaJogador.Enabled = false;
            this.txt_listaJogador.Location = new System.Drawing.Point(386, 46);
            this.txt_listaJogador.Multiline = true;
            this.txt_listaJogador.Name = "txt_listaJogador";
            this.txt_listaJogador.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_listaJogador.Size = new System.Drawing.Size(382, 360);
            this.txt_listaJogador.TabIndex = 3;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(122, 55);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_gravar.TabIndex = 4;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_gravar_MouseClick);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(222, 55);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_limpar_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 453);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.txt_listaJogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nomeJogador);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_nomeJogador;
        private Label label2;
        private TextBox txt_listaJogador;
        private Button btn_gravar;
        private Button btn_limpar;
    }
}