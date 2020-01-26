using System;
using System.Collections.Generic;
using System.Linq;

namespace MJCorpNegocio
{
    public class ClienteRepositorio
    {

        private EnderecoRepositorio _enderecoRepositorio;

        public ClienteRepositorio()
        {
            _enderecoRepositorio = new EnderecoRepositorio();
        }
        
        
        //Sobrecarga --
        public Cliente Obter(int idCliente)
        {
            //logica para obter cliente especifico

            var cliente = new Cliente(idCliente, "Wayne", "wayne@gmail.com");
            cliente.Nome = "Bruce";
            cliente.DataNascimento = new DateTime(1910, 2, 6);
            cliente.telefone = new Telefone("55", "95954857");
            cliente.Enderecos = _enderecoRepositorio.ObterPeloIdCliente(idCliente).ToList();


            return new Cliente();
        }

        public List<Cliente> Obter()
        {
            //logica para obter todos os clientes
            return new List<Cliente>();
        }
        //--Sobrecarga

        
        public bool Salvar(Cliente cliente)
        {
            //logica para persistir o cliente
            return true;

        }

    }
}
