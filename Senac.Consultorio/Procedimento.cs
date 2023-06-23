using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Consultorio
{
    public class Procedimento
    {
        public string Nome { get; set; }
        public string AreaMedica { get; set; }
        public Medico MedicoProcedimento { get; set; }
    }
}
