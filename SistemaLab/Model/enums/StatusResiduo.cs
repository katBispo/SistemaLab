using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Model.enums
{
    public enum StatusResiduo
    {
            Tratado,
            NaoTratado,
            Descartado
     }
    public static class StatusResiduoExtensions
    {
        public static string ToFriendlyString(this StatusResiduo status)
        {
            switch (status)
            {
                case StatusResiduo.Tratado:
                    return "Tratado";
                case StatusResiduo.NaoTratado:
                    return "Não Tratado";
                case StatusResiduo.Descartado:
                    return "Descartado";
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }
    }

}
