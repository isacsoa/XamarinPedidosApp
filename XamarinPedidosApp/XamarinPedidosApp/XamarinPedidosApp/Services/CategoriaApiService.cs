using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
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
    public class CategoriaApiService
    {
        public async Task<List<Categoria>> GetCategoriasAsync()
        {
            List<Categoria> categorias = new List<Categoria>();
            try
            {
                var httpClient = new HttpClient();

                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                    var response = await httpClient.GetAsync(Constantes.CategoriasApiUrl).ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                    {
                        string conteudo =
                            response.Content.ReadAsStringAsync().Result;

                        categorias = JsonConvert.DeserializeObject<List<Categoria>>(conteudo);
                    }
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return categorias;
        }
    }
}
