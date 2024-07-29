using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DTO
{
    public class TecnicoDTO
    {
        public TecnicoDTO(string registroProfissional)
        {
            this.registroProfissional = registroProfissional;
        }

        public string registroProfissional { get; private set; }

    }
}
