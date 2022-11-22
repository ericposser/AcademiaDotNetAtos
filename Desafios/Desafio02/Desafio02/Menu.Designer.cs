namespace Desafio02
{
    partial class menu
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_cadastrarNotaFiscal = new System.Windows.Forms.Button();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_notaFiscal_idProduto = new System.Windows.Forms.TextBox();
            this.txt_notaFiscal_idCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_formCliente = new System.Windows.Forms.Button();
            this.btn_formFornecedor = new System.Windows.Forms.Button();
            this.btn_cProduto = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_cadastrarNotaFiscal);
            this.groupBox4.Controls.Add(this.txt_valor);
            this.groupBox4.Controls.Add(this.txt_quantidade);
            this.groupBox4.Controls.Add(this.txt_notaFiscal_idProduto);
            this.groupBox4.Controls.Add(this.txt_notaFiscal_idCliente);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(291, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 207);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nota Fiscal";
            // 
            // btn_cadastrarNotaFiscal
            // 
            this.btn_cadastrarNotaFiscal.Location = new System.Drawing.Point(83, 171);
            this.btn_cadastrarNotaFiscal.Name = "btn_cadastrarNotaFiscal";
            this.btn_cadastrarNotaFiscal.Size = new System.Drawing.Size(100, 23);
            this.btn_cadastrarNotaFiscal.TabIndex = 11;
            this.btn_cadastrarNotaFiscal.Text = "Gerar NF";
            this.btn_cadastrarNotaFiscal.UseVisualStyleBackColor = true;
            this.btn_cadastrarNotaFiscal.Click += new System.EventHandler(this.btn_cadastrarNotaFiscal_Click);
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(83, 142);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 23);
            this.txt_valor.TabIndex = 10;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(92, 107);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(100, 23);
            this.txt_quantidade.TabIndex = 9;
            // 
            // txt_notaFiscal_idProduto
            // 
            this.txt_notaFiscal_idProduto.Location = new System.Drawing.Point(103, 75);
            this.txt_notaFiscal_idProduto.Name = "txt_notaFiscal_idProduto";
            this.txt_notaFiscal_idProduto.Size = new System.Drawing.Size(100, 23);
            this.txt_notaFiscal_idProduto.TabIndex = 8;
            // 
            // txt_notaFiscal_idCliente
            // 
            this.txt_notaFiscal_idCliente.Location = new System.Drawing.Point(97, 28);
            this.txt_notaFiscal_idCliente.Name = "txt_notaFiscal_idCliente";
            this.txt_notaFiscal_idCliente.Size = new System.Drawing.Size(100, 23);
            this.txt_notaFiscal_idCliente.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Valor total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Quantidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Id do Produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id do Cliente";
            // 
            // btn_formCliente
            // 
            this.btn_formCliente.Location = new System.Drawing.Point(177, 12);
            this.btn_formCliente.Name = "btn_formCliente";
            this.btn_formCliente.Size = new System.Drawing.Size(100, 43);
            this.btn_formCliente.TabIndex = 21;
            this.btn_formCliente.Text = "Cadastrar Cliente";
            this.btn_formCliente.UseVisualStyleBackColor = true;
            this.btn_formCliente.Click += new System.EventHandler(this.btn_formCliente_Click_1);
            // 
            // btn_formFornecedor
            // 
            this.btn_formFornecedor.Location = new System.Drawing.Point(347, 12);
            this.btn_formFornecedor.Name = "btn_formFornecedor";
            this.btn_formFornecedor.Size = new System.Drawing.Size(100, 49);
            this.btn_formFornecedor.TabIndex = 22;
            this.btn_formFornecedor.Text = "Cadastrar Fornecedor";
            this.btn_formFornecedor.UseVisualStyleBackColor = true;
            this.btn_formFornecedor.Click += new System.EventHandler(this.btn_formFornecedor_Click);
            // 
            // btn_cProduto
            // 
            this.btn_cProduto.Location = new System.Drawing.Point(518, 15);
            this.btn_cProduto.Name = "btn_cProduto";
            this.btn_cProduto.Size = new System.Drawing.Size(100, 43);
            this.btn_cProduto.TabIndex = 23;
            this.btn_cProduto.Text = "Cadastrar Produto";
            this.btn_cProduto.UseVisualStyleBackColor = true;
            this.btn_cProduto.Click += new System.EventHandler(this.btn_cProduto_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 427);
            this.Controls.Add(this.btn_cProduto);
            this.Controls.Add(this.btn_formFornecedor);
            this.Controls.Add(this.btn_formCliente);
            this.Controls.Add(this.groupBox4);
            this.Name = "menu";
            this.Text = "Menu";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox4;
        private TextBox txt_valor;
        private TextBox txt_quantidade;
        private TextBox txt_notaFiscal_idProduto;
        private TextBox txt_notaFiscal_idCliente;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btn_cadastrarNotaFiscal;
        private Button btn_formCliente;
        private Button btn_formFornecedor;
        private Button btn_cProduto;
    }
}