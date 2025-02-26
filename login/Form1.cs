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

            if (usuario == "Eliezer.Santos" && senha == "12345678")
            {

                labelResultado.Text = "Usuario autenticado com sucesso";
                labelResultado.ForeColor = System.Drawing.Color.Green;

            }

            else
            {
                labelResultado.Text = "Usuario e senha incorretos";
                labelResultado.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }
    }
}

