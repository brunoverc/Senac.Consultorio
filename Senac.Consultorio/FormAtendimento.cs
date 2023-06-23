using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senac.Consultorio
{
    public partial class FormAtendimento : Form
    {
        List<Paciente> _pacientes;
        //Isso é um construtor
        //Vamos inserir um parâmetro no nosso construtor
        public FormAtendimento(List<Paciente> pacientes)
        {
            InitializeComponent();
            _pacientes = pacientes;
        }

        private void FormAtendimento_Load(object sender, EventArgs e)
        {
            CriarMockup();

            foreach (var paciente in _pacientes)
            {
                cmbPaciente.Items.Add(paciente);
            }
        }

        public void CriarMockup()
        {
            Medico medico1 = new Medico();
            medico1.Nome = "Geraldo";
            medico1.CRM = "0000";
            medico1.Especialidade = "Clinico Geral";
            medico1.DataNascimento = new DateTime(1980, 02, 02);

            Medico medico2 = new Medico();
            medico2.Nome = "Maria José";
            medico2.CRM = "1111";
            medico2.Especialidade = "Neurologista";
            medico2.DataNascimento = new DateTime(1985, 02, 01);

            Medico medico3 = new Medico();
            medico3.Nome = "Aline";
            medico3.CRM = "2222";
            medico3.Especialidade = "Cardiologista";
            medico3.DataNascimento = new DateTime(1989, 01, 30);


            //Procedimentos
            Procedimento procedimento = new Procedimento();
            procedimento.AreaMedica = "Cardiologia";
            procedimento.Nome = "Ecocardiograma";
            procedimento.MedicoProcedimento = medico3;

            cmbProcedimento.Items.Add(procedimento);

            procedimento = new Procedimento();
            procedimento.AreaMedica = "Cardiologia";
            procedimento.Nome = "Ressonância Magnética";
            procedimento.MedicoProcedimento = medico3;

            cmbProcedimento.Items.Add(procedimento);

            procedimento = new Procedimento();
            procedimento.AreaMedica = "Clinico Geral";
            procedimento.Nome = "Ultrassonografia";
            procedimento.MedicoProcedimento = medico1;

            cmbProcedimento.Items.Add(procedimento);

            procedimento = new Procedimento();
            procedimento.AreaMedica = "Clinico Geral";
            procedimento.Nome = "Mamografia";
            procedimento.MedicoProcedimento = medico1;

            cmbProcedimento.Items.Add(procedimento);

            procedimento = new Procedimento();
            procedimento.AreaMedica = "Neurologia";
            procedimento.Nome = "Eletroencefalograma ";
            procedimento.MedicoProcedimento = medico2;

            cmbProcedimento.Items.Add(procedimento);

            procedimento = new Procedimento();
            procedimento.AreaMedica = "Neurologia";
            procedimento.Nome = "Ressonância magnética ";
            procedimento.MedicoProcedimento = medico2;

            cmbProcedimento.Items.Add(procedimento);
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            Paciente paciente = cmbPaciente.SelectedItem as Paciente;
            Procedimento procedimento = cmbProcedimento.SelectedItem as Procedimento;

            Atendimento atendimento = new Atendimento();
            atendimento.DataHoraAtendimento = DateTime.Now;
            atendimento.PacienteAtendido = paciente;
            atendimento.ProcedimentoEfetuado = procedimento;

            string mensagem = "Foi criado um atendimento para o paciente: " +
                atendimento.PacienteAtendido.Nome +
                "\nPara o procedimento: " + atendimento.ProcedimentoEfetuado.Nome +
                "\nCom o médico: " + atendimento.ProcedimentoEfetuado.MedicoProcedimento.Nome +
                "\nNa data e hora: " + atendimento.DataHoraAtendimento.ToString();

            MessageBox.Show(mensagem);

            //Fecha o formulário
            this.Close();
        }
    }
}
