using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinPedidosApp.Models;
using XamarinPedidosApp.Services;
using XPABusiness;
using XPABusiness.Descontos;

namespace XamarinPedidosApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    { 
        public ObservableCollection<Produto> Produto { get; }
        public ObservableCollection<Promocao> Promocao { get; }
        public ObservableCollection<Categoria> Categoria { get; }
        //public Command<Personagem> ExibirProdutoCommand { get; }
        public Command<Produto> CalcularDescontoCommand { get; }

        private ProdutoApiService _produtoApiService;
        private PromocaoApiService _promocaoApiService;
        private CategoriaApiService _categoriaApiService;

        public MainViewModel()
        {
            Titulo = "Catálogo";

            Produto = new ObservableCollection<Produto>();
            Promocao = new ObservableCollection<Promocao>();
            Categoria = new ObservableCollection<Categoria>();

            //ExibirProdutoCommand = new Command<Produto>(ExecuteExibirProdutoCommand);
            _produtoApiService = new ProdutoApiService();
            _promocaoApiService = new PromocaoApiService();
            _categoriaApiService = new CategoriaApiService();
        }

        //private async void ExecuteExibirProdutoCommand(Produto produto)
        //{
        //    await Navigation.PushAsync<DetalhesViewModel>(false, produto);
        //}

        public override async Task LoadAsync()
        {
            Ocupado = true;
            try
            {
                var produtos = await _produtoApiService.GetProdutosAsync();
                var promocoes = await _promocaoApiService.GetPromocoesAsync();
                var categorias = await _categoriaApiService.GetCategoriasAsync();

                Produto.Clear();
                Promocao.Clear();
                Categoria.Clear();

                foreach (var produto in produtos)
                {
                    Produto.Add(produto);
                }
                foreach (var promocao in promocoes)
                {
                    Promocao.Add(promocao);
                }
                foreach (var categoria in categorias)
                {
                    Categoria.Add(categoria);
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine("Erro", ex.Message);
            }
            finally
            {
                Ocupado = false;
            }
        }

        public decimal CalculaDesconto(int idCategoria, Produto produto, int qtd)
        {
            ValorAplicadoBusiness vABusiness = new ValorAplicadoBusiness(produto.price);
            switch (produto.category_id)
            {
                case 2:
                    return vABusiness.AplicaValor(new Celulares(), qtd);
                case 3:
                    return vABusiness.AplicaValor(new LavaRoupas(), qtd);
                case 5:
                    return vABusiness.AplicaValor(new CameraFotografica(), qtd);
                default:
                    return produto.price;
            }
        }
    }
}
