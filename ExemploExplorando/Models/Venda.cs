using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Venda
    {

        public Venda()
        {
        }

        public Venda(int id, string produto, decimal preco)
        {
            Id =id;
            Produto = produto;
            Preco = preco;
        }

        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id =id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }

        public Venda(int id, string produto, decimal preco, DateTime dataVenda, decimal desconto)
        {
            Id =id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
            Desconto = desconto;
        }
        
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }
    }
}