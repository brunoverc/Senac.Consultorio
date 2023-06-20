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
            pacienteConsultorio.UltimoProcedimento = txtUltimoProcedimento.Text;

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
            CarregaDadosPaciente(paciente);
        }

        // Visibilidade
        // Tipo de retorno (Use void quando não quiser retornar nada)
        // Nome do método
        // Entre parenteses vem todos os parâmetros
        public void CarregaDadosPaciente(Paciente dadosPaciente)
        {
            txtNome.Text = dadosPaciente.Nome;
            txtCPF.Text = dadosPaciente.CPF;
            dtpDataNascimento.Value = dadosPaciente.DataNascimento;
            txtTelefone.Text = dadosPaciente.Telefone;
            txtAltura.Text = dadosPaciente.Altura.ToString();
            txtPeso.Text = dadosPaciente.Peso.ToString();
            txtEndereco.Text = dadosPaciente.Endereco;
            txtUltimoProcedimento.Text = dadosPaciente.UltimoProcedimento;
        }

        public void CriaPacientesMockup()
        {
            Paciente paciente = new Paciente();
            paciente.Nome = "Joaquim";
            paciente.Altura = 1.75m;
            paciente.UltimoProcedimento = "Consulta oftalmo";
            paciente.DataNascimento = new DateTime(1989, 09, 28);
            paciente.Endereco = "Rua 1";
            paciente.CPF = "000.000.000-00";
            paciente.Peso = 74;

            pacientes.Add(paciente);
            cmbListaPacientes.Items.Add(paciente);

            paciente = new Paciente();
            paciente.Nome = "Maria";
            paciente.Altura = 1.60m;
            paciente.UltimoProcedimento = "Cirurgia";
            paciente.DataNascimento = new DateTime(2000, 01, 17);
            paciente.Endereco = "Rua 2";
            paciente.CPF = "111.111.111-11";
            paciente.Peso = 50;

            pacientes.Add(paciente);
            cmbListaPacientes.Items.Add(paciente);

            paciente = new Paciente();
            paciente.Nome = "Rufino";
            paciente.Altura = 1.80m;
            paciente.UltimoProcedimento = "Endoscopia";
            paciente.DataNascimento = new DateTime(2000, 12, 25);
            paciente.Endereco = "Rua 3";
            paciente.CPF = "222.222.222-22";
            paciente.Peso = 80;

            pacientes.Add(paciente);
            cmbListaPacientes.Items.Add(paciente);

            paciente = new Paciente();
            paciente.Nome = "José";
            paciente.Altura = 1.90m;
            paciente.UltimoProcedimento = "Geral";
            paciente.DataNascimento = new DateTime(1985, 05, 13);
            paciente.Endereco = "Rua 3";
            paciente.CPF = "333.333.333-33";
            paciente.Peso = 90;

            pacientes.Add(paciente);
            cmbListaPacientes.Items.Add(paciente);
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            CriaPacientesMockup();
            lblQuantidadePacientes.Text = pacientes.Count().ToString();
        }
    }
}