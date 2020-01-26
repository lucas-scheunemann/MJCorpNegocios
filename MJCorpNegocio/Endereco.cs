namespace MJCorpNegocio
{
    public class Endereco
    {

        public Endereco(int idEndereco)
        {
            this.IdEndereco = idEndereco;
        }
        public int IdEndereco { get; private set; }

        public TipoEndereco TipoEndereco { get; set; } //retorna residencial ou trabalho

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string CEP { get; set; }

        public string Pais { get; set; }

    }
    


}
