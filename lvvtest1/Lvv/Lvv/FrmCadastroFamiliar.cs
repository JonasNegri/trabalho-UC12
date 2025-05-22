using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lvv
{
    public partial class dadd : Form
    {

        private FrmCadastroPaciente _formPaciente;

        public dadd(string nomePaciente, FrmCadastroPaciente formPaciente)
        {
            InitializeComponent();
            txtNomePacienteFamiliar.Text = nomePaciente;
            _formPaciente = formPaciente;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void dadd_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string nomeFamiliar = TxtBoxFamiliar.Text;
            _formPaciente.ReceberNomeFamiliar(nomeFamiliar);
            this.Close();

        }
    }
}
