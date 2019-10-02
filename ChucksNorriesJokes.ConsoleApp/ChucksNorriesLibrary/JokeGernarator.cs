using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChucksNorriesLibrary
{
    public class JokeGernarator
    {

        public async Task<string[]> GetCatagories()
        {
            HttpClient client = new HttpClient();

            string catagoryString = await client.GetStringAsync("https://api.chucknorris.io/jokes/categories");

            var catagories = JsonConvert.DeserializeObject<string[]>(catagoryString);

            return catagories;
        }
    

    /*public async Task<string> GetRandomJoke()
    {
        HttpClient client = new HttpClient();
        string randomJoke = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");

        var joke = JsonConvert.DeserializeObject<Joke>(randomJoke);
;
        return joke.value;
    }*/


    }
}
