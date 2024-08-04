using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Model.enums
{
    [Flags]
    public enum Caracteristica
    {
        Nenhuma = 0,
        Corrosivo = 1,
        Inflamavel = 2,
        Reativo = 4,
        Patogenico = 8,
        Toxico = 16
    }
    internal class CheckClassificacaoReagente
    {
    }
}
