using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNITPAC.LTPV.Dados.Interfaces;
using UNITPAC.LTPV.Dominio.AlunosRoot;

namespace UNITPAC.LTPV.Dados.Repositorios
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private List<Aluno> _alunos;
        public AlunoRepositorio()
        {
            _alunos = new List<Aluno>();
            _alunos.Add(new Aluno() { Id = 1,
                Nome = "Pedro",
                SobreNome = "Henrique",
                DataNascimento = new DateTime(2000, 1, 1),
                Matricula = "1111",
                Observacoes = "Melhor de todos."
            });
            _alunos.Add(new Aluno()
            {
                Id = 2,
                Nome = "Amancio",
                SobreNome = "Coutinho",
                Matricula = "666",
                DataNascimento = new DateTime(1960, 03, 21),
                Observacoes = "Pessimo, uma porta ambulante."
            });
            _alunos.Add(new Aluno()
            {
                Id = 3,
                Nome = "Gabriel",
                SobreNome = "Rezende",
                Matricula = "6666",
                DataNascimento = new DateTime(1975, 04, 14),
                Observacoes = "Pior que isso, impossível, as quatro paredes da sala são mais competentes."
            });
            _alunos.Add(new Aluno()
            {
                Id = 4,
                Nome = "Vinicius",
                SobreNome = "Reis",
                Matricula = "777",
                DataNascimento = new DateTime(1873, 07, 20),
                Observacoes = "Bom aluno, competente."
            });
        }
        public List<Aluno> ObterTodos()
        {
            return _alunos;
        }
    }
}
