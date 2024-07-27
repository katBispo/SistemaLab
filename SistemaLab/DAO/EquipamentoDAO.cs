using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DAO
{
    public interface EquipamentoDAO
    {
        Equipamento inserir(Equipamento equipamento);
        void remover(Equipamento equipamento);
        Equipamento buscarPorId(int id);
        List<Equipamento> buscarTodos();
    }
}
