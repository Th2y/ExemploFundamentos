using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploFundamentos.Models
{
    public class SalesHistory
    {
        public int ID { get; set; }
        [JsonProperty("Product")]
        public string Product { get; set; }
        public decimal Price { get; set; }

        public DateTime SaleDate { get; set; }
    }
}