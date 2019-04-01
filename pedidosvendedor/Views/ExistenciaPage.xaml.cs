using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace pedidosvendedor.Views
{
    public partial class ExistenciaPage : ContentPage
    {
        public ExistenciaPage()
        {
            InitializeComponent();
        }

        List<string> existencia = new List<string>
         {
            "Aguacate Periban| HASS 14 CAJA Exis: 331,00" , "Aguacate Periban| HASS 16 CAJA Exis: 238,00"
         };

        void Handle_SearchButtonPressed(object sender, System.EventArgs e)
        {
            var existenciaSearched = existencia.Where(c => c.Contains(ExistenciaSearchBar.Text));
            ExistenciaSearchList.ItemsSource = existenciaSearched;
        }
    }
}
