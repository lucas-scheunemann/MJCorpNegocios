using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJCorpNegocio
{
    public class ItemPedido
    {
        public ItemPedido()
        {
        }

        public ItemPedido(int idItemPedido, int idProduto, int quantidade, decimal precoCompra)
        {
            this.IdItemPedido = idItemPedido;
            this.IdProduto = idProduto;
            this.Quantidade = quantidade;
            this.PrecoCompra = precoCompra;

        }

        public int IdItemPedido { get; private set; }

        public int Quantidade { get; set; }

        public int IdProduto { get; set; }

        public decimal? PrecoCompra { get; set; }

        public ItemPedido Obter (int idItemPedido)
        {
            return new ItemPedido();
        }

        public bool Salvar()
        {
            return true;
        }

        public bool Validar()
        {
            var ehValido = true;

            if (
                Quantidade <= 0 ||
                PrecoCompra == null ||
                IdProduto <= 0)
                ehValido = false;

            return ehValido;
        }

    }
}
