using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Consultorio
{
    public class Paciente
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string UltimoProcedimento { get; set; }
    }
}
