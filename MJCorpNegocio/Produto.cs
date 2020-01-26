using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJCorpNegocio
{
    public class Produto
    {
        public Produto() //construtor padrão
        {

        }

        public Produto (int idProduto, string nome, decimal preco)
        {
            this.IdProduto = idProduto;
            this.Nome = nome;
            this.Preco = preco;
        }
        public int IdProduto { get; private set; }

        public string Nome { get; set; }

        public decimal? Preco { get; set; } //? = tipo anulável

        public string Descricao { get; set; }

        public bool Validar()
        {
            var ehValido = true;

            if (string.IsNullOrWhiteSpace(Nome))
                ehValido = false;

            if (Preco.Value.Equals(0) || Preco.Value < 0)
                ehValido = false;

            return ehValido;
        }
    }
}
