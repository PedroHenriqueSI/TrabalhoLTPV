using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITPAC.LTPV.Dominio.AlunosRoot
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Matricula { get; set; }
        public string Observacoes { get; set; }
    }
}
