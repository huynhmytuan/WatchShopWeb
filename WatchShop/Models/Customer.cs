using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;


namespace WatchShop.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public bool Activated { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}