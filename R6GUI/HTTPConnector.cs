using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;


namespace R6GUI
{
    /// <summary>
    /// Interaction logic for Platform.xaml
    /// </summary>
    public partial class HTTPConnector : Window
    {
        static public class HttpClientConnector
        {
            static public string TestMethod(string name, string platform)
            {


                string baseUrl = "https://r6db.com/api/v2/players?name=";
                string req = baseUrl + name + "&platform" + platform;


                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("x-app-id", "d260a431-4025-409a-a65e-45066ed97450");


                HttpResponseMessage response = client.GetAsync(req).Result;

                if (response.IsSuccessStatusCode)
                {

                    return response.Content.ReadAsStringAsync().Result;

                }
                else
                {
                    return response.Content.ReadAsStringAsync().Result;
                }


            }
        }

    }


}

    
