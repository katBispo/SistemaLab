using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DTO
{
    public class AlunoDTO
    {
        public string matricula {  get; private set; }
        public AlunoDTO(string matricula) {
            this.matricula = matricula;
        }
    }
}
