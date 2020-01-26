using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJCorpNegocio
{
    public class EnderecoRepositorio
    {
        public Endereco Obter(int idEndereco)
        {
            Endereco endereco = new Endereco(idEndereco);

            endereco.Rua = "Rua do Sol";
            endereco.Numero = "10";
            endereco.Bairro = "Centro";
            endereco.Cidade = "Sao Luis";
            endereco.Estado = "MA";
            endereco.CEP = "24142-245";
            endereco.Pais = "Brasil";

            return endereco;
        }

        public IEnumerable<Endereco> ObterPeloIdCliente(int idCliente)//interface mais flexivel ao trabalhar com listas de objetos
        {
            var listaEnderecos = new List<Endereco>();

            var endereco1 = new Endereco(1)
            {
                TipoEndereco = TipoEndereco.Casa, //tipo residencial
                Rua = "Rua Grande",
                Numero = "31",
                Bairro = "Centro",
                Cidade = "Sao Luis",
                Estado = "MA",
                CEP = "12342-424",
                Pais = "Brasil"
            };
            var endereco2 = new Endereco(2)
            {
                TipoEndereco = TipoEndereco.Trabalho, //tipo trabalho
                Rua = "Rua do Passeio",
                Numero = "41",
                Bairro = "Centro",
                Cidade = "Sao Luis",
                Estado = "MA",
                CEP = "12342-432",
                Pais = "Brasil"
            };

            listaEnderecos.Add(endereco1);
            listaEnderecos.Add(endereco2);

            return listaEnderecos;
        }

        public bool Salvar(Endereco endereco)
        {
            return true;
        }

    }
}
