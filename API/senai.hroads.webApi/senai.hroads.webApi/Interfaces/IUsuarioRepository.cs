﻿using senai.hroads.webAPI.Domains;
using System;
using System.Collections.Generic;

namespace senai.hroads.webAPI.Interfaces
{
    /// <summary>
    /// Interface responsável pelo UsuarioRepository
    /// </summary>
    interface IUsuarioRepository
    {
        /// <summary>
        /// Listar todos os usuários
        /// </summary>
        /// <returns>Lista dos usuários</returns>
        List<Usuario> Listar();

        /// <summary>
        /// Buscar usuário pelo ID
        /// </summary>
        /// <param name="idUsuario">ID do usuário que será buscado</param>
        /// <returns>Usuário encontrado</returns>
        Usuario BuscarPorId(int idUsuario);

        /// <summary>
        /// Cadastrar um usuário
        /// </summary>
        /// <param name="novoUsuario">Objeto novoUsuario com as todas as informações</param>
        void Cadastrar(Usuario novoUsuario);

        /// <summary>
        /// Atualizar os dados de um usuário
        /// </summary>
        /// <param name="idUsuario">ID do usuário que será atualizada</param>
        /// <param name="usuarioAtualizado">Objeto usuarioAtualizado com as novas informações</param>
        void Atualizar(int idUsuario, Usuario usuarioAtualizado);

        /// <summary>
        /// Deletar um usuário
        /// </summary>
        /// <param name="idUsuario">ID do usuário que será deletado</param>
        void Deletar(int idUsuario);

        Usuario BuscarPorEmailSenha(string email, string senha);
    }
}
