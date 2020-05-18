using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp.Model
{
    class Event
    {
        public int EventId { get; set; }

        public string EventNavn { get; set; }

        public TimeSpan? EventTid { get; set; }

        public DateTime? EventDato { get; set; }

        public string EventAdresse { get; set; }

        public int? EventPostnummer { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
