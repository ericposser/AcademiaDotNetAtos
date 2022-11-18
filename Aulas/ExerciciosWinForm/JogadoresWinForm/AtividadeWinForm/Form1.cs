namespace AtividadeWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StreamReader leitor = new StreamReader("jogadores.txt");
            string linha;
            string[] vetorDados;
            do
            {
                linha = leitor.ReadLine();

                vetorDados = linha.Split(";");

                listaJogadores.Add(new Jogador(vetorDados[0], vetorDados[1]));

                txt_listaJogador.AppendText(vetorDados[0] + " - " + vetorDados[1] + Environment.NewLine);

            } while (!leitor.EndOfStream);

            leitor.Close();
        }

        private void btn_gravar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_nomeJogador.Text.Equals("")){
                MessageBox.Show("é preciso digitar algo" , "ALERTA");
                return;
            }

            txt_nomeJogador.Text = txt_nomeJogador.Text.ToUpper();

            string email;

            if (Jogador.jaCadastrado(txt_nomeJogador.Text, listaJogadores))
            {
                MessageBox.Show("Jogador ja cadastrado!" , "ALERTA");
            }
            else
            {
                string[] vetorNomes = txt_nomeJogador.Text.ToLower().Split(" ");

                if(vetorNomes.Length > 1)
                {
                    email = vetorNomes[vetorNomes.Length - 1] + "." + vetorNomes[0] + "@ufn.edu.br";
                }
                else
                {
                    email = vetorNomes[0] + "@ufn.edu.br";
                }

                listaJogadores.Add(new Jogador(txt_nomeJogador.Text, email));

                txt_listaJogador.AppendText(txt_nomeJogador.Text + " - " + email + Environment.NewLine);

                StreamWriter escritor = new StreamWriter("jogadores.txt", true);

                escritor.WriteLine(txt_nomeJogador.Text + ";" + email);

                escritor.Close();
            }
            txt_nomeJogador.Text = "";
        }

        private void btn_limpar_MouseClick(object sender, MouseEventArgs e)
        {
            txt_nomeJogador.Text = "";
            txt_listaJogador.Text = "";
            listaJogadores.Clear();
        }

        List<Jogador> listaJogadores = new List<Jogador>();

    }
}