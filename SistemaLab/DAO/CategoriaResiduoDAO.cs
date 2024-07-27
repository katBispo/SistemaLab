using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DAO
{
    public interface CategoriaResiduoDAO
    {
        CategoriaResiduo inserir(CategoriaResiduo categoriaResiduo);
        void remover(CategoriaResiduo categoriaResiduo);
        CategoriaResiduo buscarPorId(int id);
        List<CategoriaResiduo> buscarTodos();
    }
}
