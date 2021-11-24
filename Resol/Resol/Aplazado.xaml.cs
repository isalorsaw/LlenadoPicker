using Resol.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Resol
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aplazado : ContentPage
    {
        public Aplazado()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtanio.Text))
            {

            }
            else
            {
                try
                {
                    AlumnoManager manager = new AlumnoManager();
                    var res = await manager.getAlumnoList(txtanio.Text);
                    if (res != null)
                    {
                        //DisplayAlert("Mensaje", res.ToString(), "OK");
                        lstapla.ItemsSource = res;
                    }
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Mensaje de Error", ex.Message.ToString(), "OK");
                }
            }
        }
    }
}