using SistemaLab.DAO.DAOImpl;
using SistemaLab.DTO;
using SistemaLab.Model;
using System;
using System.Collections.Generic;

namespace SistemaLab.Controller
{
    public class UsuarioController
    {
        private UsuarioDAOImpl dao = new UsuarioDAOImpl();

        public void cadastrarUsuario(UsuarioDTO usuarioDto)
        {
            Usuario usuario = new Usuario();

            usuario.Nome = usuarioDto.Nome;
            usuario.CPF = usuarioDto.CPF;
            usuario.DataNascimento = usuarioDto.DataNascimento;
            usuario.Email = usuarioDto.Email;
            usuario.Telefone = usuarioDto.Telefone;
            
            dao.inserir(usuario);
        }

        public List<Usuario> listarUsuarios()
        {
            return dao.buscarTodos();
        }

        public void excluirUsuario(Usuario usuario)
        {
            dao.remover(usuario);
        }
    }
}
