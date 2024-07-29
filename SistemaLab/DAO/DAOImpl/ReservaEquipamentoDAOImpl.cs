using SistemaLab.Model;
using System;
using System.Collections.Generic;

namespace SistemaLab.DAO.DAOImpl
{
    public class ReservaEquipamentoDAOImpl : ReservaEquipamentoDAO
    {
        private static List<ReservaEquipamento> reservasEquipamentos = new List<ReservaEquipamento>();
        private static int con = 0;

        // Construtor padrão
        public ReservaEquipamentoDAOImpl()
        {
            if (reservasEquipamentos == null)
            {
                reservasEquipamentos = new List<ReservaEquipamento>();
            }
        }

        public ReservaEquipamento buscarPorId(int id)
        {
            ReservaEquipamento reservaEquipamento = reservasEquipamentos.Find(r => r.id == id);
            return reservaEquipamento;
        }

        public List<ReservaEquipamento> buscarTodos()
        {
            return new List<ReservaEquipamento>(reservasEquipamentos);
        }

        public ReservaEquipamento inserir(ReservaEquipamento reservaEquipamento)
        {
            reservaEquipamento.id = con++;
            reservasEquipamentos.Add(reservaEquipamento);
            return reservaEquipamento;
        }

        public void remover(ReservaEquipamento reservaEquipamento)
        {
            reservasEquipamentos.RemoveAll(r => r.id == reservaEquipamento.id);
        }
    }
}
