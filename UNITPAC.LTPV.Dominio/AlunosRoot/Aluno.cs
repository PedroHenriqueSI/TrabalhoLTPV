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
        public string Name { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Matricula { get; set; }
    }
}
