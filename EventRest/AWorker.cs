using EventRest.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EventRest
{
    internal class AWorker
    {
        private const string URl = "http://localhost:63635/api/Events";
        //private const string URl = "";

        public async void Start()
        {
            IList<Event> events = await GetAllEventAsync();
            foreach (Event event in events) 
            {
            Console.WriteLine(event);
            }

        }

        public async Task<IList<Event>> GetAllEventAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(URL);
                IList<Event> cList = JsonConvert.DeserializeObject<IList<Event>>(content);
                return cList;
            }
        }
    }
}
