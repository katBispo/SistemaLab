using SistemaLab.Model;
using System;
using System.Collections.Generic;

namespace SistemaLab.DAO.DAOImpl
{
    public class CategoriaReagenteDAOImpl : CategoriaReagenteDAO
    {
        private static List<CategoriaReagente> categoriaReagentes = new List<CategoriaReagente>();
        private static int con = 0;

        // Construtor padrão
        public CategoriaReagenteDAOImpl()
        {
          
        }

        public CategoriaReagente buscarPorId(int id)
        {
            CategoriaReagente categoriaReagente = categoriaReagentes.Find(c => c.Id == id);
            return categoriaReagente;
        }

        public List<CategoriaReagente> buscarTodos()
        {
            return new List<CategoriaReagente>(categoriaReagentes);
        }

        public CategoriaReagente inserir(CategoriaReagente categoriaReagente)
        {
            categoriaReagente.id = con++;
            categoriaReagentes.Add(categoriaReagente);
            return categoriaReagente;
        }

        // Método para remover uma categoria de reagente
        public void remover(CategoriaReagente categoriaReagente)
        {
            categoriaReagentes.RemoveAll(c => c.id == categoriaReagente.id);
        }
    }
}
