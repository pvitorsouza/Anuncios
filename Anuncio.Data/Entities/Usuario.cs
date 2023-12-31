﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anuncio.Data.Entities
{
    public class Usuario
    {
        #region Atributos
        private Guid id;
        private string? _nome;
        private string? _email;
        private string? _senha;
        private DateTime? _dataHoraCriacao;
        #endregion

        #region Propriedades 
  public Guid Id { get => id; set => id = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public string? Email { get => _email; set => _email = value; }
        public string? Senha { get => _senha; set => _senha = value; }
        public DateTime? DataHoraCriacao { get => _dataHoraCriacao; set => _dataHoraCriacao = value; }

        #endregion
    }
}
