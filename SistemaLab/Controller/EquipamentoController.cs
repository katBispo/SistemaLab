using SistemaLab.DAO.DAOImpl;
using SistemaLab.DTO;
using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Controller
{
    public class EquipamentoController
    {
        private EquipamentoDAOImpl dao = new EquipamentoDAOImpl();

        public void cadastrarEquipamento(EquipamentoDTO equipamento)
        {
            Equipamento e = new Equipamento();
            e.nomeEquipamento = equipamento.nomeEquipamento;
            e.marca = equipamento.marca;
            e.modelo = equipamento.modelo;
            dao.inserir(e);

        }
        public List<Equipamento> listarEquipamento()
        {
            return dao.buscarTodos();
        }

        public void excluirEquipamento(Equipamento equipamento)
        {
            dao.remover(equipamento);
        }

    }
}
