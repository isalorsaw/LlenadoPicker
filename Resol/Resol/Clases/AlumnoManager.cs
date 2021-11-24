using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Resol.Clases
{
    public class AlumnoManager
    {
        private HttpClient getCliente()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");
            return client;
        }
        public async Task<IEnumerable<Alumno>> getAlumno(string rne)
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(App.url + "verAlumno.php?rne="+rne);
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Alumno>>(content);
            }
            return Enumerable.Empty<Alumno>();
        }
        public async Task<IEnumerable<Alumno>> getAlumnoList(string anio)
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(App.url + "veralumnos.php?anio=" + anio);
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Alumno>>(content);
            }
            return Enumerable.Empty<Alumno>();
        }
    }
}
