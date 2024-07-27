using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DAO
{
    public interface ResiduoDAO
    {
        Residuo inserir(Residuo residuo);
        void remover(Residuo residuo);
        Residuo buscarPorId(int id);
        List<Residuo> buscarTodos();
    }
}
