using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DAO
{
    public interface ReagenteDAO
    {
        Reagente inserir(Reagente reagente);
        void remover(Reagente reagente);
        Reagente buscarPorId(int id);
        List<Reagente> buscarTodos();
    }
}
