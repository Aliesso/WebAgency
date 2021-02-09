using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K102AgencyWeb.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public DateTime PublishingDate { get; set; }
        public string PhotoUrl { get;set ;}
    }
}
