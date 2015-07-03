using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EventService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    public class EventService : IEventService
    {
        public Event GetEvent(string eventId)
        {
            return new Event("nom", "adress");
        }

        public void AddEvent(Event myEvent)
        {
            EventRepository.Add(myEvent);
        }

        public string AddString(string myEvent)
        {
            return myEvent;
        }
    }
}
