using SistemaLab.DAO.DAOImpl;
using SistemaLab.DTO;
using SistemaLab.Model;
using SistemaLab.Model.enums;
using System;
using System.Collections.Generic;

namespace SistemaLab.Controller
{
    public class ResiduoController
    {
        private ResiduoDAOImpl dao = new ResiduoDAOImpl();

        public void cadastrarResiduo(ResiduoDTO residuoDTO)
        {
            Residuo residuo = new Residuo
            {
                Nome = residuoDTO.Nome,
                DataGeracao = residuoDTO.DataGeracao,
                Tipo = residuoDTO.Tipo
            };

            dao.inserir(residuo);
        }

        public List<Residuo> listarResiduos()
        {
            return dao.buscarTodos();
        }

        public void excluirResiduo(Residuo residuo)
        {
            dao.remover(residuo);
        }
    }
}
