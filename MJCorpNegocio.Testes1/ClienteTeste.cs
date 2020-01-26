using MJCorpNegocio;
using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/* estrutura basica de teste
 [TestMethod]
        public void Metodo_Condicao_ResultadoEsperado()
        {
            //Arrange

            //Act

            //Assert
        } 
 */

namespace MJCorpNegocio.Testes1
{
    [TestClass]
    public class ClienteTeste
    {
        //[método]_[condição]_[resultadoEsperado]

        [TestMethod]
        public void NomeCompleto_QuandoObterNomeCompleto_DeveRetornarNomeSobrenome()
        {
            //Arrange
            Cliente cliente  = new Cliente();
            cliente.Nome = "Bruce";
            cliente.Sobrenome = "Wayne";

            string resutladoEsperado = "Wayne, Bruce";

            //Act
            string resutladoAtual = cliente.NomeCompleto;

            //Assert
            Assert.AreEqual(resutladoEsperado, resutladoAtual);

        }

        [TestMethod]
        public void NomeCompleto_QuandoPrimeiroNomeVazio_DeveRetornarSobrenome()
        {
            //Arrange
            Cliente cliente = new Cliente();
            cliente.Sobrenome = "Wayne";

            string resutladoEsperado = "Wayne";

            //Act
            string resutladoAtual = cliente.NomeCompleto;

            //Assert
            Assert.AreEqual(resutladoEsperado, resutladoAtual);

        }

        [TestMethod]
        public void NomeCompleto_QuandoSobrenomeVazio_DeveRetornarNome()
        {
            //Arrange
            Cliente cliente = new Cliente();
            cliente.Nome = "Bruce";

            string resutladoEsperado = "Bruce";

            //Act
            string resutladoAtual = cliente.NomeCompleto;

            //Assert
            Assert.AreEqual(resutladoEsperado, resutladoAtual);

        }

        [TestMethod]
        public void TestarMembroStaticQuantidadeInstancia() 
        {
            //Arrange
            var c1 = new Cliente();
            c1.Nome = "João";
            Cliente.QuantidadeInstancia++;
            var c2 = new Cliente();
            c2.Nome = "Marcos";
            Cliente.QuantidadeInstancia++;
            var c3 = new Cliente();
            c3.Nome = "Daniel";
            Cliente.QuantidadeInstancia++;

            //Act


            //Assert
            Assert.AreEqual(3, Cliente.QuantidadeInstancia);
        }

        [TestMethod]
        public void Validar_QuandoObjetoForValido_DeveRetornarVerdadeiro()
        {
            //Arrange
            var cliente = new Cliente(5, "Wayne", "wayne@hotmail.com");

            var esperado = true;
            //Act
            var atual = cliente.Validar();

            //Assert
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void Validar_QuandoEmailForInvalido_DeveRetornarFalso()
        {
            //Arrange
            var cliente = new Cliente();
            cliente.Sobrenome = "Wayne";

            var esperado = false;
            //Act
            var atual = cliente.Validar();

            //Assert
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void Validar_QuandoSobrenomeForInvalido_DeveRetornarFalso()
        {
            //Arrange
            var cliente = new Cliente();
            cliente.Email = "wayne@hotmail.com";

            var esperado = false;
            //Act
            var atual = cliente.Validar();

            //Assert
            Assert.AreEqual(esperado, atual);
        }


    }
}
