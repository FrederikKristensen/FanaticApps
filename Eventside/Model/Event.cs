using System;
using System.Collections.Generic;
using System.Text;

namespace EventListe.Model
{
    class Event
    {
        public int EventId { get; set; }

        public string EventNavn { get; set; }

        public TimeSpan? EventTid { get; set; }

        public DateTime? EventDato { get; set; }

        public string EventAdresse { get; set; }

        public int? EventPostnummer { get; set; }
    }
}
