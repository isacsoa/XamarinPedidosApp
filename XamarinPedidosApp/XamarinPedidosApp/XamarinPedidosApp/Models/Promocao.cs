using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPedidosApp.Models
{
    public class Promocao
    {
        public dynamic name { get; set; }
        public int category_id { get; set; }
        
        [JsonProperty(PropertyName = "policies")]
        public List<PoliticaPromocao> policies { get; set; }
    }

    public class PoliticaPromocao
    {
        [JsonProperty(PropertyName = "min")]
        public int min { get; set; }
        [JsonProperty(PropertyName = "discount")]
        public decimal discount { get; set; }
    }
}
