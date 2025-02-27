using System.Diagnostics.Eventing.Reader;

namespace login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBoxU.Text;
            string senha = textboxSenha.Text;



           /* if (usuario == null && senha == "")
            {
                labelResultado.Text = "Voce precisa de um Usuário e senha";
                labelResultado.ForeColor = System.Drawing.Color.Red;
                return;
            }*/

            if (usuario == "Eliezer.Santos" && senha == "")
            {
                labelResultado.Text = "você precisa de uma senha! " +
                    " clique em redefinir senha. ";
                labelResultado.ForeColor = System.Drawing.Color.Yellow;
            }

            else if (usuario == "Eliezer.Santos" && senha == "12345678")
            {

                labelResultado.Text = "Usuario autenticado com sucesso";
                labelResultado.ForeColor = System.Drawing.Color.Green;

            }


            else if (usuario == null || senha == "")
            {
                labelResultado.Text = "Voce precisa de um Usuário e senha";
                labelResultado.ForeColor = System.Drawing.Color.YellowGreen;
                return;
            }

            else
            {
                labelResultado.Text = "Usuario e senha incorretos";
                labelResultado.ForeColor = System.Drawing.Color.Red;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(0, 3);

            string[] textos = { "Texto 1", "Texto 2", "Texto 3" };
            string textoSelecionado = textos[index];
        }
    }
}

