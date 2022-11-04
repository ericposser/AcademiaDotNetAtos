namespace AulaWindowsForm
{
    partial class FormMain
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
            this.txt_nomeCompleto = new System.Windows.Forms.TextBox();
            this.btn_adicionarNaLista = new System.Windows.Forms.Button();
            this.txt_listaNomes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // txt_nomeCompleto
            // 
            this.txt_nomeCompleto.Location = new System.Drawing.Point(123, 18);
            this.txt_nomeCompleto.Name = "txt_nomeCompleto";
            this.txt_nomeCompleto.Size = new System.Drawing.Size(265, 23);
            this.txt_nomeCompleto.TabIndex = 1;
            this.txt_nomeCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nomeCompleto_KeyPress);
            // 
            // btn_adicionarNaLista
            // 
            this.btn_adicionarNaLista.Location = new System.Drawing.Point(123, 59);
            this.btn_adicionarNaLista.Name = "btn_adicionarNaLista";
            this.btn_adicionarNaLista.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionarNaLista.TabIndex = 2;
            this.btn_adicionarNaLista.Text = "Inserir";
            this.btn_adicionarNaLista.UseVisualStyleBackColor = true;
            this.btn_adicionarNaLista.Click += new System.EventHandler(this.btn_adicionarNaLista_Click);
            // 
            // txt_listaNomes
            // 
            this.txt_listaNomes.Enabled = false;
            this.txt_listaNomes.Location = new System.Drawing.Point(123, 100);
            this.txt_listaNomes.Multiline = true;
            this.txt_listaNomes.Name = "txt_listaNomes";
            this.txt_listaNomes.Size = new System.Drawing.Size(265, 338);
            this.txt_listaNomes.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_listaNomes);
            this.Controls.Add(this.btn_adicionarNaLista);
            this.Controls.Add(this.txt_nomeCompleto);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Titulo do formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_nomeCompleto;
        private Button btn_adicionarNaLista;
        private TextBox txt_listaNomes;
    }
}