using Xunit;
using TestesUnitarios;

namespace TestProject1
{
    public class CarrinhoTests
    {
        [Fact]
        public void DeveSomarTotal()
        {
            var c = new Carrinho();

            c.Adicionar(new Item { Nome = "A", Preco = 10 });
            c.Adicionar(new Item { Nome = "B", Preco = 20 });

            Assert.Equal(30, c.Total());
        }

        [Fact]
        public void LimparCarrinho()
        {
            var c = new Carrinho();

            c.Adicionar(new Item { Nome = "A", Preco = 10 });
            c.Limpar();

            Assert.Equal(0, c.Quantidade());
        }

        [Fact]
        public void QuantidadeItens()
        {
            var c = new Carrinho();

            c.Adicionar(new Item());
            c.Adicionar(new Item());

            Assert.Equal(2, c.Quantidade());
        }
    }
}