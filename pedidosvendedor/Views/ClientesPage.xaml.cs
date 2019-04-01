using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace pedidosvendedor.Views
{
    public partial class ClientesPage : ContentPage
    {
        public ClientesPage()
        {
            InitializeComponent();
        }



        List<string> clientesnom = new List<string>
         {
            "Feria del Campo" , "Kromi" , "Central Madeirense" , "CADA", "Catania"
         };

        List<string> clientescod = new List<string>
         {
            "FC2235" , "KR3095" , "CM2020" , "CA2222", "CAT2323"
         };

        void Handle_SearchNameButtonPressed(object sender, System.EventArgs e)
        {
            var clinomSearched = clientesnom.Where(c => c.Contains(ClientsNameSearchBar.Text));
            ClientsNameSearchList.ItemsSource = clinomSearched;
        }



        void Handle_SearchCodeButtonPressed(object sender, System.EventArgs e)
        {
            var clicodeSearched = clientescod.Where(c => c.Contains(ClientsCodeSearchBar.Text));
            ClientsCodeSearchList.ItemsSource = clicodeSearched;
        }


        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListView lv = (ListView)sender;

            // this assumes your List is bound to a List<Club>
           // Club club = (Club)lv.SelectedItem;

            // assuiming Club has an Id property
            await Navigation.PushAsync(new ClientePage());
        }

       
    }
}
