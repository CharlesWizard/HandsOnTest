using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Data
{
    public class Class1
    {
        public async Task<string> lol()
        {
            //specify the config  
            string uri = @"http://masglobaltestapi.azurewebsites.net/api/Employees";
            HttpClient client = new HttpClient();
            string response   = await client.GetStringAsync(uri);
            return response;
        }
    }
}
