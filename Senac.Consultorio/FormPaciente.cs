using System.Runtime.ExceptionServices;

namespace Senac.Consultorio
{
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
        }

        //Criação de uma lista do tipo Paciente
        List<Paciente> pacientes = new List<Paciente>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Paciente pacienteCadastrado = new Paciente();

            pacienteCadastrado.Nome = txtNome.Text;
            pacienteCadastrado.CPF = txtCPF.Text;
            pacienteCadastrado.Altura = Convert.ToDecimal(txtAltura.Text);
            pacienteCadastrado.Endereco = txtEndereco.Text;
            pacienteCadastrado.DataNascimento = dtpDataNascimento.Value;
            pacienteCadastrado.Peso = Convert.ToDecimal(txtPeso.Text);

            pacientes.Add(pacienteCadastrado);

            MessageBox.Show("O paciente: " + pacienteCadastrado.Nome +
                " foi cadastrado.");

            lblQuantidadePacientes.Text = pacientes.Count().ToString();
        }

        public void CriaPacientesMockup()
        {
            Paciente paciente = new Paciente();
            paciente.Nome = "Joaquim";
            paciente.Altura = 1.75m;
            //paciente.UltimoProcedimento = "Consulta oftalmo";
            paciente.DataNascimento = new DateTime(1989, 09, 28);
            paciente.Endereco = "Rua 1";
            paciente.CPF = "000.000.000-00";
            paciente.Peso = 74;
            paciente.Telefone = "(64)9999-9999";

            pacientes.Add(paciente);

            paciente = new Paciente();
            paciente.Nome = "Maria";
            paciente.Altura = 1.60m;
            //paciente.UltimoProcedimento = "Cirurgia";
            paciente.DataNascimento = new DateTime(2000, 01, 17);
            paciente.Endereco = "Rua 2";
            paciente.CPF = "111.111.111-11";
            paciente.Peso = 50;
            paciente.Telefone = "(64)8888-9999";

            pacientes.Add(paciente);

            paciente = new Paciente();
            paciente.Nome = "Rufino";
            paciente.Altura = 1.80m;
            //paciente.UltimoProcedimento = "Endoscopia";
            paciente.DataNascimento = new DateTime(2000, 12, 25);
            paciente.Endereco = "Rua 3";
            paciente.CPF = "222.222.222-22";
            paciente.Peso = 80;
            paciente.Telefone = "(64)7777-9999";

            pacientes.Add(paciente);

            paciente = new Paciente();
            paciente.Nome = "José";
            paciente.Altura = 1.90m;
            //paciente.UltimoProcedimento = "Geral";
            paciente.DataNascimento = new DateTime(1985, 05, 13);
            paciente.Endereco = "Rua 3";
            paciente.CPF = "333.333.333-33";
            paciente.Peso = 90;
            paciente.Telefone = "(64)6666-9999";

            pacientes.Add(paciente);
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            CriaPacientesMockup();
            lblQuantidadePacientes.Text = pacientes.Count().ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Verificar se digitou alguma coisa no campo de busca
            if(txtBuscaPorCPF.Text != "")
            {
                //var cria um objeto do tipo do que é retornado a direita da atribuição
                //where vai receber uma lambda com uma consulta
                var pacientesEncontrados = pacientes.Where(p => p.CPF == txtBuscaPorCPF.Text);
                //Any retorna se existe alguma coisa na lista
                if(pacientesEncontrados.Any())
                {
                    //First traz o primeiro registro encontrado na lista
                    Paciente pacienteEncontrado = pacientesEncontrados.First();
                    CarregaDadosPaciente(pacienteEncontrado);
                }
                else
                {
                    MessageBox.Show("A busca não retornou nenhum dado");
                }
            }
            else
            {
                MessageBox.Show("Você deve digitar o CPF para busca");
            }
        }

        public void CarregaDadosPaciente(Paciente paciente)
        {
            txtNome.Text = paciente.Nome;
            txtAltura.Text = paciente.Altura.ToString();
            txtPeso.Text = paciente.Peso.ToString();
            txtCPF.Text = paciente.CPF;
            txtEndereco.Text = paciente.Endereco;
            dtpDataNascimento.Value = paciente.DataNascimento;
            txtTelefone.Text = paciente.Telefone;
        }
    }
}