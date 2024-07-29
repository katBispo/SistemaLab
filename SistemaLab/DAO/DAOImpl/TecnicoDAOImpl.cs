using SistemaLab.Model;
using System;
using System.Collections.Generic;

namespace SistemaLab.DAO.DAOImpl
{
    public class TecnicoDAOImpl : TecnicoDAO
    {
        private static List<Tecnico> tecnicos = new List<Tecnico>();
        private static int con = 0;

        public TecnicoDAOImpl()
        {
            if (tecnicos == null)
            {
                tecnicos = new List<Tecnico>();
            }
        }

        public Tecnico buscarPorId(int id)
        {
            Tecnico tecnico = tecnicos.Find(t => t.Id == id);
            return tecnico;
        }

        public List<Tecnico> buscarTodos()
        {
            // Retorna uma nova lista para evitar modificações externas
            return new List<Tecnico>(tecnicos);
        }

        public Tecnico inserir(Tecnico tecnico)
        {
            tecnico.Id = con++;
            tecnicos.Add(tecnico);
            return tecnico;
        }

        // Método para remover um técnico
        public void remover(Tecnico tecnico)
        {
            tecnicos.RemoveAll(t => t.Id == tecnico.Id);
        }
    }
}
