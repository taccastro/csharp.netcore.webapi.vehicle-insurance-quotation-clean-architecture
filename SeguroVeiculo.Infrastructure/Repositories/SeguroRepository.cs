using SeguroVeiculo.Domain.Entities;
using System.Collections.Generic;

namespace SeguroVeiculo.Infrastructure.Repositories
{
    public class SeguroRepository
    {
        private readonly List<Seguro> _seguros = new();

        public void Add(Seguro seguro)
        {
            _seguros.Add(seguro);
        }

        public IEnumerable<Seguro> GetAll()
        {
            return _seguros;
        }

        public Seguro? GetById(int id)
        {
            return _seguros.Find(s => s.Id == id);
        }

        public decimal GetMediaValorSeguro()
        {
            if (_seguros.Count == 0) return 0;
            return decimal.Round((decimal)_seguros.Average(s => s.ValorSeguro), 2);
        }
    }
}
