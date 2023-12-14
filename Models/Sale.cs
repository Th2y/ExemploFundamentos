using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Sale(int id, string product, decimal price)
    {
        public int ID { get; set; } = id;
        public string Product { get; set; } = product;
        public decimal Price { get; set; } = price;
    }
}