using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DAO
{
    public interface ReservaEquipamentoDAO
    {
        ReservaEquipamento inserir(ReservaEquipamento reservaEquipamento);
        void remover(ReservaEquipamento reservaEquipamento);
        ReservaEquipamento buscarPorId(int id);
        List<ReservaEquipamento> buscarTodos();
    }
}
