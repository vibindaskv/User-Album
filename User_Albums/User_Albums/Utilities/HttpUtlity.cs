using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace User_Albums.Utilities
{
    public class HttpUtlity : IHttpUtility
    {
        public async Task<T> GetData<T>(string baseUrl, T deSerializedList)
        {
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service using HttpClient  
                var response = await client.GetAsync(baseUrl);

                //Checking the response is successful or not which is sent using HttpClient  
                if (response.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var responseData = response.Content.ReadAsStringAsync().Result;
                    if (responseData == null) throw new ArgumentNullException(nameof(responseData));

                    //Deserializing the response recieved from web api and storing into the list  
                    deSerializedList = JsonConvert.DeserializeObject<T>(responseData);

                }
            }
            return deSerializedList;
        }
       }
    }
