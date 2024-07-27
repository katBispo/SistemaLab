using SistemaLab.DAO.DB;
using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DAO.DAOImpl
{
    public class ReagenteDAOImpl : ReagenteDAO
    {
        private readonly LabContext _context;

        public Reagente buscarPorId(int id)
        {
            Reagente reagente = _context.Reagentes.Find(id);
            return reagente;
        }

        public List<Reagente> buscarTodos()
        {
            List<Reagente> categoriaReagentes = _context.Reagentes.ToList();
            return categoriaReagentes;
        }

        public Reagente inserir(Reagente reagente)
        {
            _context.Reagentes.Add(reagente);
            _context.SaveChanges();
            return reagente;
        }


        public void remover(Reagente reagente)
        {
            _context.Reagentes.Remove(reagente);
            _context.SaveChanges();
        }
    }
}
