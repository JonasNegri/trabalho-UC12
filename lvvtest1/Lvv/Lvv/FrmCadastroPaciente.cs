namespace Lvv
{
    public partial class FrmCadastroPaciente : Form
    {

        public FrmCadastroPaciente()
        {
            InitializeComponent();
        }

        public FrmCadastroPaciente(string nomeFamiliar)
        {    
        InitializeComponent();
            TxtNomeFamiliarPaciente.Text = nomeFamiliar;
        }

        public void ReceberNomeFamiliar(string nomeFamiliar)
        {
            TxtNomeFamiliarPaciente.Text = nomeFamiliar;
        }

        public void BtnFamiliar_Click(object sender, EventArgs e)
        {

            string nomePaciente = TxtNomePaciente.Text;
            dadd cadastroFamiliar = new dadd(nomePaciente, this);
            cadastroFamiliar.Show();


        }

        public void TxtNomePaciente_TextChanged(object sender, EventArgs e)

        {
            string Nome = TxtNomePaciente.Text;

        }
        public void CapturarNome()
        {
            string Nome = TxtNomePaciente.Text;
        }
    }
}
