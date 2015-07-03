using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EventService
{
    [DataContract(Name = "Event")]
    public class Event
    {

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address
        {
            get;
            set;
        }

        public Event()
        {
        }

        public Event(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
    }
}