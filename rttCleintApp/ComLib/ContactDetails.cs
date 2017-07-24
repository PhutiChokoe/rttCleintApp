using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.Models
{
    public class ContactDetails
    {
        public Guid ClientId { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }

    }
}