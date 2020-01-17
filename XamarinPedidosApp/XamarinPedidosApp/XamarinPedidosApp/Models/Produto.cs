using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPedidosApp.Models
{
    public class Produto
    {
        public long id { get; set; }
        public dynamic name { get; set; }
        public string description { get; set; }
        public string photo { get; set; }
        public decimal price { get; set; }
        public int? category_id { get; set; }
    }
}
