using SeguroVeiculo.Domain.Entities;
using Xunit;

namespace SeguroVeiculo.Application.Services
{
    public class SeguroServiceTests
    {
        [Fact]
        public void CalcularSeguro_DeveRetornarValoresCorretos()
        {
            var veiculo = new Veiculo { Valor = 10000, MarcaModelo = "Fiat Uno" };
            var segurado = new Segurado { Nome = "João", CPF = "12345678900", Idade = 30 };
            var service = new SeguroService();
            var seguro = service.CalcularSeguro(veiculo, segurado);

            Assert.Equal(2.5m, seguro.TaxaRisco); // %
            Assert.Equal(250m, seguro.PremioRisco);
            Assert.Equal(257.5m, seguro.PremioPuro);
            Assert.Equal(12.88m, seguro.PremioComercial); // 5% de 257,5 = 12,88
            Assert.Equal(12.88m, seguro.ValorSeguro);
        }
    }
}
