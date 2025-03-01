using System.Diagnostics.Eventing.Reader;

namespace login
{
    public partial class FormLogin : Form
    {
        List<string> listaUsuarios = new List<string>() { "lari.Matos", "kaique", "mickael" };
        List<string> Listasenha = new List<string>() { "1717", "0707", "0303" };

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = textBoxU.Text;
            string senha = textboxSenha.Text;



            /* if (usuario == null && senha == "")
             {
                 labelResultado.Text = "Voce precisa de um Usuário e senha";
                 labelResultado.ForeColor = System.Drawing.Color.Red;
                 return;
             }*/

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = "usuario eh obrgatorio!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (usuarioBuscado == null || senha == "")
            {

                labelResultado.Text = "senha necessaria";
                labelResultado.ForeColor = System.Drawing.Color.Red;

            }

            int posicaoUsuarioEncontrado = -1;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuarioBuscado == listaUsuarios[i])
                {

                }
                {
                    posicaoUsuarioEncontrado = i;

                }
                if (posicaoUsuarioEncontrado > -1 && senha == "1717")
                {
                    labelResultado.Text = "Autenticado com sucesso !";
                    labelResultado.ForeColor = Color.Green;

                }


                else if (usuarioBuscado == "Eliezer.Santos" || senha == "12345678")
                {
                    labelResultado.Text = "Autenticado com sucesso !";
                    labelResultado.ForeColor = Color.Green;
                }


                else if (usuarioBuscado == "Eliezer.Santos" && senha == "")
                {
                    labelResultado.Text = "Usuario e senha incorretos";
                    labelResultado.ForeColor = System.Drawing.Color.Red;
                }

                else
                {
                    labelResultado.Text = "usuario ou senha incorretos...";
                    labelResultado.ForeColor = Color.Red;
                }

                /*private void button2_Click(object sender, EventArgs e)
                {
                    Random random = new Random();
                    int index = random.Next(0, 3);

                    string[] textos = { "Texto 1", "Texto 2", "Texto 3" };
                    string textoSelecionado = textos[index];
                }

              
                private void textBox1_TextChanged(object sender, EventArgs e)*/
                {

                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string NovoUsuarioBuscado = textNovoCadastro.Text;
            string Novasenha = texteNovaSenha.Text;

            if (string.IsNullOrWhiteSpace(NovoUsuarioBuscado))
            {
                labelResultado.Text = "usuario e obrgatorio!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(Novasenha))
            {

                labelResultado.Text = "Novo Usuario e senha necessaria";
                labelResultado.ForeColor = System.Drawing.Color.Red;

            }

            bool usuarioBuscado = false;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (NovoUsuarioBuscado == listaUsuarios[i])
                {
                    usuarioBuscado = true;
                }


            }
            if (!usuarioBuscado)
            {
                listaUsuarios.Add(NovoUsuarioBuscado);
                listaUsuarios.Add(Novasenha);
                labelResultado.Text = "Autenticado com sucesso !";
                labelResultado.ForeColor = Color.Green;
            }
           else 
            {
            
                labelResultado.Text = "usuario JÁ Cadastrado, tente denovo ";
                labelResultado.ForeColor = System.Drawing.Color.Red;

            }
        }
    }
}  