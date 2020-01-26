using System;
using System.Collections.Generic;

namespace MJCorpNegocio
{
    public class Cliente
    {

        public Cliente()
        {
            Enderecos = new List<Endereco>();
        }

        public Cliente(int idCliente, string sobrenome, string email):this()
        {
            this.IdCliente = idCliente;
            this.Sobrenome = sobrenome;
            this.Email = email;
        }



        public int IdCliente { get; private set; }

        private string _sobrenome;

        public string Sobrenome
        {
            get 
            { 
                //Logica (se usuario pode acessar, se pode ser utilizado)
                return _sobrenome; 
            }
            set 
            { 
                //Logica
                _sobrenome = value; 
            }
        }

        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public Telefone telefone { get; set; }

        public string NomeCompleto { 
            get 
            { 
                if (string.IsNullOrWhiteSpace(Nome))
                {
                    return Sobrenome;
                }
                if (string.IsNullOrWhiteSpace(Sobrenome))
                {
                    return Nome;
                }

                return Sobrenome + ", " + Nome; 
            } 
        }

        public static int QuantidadeInstancia { get; set; }

        public List<Endereco> Enderecos { get; set; }


        public bool Validar()
        {
            var ehValido = true;

            if (string.IsNullOrWhiteSpace(Sobrenome))
            {
                ehValido = false;
            }


            if (string.IsNullOrWhiteSpace(Email))
            {
                ehValido = false;
            }


            return ehValido;
        }


    }
}
