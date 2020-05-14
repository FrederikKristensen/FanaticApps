using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    class Event
    {
        public int EventId { get; set; }

        public string EventNavn { get; set; }

        public int EventTid { get; set; }

        public int EventDato { get; set; }

        public string EventAdresse { get; set; }

        public int EventPostnummer { get; set; }

        public Event()
        {
        }

        public Event(int eventId, string eventNavn, int eventTid, int eventDato, string eventAdresse, int eventPostnummer)
        {
            EventId = eventId;
            EventNavn = eventNavn;
            EventTid = eventTid;
            EventDato = eventDato;
            EventAdresse = eventAdresse;
            EventPostnummer = eventPostnummer;
        }

        public override string ToString()
        {
            return $"{nameof(EventNavn)}: {EventNavn}, {nameof(EventTid)}: {EventTid}, {nameof(EventAdresse)}: {EventAdresse}, {nameof(EventPostnummer)}: {EventPostnummer}, {nameof(EventId)}: {EventId}";
        }
        
    } 
}
