using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EventService
{
    [ServiceContract]
    public interface IEventService
    {
        [OperationContract]
        [WebGet(UriTemplate = "events/{eventId}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Event GetEvent(string eventId);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "events", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json)]
        void AddEvent(Event myEvent);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "events/postString", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
        RequestFormat = WebMessageFormat.Json)]
        string AddString(string myEvent);
    }
}
