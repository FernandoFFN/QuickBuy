using Quickbuy.Dominio.Entidades.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy.Dominio.Entidades
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um pedido
        /// ou muitos itens de pedidos
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
