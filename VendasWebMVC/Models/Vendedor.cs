using System;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Aniversario { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroDeVenda> Vendas { get; set; } = new List<RegistroDeVenda>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime aniversario, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Aniversario = aniversario;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVendas(RegistroDeVenda rv)
        {
            Vendas.Add(rv);
        }

        public void RemoveVendas(RegistroDeVenda rv)
        {
            Vendas.Remove(rv);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendas.Where(rv => rv.Data >= inicial && rv.Data <= final).Sum(rv => rv.Quantidade);
        }
    }
}
