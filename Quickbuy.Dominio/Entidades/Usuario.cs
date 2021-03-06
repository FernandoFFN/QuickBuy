﻿using System.Collections.Generic;
using System.Dynamic;

namespace Quickbuy.Dominio.Entidades
{
    class Usuario
    {
        public int Id{get; set;}
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        /// <summary>
        /// Um Usuário pode ter nenhum ou muitos pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
