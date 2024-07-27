using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DAO
{
    public interface TecnicoDAO
    {
        Tecnico inserir(Tecnico tecnico);
        void remover(Tecnico tecnico);
        Tecnico buscarPorId(int id);
        List<Tecnico> buscarTodos();
    }
}
