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
    public partial class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}