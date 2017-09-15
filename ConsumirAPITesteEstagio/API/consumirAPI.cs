using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ConsumirAPITesteEstagio.API
{
    class ConsumirAPI
    {
        public string[] consumirAPI(string id)
        {
            try
            {
                string urlJson = "https://jsonplaceholder.typicode.com/posts/" + id;
                string resultados = new WebClient().DownloadString(urlJson);
                RootObject dadosJson = JsonConvert.DeserializeObject<RootObject>(resultados);
                string[] retorna = { dadosJson.userId.ToString(), dadosJson.title.ToString(), dadosJson.body.ToString() };
                return retorna;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: \n" + ex.Message);
                string[] retorna = { "", "", "" };
                return retorna;

            }
        }
    }
    
}
