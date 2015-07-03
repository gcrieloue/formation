using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Web.Mvc;
using EventWeb.Models;
using Newtonsoft.Json;

namespace EventWeb.Controllers
{
    public class EventController : Controller
    {
        //
        // GET: /Event/

        public ActionResult Index()
        {
            return View(new EventModel("Nom de l'événement", "Adresse"));
        }



        ////
        //// GET: /Event/Details/5

        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        ////
        //// GET: /Event/Create

        public ActionResult Create()
        {
            return View(new EventModel());
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        ////
        //// POST: /Event/Create
        /// 
        /// 

        [HttpPost]
        public ActionResult Create(EventModel myEvent)
        {

            WebClient client = new WebClient();
            var serializeObject = JsonConvert.SerializeObject(myEvent);

            //DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(EventModel));
            //jsonSerializer.ReadObject()
            client.Headers["Content-Type"] = "application/json";
            client.UploadData(new Uri("http://localhost/EventService/EventService.svc/events/postString"), "POST", GetBytes("test"));

            return RedirectToAction("Index");

        }

        ////
        //// GET: /Event/Edit/5

        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        ////
        //// POST: /Event/Edit/5

        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        ////
        //// GET: /Event/Delete/5

        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        ////
        //// POST: /Event/Delete/5

        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
