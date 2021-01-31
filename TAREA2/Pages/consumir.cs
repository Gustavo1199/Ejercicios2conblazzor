using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace TAREA2.Pages
{
    public class consumir
    {
        public List<Result> traerDato()
        {
            WebClient cliente = new WebClient();
            var api = "https://randomuser.me/api/?results=1";
            var datos = cliente.DownloadString(api);
            var resultado = JsonConvert.DeserializeObject<Root>(datos);

            return resultado.results;
        }


    }
}
