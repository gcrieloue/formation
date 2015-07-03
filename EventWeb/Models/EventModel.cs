using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace EventWeb.Models
{
    public class EventModel
    {
        [Required]
        [Display(Name = "Nom de l'événement")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Adresse")]
        public string Address { get; set; }

        public EventModel()
        {
        }

        public EventModel(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
