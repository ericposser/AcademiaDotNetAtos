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
    public partial class CProduto : Form
    {
        Thread nt;
        public CProduto()
        {
            InitializeComponent();
        }

        private void btn_cadastrarProduto_Click(object sender, EventArgs e)
        {
            Produto p = new Produto(int.Parse(txt_idProduto.Text), txt_nomeProduto.Text, float.Parse(txt_preco.Text));

            bool sucesso = p.cadastrarProduto();
            if (sucesso = true)
            {
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            }
            else
            {
                MessageBox.Show("Erro ao salvar", "Atenção");
            }
        }

        private void btn_consultarProduto_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from Produto";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;
        }

        private void formMenu(object? obj)
        {
            Application.Run(new menu());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(formMenu);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void btn_removerProduto_Click(object sender, EventArgs e)
        {
            Produto c = new Produto(int.Parse(txt_idProduto.Text), txt_nomeProduto.Text, float.Parse(txt_preco.Text));

            bool sucesso = c.removerProduto();
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
