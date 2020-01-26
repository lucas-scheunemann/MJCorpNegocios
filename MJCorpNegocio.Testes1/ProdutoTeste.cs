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
    public class ProdutoTeste
    {

        [TestMethod]
        public void Validar_quandoObjetoValido_DeveRetornarVerdadeiro()
        {
            //Arrange
            var produto = new Produto(2, "chocolate", 15);

            var esperado = true;
            //Act
            var atual = produto.Validar();
            //Assert
            Assert.AreEqual(atual, esperado);
        }

        [TestMethod]
        public void Validar_quandoNomeInvalido_DeveRetornarFalso()
        {
            //Arrange
            var produto = new Produto(2, "", 15);

            var esperado = false;
            //Act
            var atual = produto.Validar();
            //Assert
            Assert.AreEqual(atual, esperado);
        }

        [TestMethod]
        public void Validar_quandoPrecoInvalido_DeveRetornarFalso()
        {
            //Arrange
            var produto = new Produto(2, "chocolate", -7);

            var esperado = false;
            //Act
            var atual = produto.Validar();
            //Assert
            Assert.AreEqual(atual, esperado);
        }


    }
}
