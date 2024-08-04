using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Model.enums
{
    public enum CaracteristicaResiduo
    {
        Nenhuma = 0,
        Corrosivo = 1,
        Reativo = 2,
        Inflamavel = 4,
        Patogenico = 8,
        Toxico = 16
    }
}
