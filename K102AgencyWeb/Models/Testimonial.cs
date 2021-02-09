using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K102AgencyWeb.Models
{
    public class Testimonial
    {
        public int ID { get; set; }
        public string PhotoUrl { get; set; }
        public string Fullname { get; set; }
        public string Description { get; set; }
        public string WorkArea { get; set; }
        public int Rating { get; set; }
    }
}
