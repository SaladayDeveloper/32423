using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Services
    {
        public Services(service serv)
        {
            id = serv.id;
            name = serv.name;
            price = serv.price;
        }

        public int id { get; set; }
        public string name { get; set; }
        public Nullable<decimal> price { get; set; }
    }
}