using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DAO.DAOImpl
{
    public class AlunoDAOImpl : AlunoDAO
    {
        private static List<Aluno> alunos = new List<Aluno>();

        public Aluno buscarPorId(int id)
        {
            Aluno aluno = alunos.Find(x => x.Id == id);
            return aluno;
        }

        public List<Aluno> buscarTodos()
        {
            return new List<Aluno>(alunos); 
        }

        public Aluno inserir(Aluno aluno)
        {
          alunos.Add(aluno);
          return aluno;
        }

        public void remover(Aluno aluno)
        {
            alunos.RemoveAll(a => a.Id == aluno.Id);
        }
    }
}
