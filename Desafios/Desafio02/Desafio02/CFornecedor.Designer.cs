namespace Desafio02
{
    partial class form_cFornecedor
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
            this.txt_idFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_consultarFornecedores = new System.Windows.Forms.Button();
            this.btn_removerFornecedor = new System.Windows.Forms.Button();
            this.btn_cadastrarFornecedor = new System.Windows.Forms.Button();
            this.txt_nomeFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_idFornecedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_consultarFornecedores);
            this.groupBox1.Controls.Add(this.btn_removerFornecedor);
            this.groupBox1.Controls.Add(this.btn_cadastrarFornecedor);
            this.groupBox1.Controls.Add(this.txt_nomeFornecedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(226, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Fornecedor";
            // 
            // txt_idFornecedor
            // 
            this.txt_idFornecedor.Location = new System.Drawing.Point(38, 22);
            this.txt_idFornecedor.Name = "txt_idFornecedor";
            this.txt_idFornecedor.Size = new System.Drawing.Size(51, 23);
            this.txt_idFornecedor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // btn_consultarFornecedores
            // 
            this.btn_consultarFornecedores.Location = new System.Drawing.Point(140, 110);
            this.btn_consultarFornecedores.Name = "btn_consultarFornecedores";
            this.btn_consultarFornecedores.Size = new System.Drawing.Size(107, 43);
            this.btn_consultarFornecedores.TabIndex = 4;
            this.btn_consultarFornecedores.Text = "Consultar Fornecedores";
            this.btn_consultarFornecedores.UseVisualStyleBackColor = true;
            this.btn_consultarFornecedores.Click += new System.EventHandler(this.btn_consultarFornecedores_Click);
            // 
            // btn_removerFornecedor
            // 
            this.btn_removerFornecedor.Location = new System.Drawing.Point(95, 81);
            this.btn_removerFornecedor.Name = "btn_removerFornecedor";
            this.btn_removerFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btn_removerFornecedor.TabIndex = 3;
            this.btn_removerFornecedor.Text = "Remover";
            this.btn_removerFornecedor.UseVisualStyleBackColor = true;
            this.btn_removerFornecedor.Click += new System.EventHandler(this.btn_removerFornecedor_Click);
            // 
            // btn_cadastrarFornecedor
            // 
            this.btn_cadastrarFornecedor.Location = new System.Drawing.Point(185, 81);
            this.btn_cadastrarFornecedor.Name = "btn_cadastrarFornecedor";
            this.btn_cadastrarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrarFornecedor.TabIndex = 2;
            this.btn_cadastrarFornecedor.Text = "Salvar";
            this.btn_cadastrarFornecedor.UseVisualStyleBackColor = true;
            this.btn_cadastrarFornecedor.Click += new System.EventHandler(this.btn_cadastrarFornecedor_Click);
            // 
            // txt_nomeFornecedor
            // 
            this.txt_nomeFornecedor.Location = new System.Drawing.Point(131, 52);
            this.txt_nomeFornecedor.Name = "txt_nomeFornecedor";
            this.txt_nomeFornecedor.Size = new System.Drawing.Size(129, 23);
            this.txt_nomeFornecedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Fornecedor";
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(29, 28);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(112, 59);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.Text = "MENU";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 235);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(776, 191);
            this.dataGridView3.TabIndex = 4;
            // 
            // form_cFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_cFornecedor";
            this.Text = "Cadastrar Fornecedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_removerFornecedor;
        private Button btn_cadastrarFornecedor;
        private TextBox txt_nomeFornecedor;
        private Label label1;
        private Button btn_consultarFornecedores;
        private Button btn_menu;
        private DataGridView dataGridView3;
        private TextBox txt_idFornecedor;
        private Label label2;
    }
}