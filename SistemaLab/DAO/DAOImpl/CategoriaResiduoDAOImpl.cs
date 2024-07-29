using SistemaLab.Model;
using System;
using System.Collections.Generic;

namespace SistemaLab.DAO.DAOImpl
{
    public class CategoriaResiduoDAOImpl : CategoriaResiduoDAO
    {
        private static List<CategoriaResiduo> categoriaResiduos = new List<CategoriaResiduo>();
        private static int con = 0;

        public CategoriaResiduoDAOImpl()
        {
          
        }

        public CategoriaResiduo buscarPorId(int id)
        {
            CategoriaResiduo categoriaResiduo = categoriaResiduos.Find(c => c.id == id);
            return categoriaResiduo;
        }

        public List<CategoriaResiduo> buscarTodos()
        {
            return new List<CategoriaResiduo>(categoriaResiduos);
        }

        public CategoriaResiduo inserir(CategoriaResiduo categoriaResiduo)
        {
            categoriaResiduo.id = con++;
            categoriaResiduos.Add(categoriaResiduo);
            return categoriaResiduo;
        }

        public void remover(CategoriaResiduo categoriaResiduo)
        {
            categoriaResiduos.RemoveAll(c => c.id == categoriaResiduo.id);
        }
    }
}
