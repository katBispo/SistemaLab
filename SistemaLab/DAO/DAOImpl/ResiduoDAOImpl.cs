using SistemaLab.DAO.DB;
using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DAO.DAOImpl
{
    public class ResiduoDAOImpl : ResiduoDAO
    {
        private readonly LabContext _context;

        public Residuo buscarPorId(int id)
        {
            Residuo residuo = _context.Residuos.Find(id);
            return residuo;
        }

        public List<Residuo> buscarTodos()
        {
            List<Residuo> residuos = _context.Residuos.ToList();
            return residuos;
        }

        public Residuo inserir(Residuo residuo)
        {
            _context.Residuos.Add(residuo);
            _context.SaveChanges();
            return residuo;
        }


        public void remover(Residuo residuo)
        {
            _context.Residuos.Remove(residuo);
            _context.SaveChanges();
        }
    }
}
