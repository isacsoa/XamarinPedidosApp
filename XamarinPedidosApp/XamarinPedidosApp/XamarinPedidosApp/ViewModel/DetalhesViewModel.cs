using System;
using System.Collections.Generic;
using System.Text;
using XamarinPedidosApp.Models;

namespace XamarinPedidosApp.ViewModel
{
    public class DetalhesViewModel : BaseViewModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                SetProperty(ref _name, value);
            }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                SetProperty(ref _description, value);
            }
        }

        private string _photo;
        public string Photo
        {
            get { return _photo; }
            set
            {
                SetProperty(ref _photo, value);
            }
        }

        public DetalhesViewModel(Produto produto)
        {
            Name = produto.name;
            Description = produto.description;
            Photo = produto.photo;

            Titulo = "Detalhes";
        }
    }
}
