using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJCorpNegocio
{
    public class Telefone
    {
        public Telefone(string ddd, string numero)
        { //programação defensiva, barrerira na entrada de dados
            if (string.IsNullOrWhiteSpace(ddd))
                throw new ArgumentNullException("ddd"); //exceção torna construtor previsivel
            if (string.IsNullOrWhiteSpace(numero))
                throw new ArgumentNullException("numero");

            this.Ddd = ddd;
            this.Numero = numero;

        }

        public string Ddd { get; private set; }

        public string Numero { get; private set; }


    }
}
