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
    public class PedidoTeste
    {
        [TestMethod]
        public void Validar_SeObjetoValido_RetornaVerdadeiro()
        {
            //Arrange
            var pedido = new Pedido(2, DateTime.Now);

            var esperado = true;
            //Act
            var atual = pedido.Validar();
            //Assert
            Assert.AreEqual(atual, esperado);
        }

        [TestMethod]
        public void Validar_SeDataInvalida_RetornaFalso()
        {
            //Arrange
            var pedido = new Pedido(1, new DateTime(01/01/2020));

            var esperado = false;
            //Act
            var atual = pedido.Validar();

            //Assert
            Assert.AreEqual(atual, esperado);
        }

        [TestMethod]
        public void Entregar_QuandoChamarEntregar_DeveAtribuirComoEntregue()
        {
            //Arrange
            var pedido = new Pedido(5, DateTime.Now);

            //Act
            pedido.Entregar();

            //Assert
            Assert.IsTrue(pedido.Entregue);
            Assert.IsTrue(pedido.DataEntrega.HasValue);
        }

        [TestMethod]
        public void Cancelar_QuandoChamarCancelar_DeveAtribuirComoCancelado()
        {
            //Arrange
            var pedido = new Pedido(5, DateTime.Now);


            //Act
            pedido.Cancelar();
            //Assert
            Assert.IsTrue(pedido.Cancelado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Cancelar_QuandoEntregue_NaoDeveAtribuirComoCancelado()
        {
            //Arrange
            var pedido = new Pedido(5, DateTime.Now);
            pedido.Entregar();

            //Act
            pedido.Cancelar();
            
        }

    }


}
