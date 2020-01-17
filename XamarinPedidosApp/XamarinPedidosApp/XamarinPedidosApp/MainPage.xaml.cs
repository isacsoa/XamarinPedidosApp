using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinPedidosApp.ViewModel;

namespace XamarinPedidosApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private MainViewModel ViewModel => BindingContext as MainViewModel;
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await ViewModel.LoadAsync();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //if(e.SelectedItem != null)
            //{
            //    ViewModel.ExibirProdutoCommand.Execute(e.SelectedItem);
            //}
        }

    }
}
