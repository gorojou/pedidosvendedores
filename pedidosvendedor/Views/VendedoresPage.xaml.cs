using System;
using System.Collections.Generic;
using System.Linq;
using pedidosvendedor.Models;
using Xamarin.Forms;

namespace pedidosvendedor.Views
{
    public partial class VendedoresPage : ContentPage
    {
        public VendedoresPage()
        {
            InitializeComponent();
        }


        List<string> vendors = new List<string>
         {
            "Rafa" , "Eugenio" , "Paola" , "Silvia", "Khan Jibran", "Jose Carlos"
         };

        void Handle_SearchButtonPressed(object sender, System.EventArgs e)
        {
            var countriesSearched = vendors.Where(c => c.Contains(VendorsSearchBar.Text));
            VendorsSearchList.ItemsSource = countriesSearched;
        }
    }
}
