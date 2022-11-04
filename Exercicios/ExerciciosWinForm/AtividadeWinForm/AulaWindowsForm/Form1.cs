namespace AulaWindowsForm
{
    public partial class FormMain : Form
    {
        //iniciando a lista
        List<string> listaNomes = new List<string>();

        public FormMain()
        {
            InitializeComponent();
        }

        //botao para adicionar nome na lista
        private void btn_adicionarNaLista_Click(object sender, EventArgs e)
        {
            inserirTextBox_lista();
        }

        //text box para digitar nomes
        private void txt_nomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                inserirTextBox_lista();
            }
        }

        //inserindo nomes da lista
        private void inserirTextBox_lista()
        {
           
            if (txt_nomeCompleto.Text.Length == 0 || !txt_nomeCompleto.Text.Contains(" "))
            {
                MessageBox.Show("Para adicionar nome, é preciso digitar algo ou digitar nome completo", "ATENÇÃO");
            }
            else
            {
                //verificar se o nome já existe
                if (listaNomes.Contains(txt_nomeCompleto.Text.ToUpper()))
                {
                    MessageBox.Show("Nome já cadastrado", "ATENÇÃO");
                }
                else
                {
                    listaNomes.Add(txt_nomeCompleto.Text.ToUpper());

                    listaNomes.Sort();

                    //inserir o conteúdo da lista ordenado
                    atualizarTextBox_lista();

                    txt_nomeCompleto.Text = String.Empty;
                }
            }
            txt_nomeCompleto.Focus();
        }

        //atualiza a lista de nomes
        private void atualizarTextBox_lista()
        {
            txt_listaNomes.Text = String.Empty;

            foreach (var i in listaNomes)
            {
                txt_listaNomes.Text += i + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
