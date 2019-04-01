using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace pedidosvendedor.Views
{
    public partial class ClientePage : ContentPage
    {
        public ClientePage()
        {
            InitializeComponent();
        }





        async void OnPendienteButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PendientePage());
        }

        async void OnCrearPedidoButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearPedidoPage());
        }
    }
}
