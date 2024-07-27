using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Model.enums
{
    public enum StatusEquipamento
    {
        Ativo,
        Manutencao,
        Descarte
    }
    public static class StatusEquipamentoExtensions
    {
        public static string ToFriendlyString(this StatusEquipamento status)
        {
            switch (status)
            {
                case StatusEquipamento.Ativo:
                    return "Ativo";
                case StatusEquipamento.Manutencao:
                    return "Manutenção";
                case StatusEquipamento.Descarte:
                    return "Descarte";
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }
    }
}
