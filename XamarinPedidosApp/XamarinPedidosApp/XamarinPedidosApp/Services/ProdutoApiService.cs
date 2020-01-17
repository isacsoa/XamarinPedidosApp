using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using XamarinPedidosApp.Helpers;
using XamarinPedidosApp.Models;

namespace XamarinPedidosApp.Services
{
    public class ProdutoApiService
    {
        public async Task<List<Produto>> GetProdutosAsync()
        {
            List<Produto> produtos = new List<Produto>();
            try
            {
                var httpClient = new HttpClient();

                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await httpClient.GetAsync(Constantes.ProdutosApiUrl).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string conteudo =
                        response.Content.ReadAsStringAsync().Result;

                    produtos = JsonConvert.DeserializeObject<List<Produto>>(conteudo);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return produtos;
        }
    }
}
