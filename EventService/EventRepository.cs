using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventService
{
    public class EventRepository
    {
        public static List<Event> eventList;

        public static void Add(Event myEvent)
        {
            eventList.Add(myEvent);
        }
    }
}