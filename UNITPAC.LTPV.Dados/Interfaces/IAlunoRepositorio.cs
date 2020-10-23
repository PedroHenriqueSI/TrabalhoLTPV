using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNITPAC.LTPV.Dominio.AlunosRoot;

namespace UNITPAC.LTPV.Dados.Interfaces
{
    public interface IAlunoRepositorio
    {
        List<Aluno> ObterTodos();
    }
}
