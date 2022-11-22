namespace Desafio02
{
    partial class CProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_idProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_consultarProduto = new System.Windows.Forms.Button();
            this.btn_removerProduto = new System.Windows.Forms.Button();
            this.btn_cadastrarProduto = new System.Windows.Forms.Button();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.txt_nomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Produto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_idProduto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_consultarProduto);
            this.groupBox1.Controls.Add(this.btn_removerProduto);
            this.groupBox1.Controls.Add(this.btn_cadastrarProduto);
            this.groupBox1.Controls.Add(this.txt_preco);
            this.groupBox1.Controls.Add(this.txt_nomeProduto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(235, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Produto";
            // 
            // txt_idProduto
            // 
            this.txt_idProduto.Location = new System.Drawing.Point(89, 33);
            this.txt_idProduto.Name = "txt_idProduto";
            this.txt_idProduto.Size = new System.Drawing.Size(48, 23);
            this.txt_idProduto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // btn_consultarProduto
            // 
            this.btn_consultarProduto.Location = new System.Drawing.Point(89, 168);
            this.btn_consultarProduto.Name = "btn_consultarProduto";
            this.btn_consultarProduto.Size = new System.Drawing.Size(122, 29);
            this.btn_consultarProduto.TabIndex = 6;
            this.btn_consultarProduto.Text = "Consultar Produtos";
            this.btn_consultarProduto.UseVisualStyleBackColor = true;
            this.btn_consultarProduto.Click += new System.EventHandler(this.btn_consultarProduto_Click);
            // 
            // btn_removerProduto
            // 
            this.btn_removerProduto.Location = new System.Drawing.Point(62, 139);
            this.btn_removerProduto.Name = "btn_removerProduto";
            this.btn_removerProduto.Size = new System.Drawing.Size(75, 23);
            this.btn_removerProduto.TabIndex = 5;
            this.btn_removerProduto.Text = "Remover";
            this.btn_removerProduto.UseVisualStyleBackColor = true;
            this.btn_removerProduto.Click += new System.EventHandler(this.btn_removerProduto_Click);
            // 
            // btn_cadastrarProduto
            // 
            this.btn_cadastrarProduto.Location = new System.Drawing.Point(154, 139);
            this.btn_cadastrarProduto.Name = "btn_cadastrarProduto";
            this.btn_cadastrarProduto.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrarProduto.TabIndex = 4;
            this.btn_cadastrarProduto.Text = "Salvar";
            this.btn_cadastrarProduto.UseVisualStyleBackColor = true;
            this.btn_cadastrarProduto.Click += new System.EventHandler(this.btn_cadastrarProduto_Click);
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(107, 100);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(122, 23);
            this.txt_preco.TabIndex = 3;
            // 
            // txt_nomeProduto
            // 
            this.txt_nomeProduto.Location = new System.Drawing.Point(107, 71);
            this.txt_nomeProduto.Name = "txt_nomeProduto";
            this.txt_nomeProduto.Size = new System.Drawing.Size(122, 23);
            this.txt_nomeProduto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço Produto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 66);
            this.button1.TabIndex = 5;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CProduto";
            this.Text = "Cadastrar Produto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txt_preco;
        private TextBox txt_nomeProduto;
        private Label label2;
        private Button btn_consultarProduto;
        private Button btn_removerProduto;
        private Button btn_cadastrarProduto;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox txt_idProduto;
        private Label label3;
    }
}