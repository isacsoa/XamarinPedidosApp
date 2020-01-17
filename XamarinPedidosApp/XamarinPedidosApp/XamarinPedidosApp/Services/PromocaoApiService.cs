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
    public class PromocaoApiService
    {
        public async Task<List<Promocao>> GetPromocoesAsync()
        {
            List<Promocao> promocoes = new List<Promocao>();
            try
            {
                var httpClient = new HttpClient();

                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await httpClient.GetAsync(Constantes.PromocoesApiUrl).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string conteudo =
                        response.Content.ReadAsStringAsync().Result;

                    promocoes = JsonConvert.DeserializeObject<List<Promocao>>(conteudo);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return promocoes;
        }
    }
}
