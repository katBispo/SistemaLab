using SistemaLab.Model;
using System;
using System.Collections.Generic;

namespace SistemaLab.DAO.DAOImpl
{
    public class UsuarioDAOImpl : UsuarioDAO
    {
        private static List<Usuario> usuarios = new List<Usuario>();
        private static int con = 0;

        public UsuarioDAOImpl()
        {
           
        }

        public Usuario buscarPorId(int id)
        {
            Usuario usuario = usuarios.Find(u => u.Id == id);
            return usuario;
        }

        public List<Usuario> buscarTodos()
        {
            // Retorna uma nova lista para evitar modificações externas
            return new List<Usuario>(usuarios);
        }

        public Usuario inserir(Usuario usuario)
        {
            usuario.Id = con++;
            usuarios.Add(usuario);
            return usuario;
        }

        // Método para remover um usuário
        public void remover(Usuario usuario)
        {
            usuarios.RemoveAll(u => u.Id == usuario.Id);
        }
    }
}
