using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using TestesUnitarios.Controllers;
using TestesUnitarios.Dados;
using TestesUnitarios.Models;
using Xunit;

namespace Testes
{
    public class MetodosTestados
    {
        [Fact]
        public void Somar()
        {
            Assert.NotEqual(5, 4 + 4);
        }

        [Theory]
        [InlineData("Paralelepipedo", "Para")]
        [InlineData("Aviao", "vi")]
        [InlineData("Atualmente", "mente")]
        public void VerificaSubString(string palavra, string subpalavra)
        {
            Assert.Contains(subpalavra, palavra);
        }

        [Fact]
        public void TestarResultado()
        {
            var mock = new Mock<IMetodos>();

            mock.Setup(p => p.PegarNomePeloId(2)).Returns("Siena");

            CarrosController carros = new CarrosController(mock.Object);

            string resultado = carros.PegarNomePeloId(2);

            Assert.Equal("Siena", resultado);

        }

        [Fact]
        public void VezesChamadas()
        {
            var mock = new Mock<IMetodos>();

            mock.Setup(p => p.PegarNomePeloId(It.IsAny<int>()));

            mock.Object.PegarNomePeloId(1);
            mock.Object.PegarNomePeloId(2);
            mock.Object.PegarNomePeloId(3);

            mock.Verify(e => e.PegarNomePeloId(It.IsAny<int>()), Times.AtLeast(3));
        }

        [Fact]
        public void VerificarObjeto()
        {
            var mock = new Mock<IMetodos>();
            mock.Setup(p => p.PegarTodos());

            var carros = mock.Object.PegarTodos();
            IEnumerable<Carro> c = null;

            Assert.Equal<Carro>(c, carros);

        }
    }
}
