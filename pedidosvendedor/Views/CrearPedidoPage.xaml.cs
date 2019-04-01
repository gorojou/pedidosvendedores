using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace pedidosvendedor.Views
{
    public partial class CrearPedidoPage : ContentPage
    {
        public CrearPedidoPage()
        {
            InitializeComponent();
        }

        async void OnAnadirLineaButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddExistenciaPage());
        }
    }
}
