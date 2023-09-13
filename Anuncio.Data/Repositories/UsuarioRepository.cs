﻿using Anuncio.Data.Entities;
using Anuncio.Data.Settings;
using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anuncio.Data.Repositories
{
    public class UsuarioRepository
    {
        public void Add(Usuario usuario)
        {
            var query = @"
                INSERT INTO USUARIO(
                    ID,
                    NOME,
                    EMAIL,
                    SENHA,
                    DATAHORACRIACAO)
                VALUES(
                    @Id,
                    @Nome,
                    @Email, 
                    @Senha, 
                    @DataHoraCriacao)
            ";

            using (var connection = new SqlConnection(SqlServerSettings.GetConnectionSting()))
            {
                connection.Execute(query, usuario);
            }

        }

        public void Update(Usuario usuario)
        {
            var query = @"
                UPDATE USUARIO SET 
                    NOME = @Nome,
                    EMAIL = @Email,
                    SENHA = @Senha
                WHERE
                    ID = @Id
            ";

            using (var connection = new SqlConnection(SqlServerSettings.GetConnectionSting()))
            {
                connection.Execute(query, usuario);
            }

        }

        public void Delete(Usuario usuario)
        {
            var query = @"
                DELETE FROM USUARIO 
                WHERE ID = @Id
            ";

            using (var connection = new SqlConnection(SqlServerSettings.GetConnectionSting()))
            {
                connection.Execute(query, usuario);
            }

        }

        public Usuario? GetById(Guid id)
        {
            var query = @"
                SELECT * FROM USUARIO WHERE ID = @Id
            ";

            using (var connection = new SqlConnection(SqlServerSettings.GetConnectionSting()))
            {
                return connection.Query<Usuario?>(query, new { @Id = id }).FirstOrDefault();
            }
        }
        
        public Usuario? GetByEmail(string email)
        {
            var query = @"
                SELECT * FROM WHERE EMAIL = @Email
            ";

            using (var connection = new SqlConnection(SqlServerSettings.GetConnectionSting()))
            {
                return connection.Query<Usuario?>(query, new { @Email = email }).FirstOrDefault();
            }
        }

        public Usuario? GetByEmailAndSenha(string email, string senha)
        {
            var query = @"
                SELECT * FROM USUARIO WHERE EMAIL  = @Email AND SENHA = @Senha
            ";

            using (var connection = new SqlConnection(SqlServerSettings.GetConnectionSting()))
            {
                return connection.Query<Usuario>(query, new { @Email = email, @Senha = senha }).FirstOrDefault();
            }
        }

    }
}
