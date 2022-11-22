using Desafio02.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Desafio02
{
    public partial class form_cFornecedor : Form
    {
        Thread nt;
        public form_cFornecedor()
        {
            InitializeComponent();
        }

        private void btn_cadastrarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor f = new Fornecedor(int.Parse(txt_idFornecedor.Text),txt_nomeFornecedor.Text);

            bool sucesso = f.cadastrarFornecedor();
            if (sucesso = true)
            {
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            }
            else
            {
                MessageBox.Show("Erro ao salvar", "Atenção");
            }
        }

        private void btn_consultarFornecedores_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from Fornecedor";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView3.DataSource = dt;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm(object? obj)
        {
            Application.Run(new menu());
        }

        private void btn_removerFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor c = new Fornecedor(int.Parse(txt_idFornecedor.Text), txt_nomeFornecedor.Text);

            bool sucesso = c.removerFornecedor();
            if (sucesso = true)
            {
                MessageBox.Show("Removido com sucesso!", "Atenção");
            }
            else
            {
                MessageBox.Show("Erro ao remover", "Atenção");
            }
        }
    }
}
