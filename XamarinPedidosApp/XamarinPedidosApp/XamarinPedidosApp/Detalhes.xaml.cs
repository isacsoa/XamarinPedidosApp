using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPedidosApp.ViewModel;

namespace XamarinPedidosApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalhes : ContentPage
    {
        private DetalhesViewModel ViewModel => BindingContext as DetalhesViewModel;

        public Detalhes()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await ViewModel.LoadAsync();
        }
    }
}