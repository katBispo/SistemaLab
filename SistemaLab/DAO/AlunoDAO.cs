using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLab.Model;
namespace SistemaLab.DAO
{
    public interface AlunoDAO
    {
        Aluno inserir(Aluno aluno);
        void remover(Aluno aluno);
        Aluno buscarPorId(int id);
        List<Aluno> buscarTodos();
    }
}
