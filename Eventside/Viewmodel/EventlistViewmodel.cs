using EventListe.Common;
using EventListe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EventListe.Viewmodel
{
    class EventlistViewmodel : INotifyPropertyChanged
    {
        private Event _newEvent = new Event();
        private Relaycommand _OpretEvent;

        public Event NewEvent
        {
            get { return _newEvent; }
            set { _newEvent = value; OnpropertyChanged("NewEvent"); }
        }

        public Relaycommand OpretEvent => _OpretEvent;

        public EventlistViewmodel()
        {
            _OpretEvent = new Relaycommand(OpretEventMetode);
        }

        private void OpretEventMetode()
        {
            // Kan restservice
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnpropertyChanged(string Propname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Propname));
        }
    }
}
