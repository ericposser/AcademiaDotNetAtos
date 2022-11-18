namespace AulaSQLcomWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departamento d = new Departamento(txt_nome.Text, txt_localizacao.Text, txt_orcamento.Text);

            bool sucesso = d.gravarDepartamento();
            if (sucesso = true)
            {
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            }
            else
            {
                MessageBox.Show("Erro ao salvar", "Atenção");
            }
        }
    }
}