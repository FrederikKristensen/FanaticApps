using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    internal class Worker
    {
        static void Main(string[] args)
        {
            //private const string URL = "";

            public void Start()
            {
                IList<Event> EventListe = await GetallEventAsync();
            }
        }
    }
}
