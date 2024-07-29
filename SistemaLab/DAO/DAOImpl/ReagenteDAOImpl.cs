
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
        private static List<Reagente> reagentes = new List<Reagente>();
        private static int con = 0;

        public ReagenteDAOImpl( )
        {
          
        }
        public Reagente buscarPorId(int id)
        {
            Reagente reagente = reagentes.Find(r => r.id == id);
            return reagente;
        }

        public List<Reagente> buscarTodos()
        {
         

            return new List<Reagente>(reagentes);
        }

        public Reagente inserir(Reagente reagente)
        {
            reagente.id = con++;
            reagentes.Add(reagente);
            return reagente!;
        }


        public void remover(Reagente reagente)
        {
            reagentes.RemoveAll(r =>  r.id == reagente.id);
        }
    }
}
