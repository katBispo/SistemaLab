using SistemaLab.Model;
using System;
using System.Collections.Generic;

namespace SistemaLab.DAO.DAOImpl
{
    public class ResiduoDAOImpl : ResiduoDAO
    {
        private static List<Residuo> residuos = new List<Residuo>();
        private static int con = 0;

        // Construtor padrão
        public ResiduoDAOImpl()
        {
         
        }

        public Residuo buscarPorId(int id)
        {
            Residuo residuo = residuos.Find(r => r.id == id);
            return residuo;
        }

        public List<Residuo> buscarTodos()
        {
            return new List<Residuo>(residuos);
        }

        public Residuo inserir(Residuo residuo)
        {
            residuo.id = con++;
            residuos.Add(residuo);
            return residuo;
        }

        public void remover(Residuo residuo)
        {
            residuos.RemoveAll(r => r.id == residuo.id);
        }
    }
}
