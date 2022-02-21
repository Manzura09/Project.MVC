using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.App.Models
{
    public class BoutiqueModel
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public string DressStyle{ get; set; }
        public double DressCost { get; set; }
    }
}