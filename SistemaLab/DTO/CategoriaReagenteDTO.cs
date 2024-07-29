using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DTO
{
    public class CategoriaReagenteDTO
    {
        public CategoriaReagenteDTO(string nomeCategoria)
        {
            this.nomeCategoria = nomeCategoria;
        }

        public string nomeCategoria { get; private set; }

    }
}
