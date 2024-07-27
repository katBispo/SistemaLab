using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLab.Model;
using SistemaLab.DAO.DB;

namespace SistemaLab.DAO.DAOImpl
{
    public class CategoriaReagenteDAOImpl : CategoriaReagenteDAO
    {
        private readonly LabContext _context;

        public CategoriaReagente buscarPorId(int id)
        {
            CategoriaReagente categoriaReagente = _context.CategoriaReagentes.Find(id);
            return categoriaReagente;
        }

        public List<CategoriaReagente> buscarTodos()
        {
            List<CategoriaReagente> categoriaReagentes = _context.CategoriaReagentes.ToList();
            return categoriaReagentes;
        }

        public CategoriaReagente inserir(CategoriaReagente categoriaReagente)
        {
            _context.CategoriaReagentes.Add(categoriaReagente);
            _context.SaveChanges();
            return categoriaReagente;
        }

        
        public void  remover(CategoriaReagente categoriaReagente)
        {
            _context.CategoriaReagentes.Remove(categoriaReagente);
            _context.SaveChanges();
        }
    }
}
