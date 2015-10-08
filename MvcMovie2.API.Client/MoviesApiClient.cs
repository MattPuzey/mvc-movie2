using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MvcMovie2.Domain;

namespace MvcMovie2.API.Client
{
    public class MoviesApiClient: HttpClient  
    {
        
        //var client      
        //var Client = new HttpClient();
        //var serializedBody = JsonConvert.SerializeObject(Movie);
	
        //var url = string.Format("{0}/{1}", ConfigurationManager.AppSettings["API_URL"], "movie");
	
        //var response = await client.PostAsync(url, new StringContent(serializedBody, Encoding.UTF8, "application/json"));
	
        //var content = await response.Content.ReadAsStringAsync();
	
        //return JsonConvert.DeserializeObject<>(content);

        public bool DoesMovieExistOnRottenTomatoes()
        {
            

            return false;
        }
    }
}
