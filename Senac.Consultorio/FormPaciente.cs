namespace Senac.Consultorio
{
    public partial class FormPaciente : Form
    {
        List<Paciente> pacientes = new List<Paciente>();
        public FormPaciente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Criar uma intância de Pacientes.
            Paciente pacienteConsultorio = new Paciente();

            pacienteConsultorio.Nome = txtNome.Text;
            pacienteConsultorio.CPF = txtCPF.Text;
            pacienteConsultorio.DataNascimento = dtpDataNascimento.Value;
            pacienteConsultorio.Telefone = txtTelefone.Text;
            pacienteConsultorio.Altura = Convert.ToDecimal(txtAltura.Text);
            pacienteConsultorio.Peso = Convert.ToDecimal(txtPeso.Text);
            pacienteConsultorio.Endereco = txtEndereco.Text;

            MessageBox.Show("O paciente " + pacienteConsultorio.Nome + " foi cadastrado.");

            //Insere um paciente em uma lista
            pacientes.Add(pacienteConsultorio);
            //.Count vai retornar quantos itens eu tenho na miha lista
            MessageBox.Show("Existem " + pacientes.Count() + " pacientes cadastrados.");
        }
    }
}