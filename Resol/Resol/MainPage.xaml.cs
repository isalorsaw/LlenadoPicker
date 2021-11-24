using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Resol
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Perfil(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PerfilA());
        }

        async void Button_Aplazado(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Aplazado());
        }

        async void Button_Listado(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Listado2());
        }
    }
}
