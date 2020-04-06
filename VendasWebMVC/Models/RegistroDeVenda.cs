using System;
using VendasWebMVC.Models.Enums;

namespace VendasWebMVC.Models
{
    public class RegistroDeVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public StatusDaVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroDeVenda()
        {
        }

        public RegistroDeVenda(int id, DateTime data, double quantidade, StatusDaVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantidade = quantidade;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
