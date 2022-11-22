namespace Desafio02
{
    partial class form_cCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idCliente = new System.Windows.Forms.TextBox();
            this.btn_removerCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cadastrarCliente = new System.Windows.Forms.Button();
            this.txt_nomeCliente = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_idCliente);
            this.groupBox1.Controls.Add(this.btn_removerCliente);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_cadastrarCliente);
            this.groupBox1.Controls.Add(this.txt_nomeCliente);
            this.groupBox1.Controls.Add(this.txt_telefone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(228, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // txt_idCliente
            // 
            this.txt_idCliente.Location = new System.Drawing.Point(57, 27);
            this.txt_idCliente.Name = "txt_idCliente";
            this.txt_idCliente.Size = new System.Drawing.Size(69, 23);
            this.txt_idCliente.TabIndex = 4;
            // 
            // btn_removerCliente
            // 
            this.btn_removerCliente.Location = new System.Drawing.Point(129, 132);
            this.btn_removerCliente.Name = "btn_removerCliente";
            this.btn_removerCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_removerCliente.TabIndex = 3;
            this.btn_removerCliente.Text = "Remover";
            this.btn_removerCliente.UseVisualStyleBackColor = true;
            this.btn_removerCliente.Click += new System.EventHandler(this.btn_removerCliente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cadastrarCliente
            // 
            this.btn_cadastrarCliente.Location = new System.Drawing.Point(215, 132);
            this.btn_cadastrarCliente.Name = "btn_cadastrarCliente";
            this.btn_cadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrarCliente.TabIndex = 4;
            this.btn_cadastrarCliente.Text = "Salvar";
            this.btn_cadastrarCliente.UseVisualStyleBackColor = true;
            this.btn_cadastrarCliente.Click += new System.EventHandler(this.btn_cadastrarCliente_Click);
            // 
            // txt_nomeCliente
            // 
            this.txt_nomeCliente.Location = new System.Drawing.Point(130, 58);
            this.txt_nomeCliente.Name = "txt_nomeCliente";
            this.txt_nomeCliente.Size = new System.Drawing.Size(161, 23);
            this.txt_nomeCliente.TabIndex = 3;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(130, 104);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(161, 23);
            this.txt_telefone.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Cliente";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(36, 224);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(728, 201);
            this.dataGridView2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "MENU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_cCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_cCliente";
            this.Text = "Cadastrar Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_cadastrarCliente;
        private TextBox txt_nomeCliente;
        private TextBox txt_telefone;
        private Label label2;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView2;
        private Button btn_removerCliente;
        private Button button2;
        private Label label3;
        private TextBox txt_idCliente;
    }
}