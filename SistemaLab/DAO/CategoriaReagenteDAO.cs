using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DAO
{
    public interface CategoriaReagenteDAO
    {
        CategoriaReagente inserir(CategoriaReagente categoriaReagente);
        void remover(CategoriaReagente categoriaReagente);
        CategoriaReagente buscarPorId(int id);
        List<CategoriaReagente> buscarTodos();
    }
}
