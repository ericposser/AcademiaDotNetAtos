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
    public partial class form_cCliente : Form
    {
        Thread nt;
        public form_cCliente()
        {
            InitializeComponent();
        }

        private void btn_cadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(int.Parse(txt_idCliente.Text),txt_nomeCliente.Text, txt_telefone.Text);

            bool sucesso = c.cadastrarCliente();
            if (sucesso = true)
            {
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            }
            else
            {
                MessageBox.Show("Erro ao salvar", "Atenção");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from Cliente";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView2.DataSource = dt;
        }

        private void novoForm(object? obj)
        {
            Application.Run(new menu());
        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void btn_removerCliente_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(int.Parse(txt_idCliente.Text),txt_nomeCliente.Text, txt_telefone.Text);

            bool sucesso = c.removerCliente();
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
