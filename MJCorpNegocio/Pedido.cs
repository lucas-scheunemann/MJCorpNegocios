using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJCorpNegocio
{
    public class Pedido
    {
        public Pedido()
        {

        }

        public Pedido (int idPedido, DateTime data)
        {
            this.Data = data;

        }

        public int IdPedido { get; private set; }

        public bool Entregue { get; private set; }

        public DateTime? DataEntrega { get; private set; }

        public bool Cancelado { get; set; }

        public void Cancelar()
        {

            if (Entregue)
                throw new ArgumentException("Pedido Entregue não pode ser cancelado!");

            Cancelado = true;
            

        }

        public void Entregar()
        {
            DataEntrega = DateTime.Now;
            Entregue = true;
        }

        public DateTime? Data { get; set; }


        public bool Validar()
        {
            var ehValido = true;

            if (Data is null || Data < DateTime.Now)
               ehValido = false;

            return ehValido;
            
        }


    }
}
