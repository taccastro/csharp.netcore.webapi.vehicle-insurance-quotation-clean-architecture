namespace SeguroVeiculo.Domain.Entities
{
    public class Seguro
    {
        public int Id { get; set; }
        public Veiculo Veiculo { get; set; }
        public Segurado Segurado { get; set; }
        public decimal ValorSeguro { get; set; }
        public decimal TaxaRisco { get; set; }
        public decimal PremioRisco { get; set; }
        public decimal PremioPuro { get; set; }
        public decimal PremioComercial { get; set; }
    }
}
