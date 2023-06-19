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
            lblQuantidadePacientes.Text = pacientes.Count().ToString();

            cmbListaPacientes.Items.Add(pacienteConsultorio);
        }

        private void cmbListaPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1. pegar o cpf do paciente selecionado
            Paciente pacienteSelecionado = cmbListaPacientes.SelectedItem as Paciente;
            string cpf = pacienteSelecionado.CPF;

            //2. Buscar os dados do paciente selecionado na minha lista
            //Use o Where quando quiser buscar com uma condição (QUANDO)
            Paciente paciente = pacientes.Where(p => p.CPF == cpf).First();

            //3. Carregar os dados nos campos do formulário
        }
    }
}