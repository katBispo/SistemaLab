using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLab.Model;

namespace SistemaLab.DAO
{
    public interface UsuarioDAO
    {
        Usuario inserir(Usuario usuario);
        void remover(Usuario usuario);
        Usuario buscarPorId(int id);
        List<Usuario> buscarTodos();

    }
}
