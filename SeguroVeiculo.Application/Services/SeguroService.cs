using SeguroVeiculo.Domain.Entities;

namespace SeguroVeiculo.Application.Services
{
    public class SeguroService
    {
        private const decimal MARGEM_SEGURANCA = 0.03m;
        private const decimal LUCRO = 0.05m;

        public Seguro CalcularSeguro(Veiculo veiculo, Segurado segurado)
        {
            var taxaRisco = (veiculo.Valor * 5) / (2 * veiculo.Valor) / 100; // resultado em porcentagem
            var premioRisco = taxaRisco * veiculo.Valor;
            var premioPuro = premioRisco * (1 + MARGEM_SEGURANCA);
            var premioComercial = LUCRO * premioPuro;
            var valorSeguro = premioComercial;

            return new Seguro
            {
                Veiculo = veiculo,
                Segurado = segurado,
                ValorSeguro = decimal.Round(valorSeguro, 2),
                TaxaRisco = decimal.Round(taxaRisco * 100, 2), // exibe em %
                PremioRisco = decimal.Round(premioRisco, 2),
                PremioPuro = decimal.Round(premioPuro, 2),
                PremioComercial = decimal.Round(premioComercial, 2)
            };
        }
    }
}
