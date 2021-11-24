using Newtonsoft.Json;
using Resol.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Resol
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listado2 : ContentPage
    {
        List<aniol> la = new List<aniol>();
        List<grado> lg = new List<grado>();
        public Listado2()
        {
            InitializeComponent();

            /*cmbanio.Items.Add("2015");
            cmbanio.Items.Add("2016");
            cmbgrado.Items.Add("SEPTIMO GRADO");
            cmbgrado.Items.Add("OCTAVO GRADO");*/

            llenarComboAnio();
            llenarComboGrado();
        }
        async void llenarComboAnio()
        {
            la.Clear();
            HttpClient cliente = new HttpClient();
            HttpResponseMessage response = new HttpResponseMessage();
            response = await cliente.GetAsync(App.url + "llenarComboAnio.php");
            if(response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                la = JsonConvert.DeserializeObject<List<aniol>>(content);

                //Llenar el ComboBox con List solamente con una variable.
                foreach(var objeto in la)
                {
                    cmbanio.Items.Add(objeto.anion);
                }
            }

        }
        async void llenarComboGrado()
        {
            lg.Clear();
            HttpClient cliente = new HttpClient();
            HttpResponseMessage response = new HttpResponseMessage();
            response = await cliente.GetAsync(App.url + "llenarComboGrado.php");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                lg = JsonConvert.DeserializeObject<List<grado>>(content);

                //Llenar el ComboBox con List solamente con una variable.
                foreach (var objeto in lg)
                {
                    cmbgrado.Items.Add(objeto.gradon);
                }
            }

        }
        private void Button_Clicked(object sender, EventArgs e)
        {

            int ia = cmbanio.SelectedIndex;
            int ig = cmbgrado.SelectedIndex;

            if(ia==-1)
            {
                DisplayAlert("Mensaje","Seleccione un Anio", "OK");
            }
            else if(ig==-1)
            {
                DisplayAlert("Mensaje", "Seleccione un Grado", "OK");
            }
            else
            { 
                //Capturar el String seleccionado en el Picker.
                //String anio = cmbanio.SelectedItem.ToString();

                aniol aa = la[ia];
                grado gg = lg[ig];

                DisplayAlert("Dato del Anio", aa.anioc, "OK");
                DisplayAlert("Dato del Grado", gg.gradoc, "OK");

                /*
                 try
                {
                    AlumnoManager manager = new AlumnoManager();
                    var res = await manager.getAlumnoList(AA.ANIOC,GG.GRADOC);
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
                 */

            }
        }
    }
}