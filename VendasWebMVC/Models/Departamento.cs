using System;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMVC.Models
{
    public class Departamento
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            this.id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedor v)
        {
            Vendedores.Add(v);
        }
        public void RemoveVendedor(Vendedor v)
        {
            Vendedores.Remove(v);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendedores.Sum(v => v.TotalVendas(inicial, final));
        }
    }
}
