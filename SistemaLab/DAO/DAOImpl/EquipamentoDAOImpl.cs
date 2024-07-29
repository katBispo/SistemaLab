using SistemaLab.Model;
using System;
using System.Collections.Generic;

namespace SistemaLab.DAO.DAOImpl
{
    public class EquipamentoDAOImpl : EquipamentoDAO
    {
        private static List<Equipamento> equipamentos = new List<Equipamento>();
        private static int con = 0;

        public EquipamentoDAOImpl()
        {
            if (equipamentos == null)
            {
                equipamentos = new List<Equipamento>();
            }
        }

        public Equipamento buscarPorId(int id)
        {
            Equipamento equipamento = equipamentos.Find(e => e.Id == id);
            return equipamento;
        }

        public List<Equipamento> buscarTodos()
        {
            return new List<Equipamento>(equipamentos);
        }

        public Equipamento inserir(Equipamento equipamento)
        {
            equipamento.id = con++;
            equipamentos.Add(equipamento);
            return equipamento;
        }

        public void remover(Equipamento equipamento)
        {
            equipamentos.RemoveAll(e => e.id == equipamento.id);
        }
    }
}
